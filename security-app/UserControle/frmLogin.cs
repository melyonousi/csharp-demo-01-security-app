using System;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO.IsolatedStorage;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace security_app
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        /*mouvement form*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
        int wparam, int lparam);

        /// <summary>
        /// mouse down on form to deplcaed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); /*function*/
            SendMessage(this.Handle, 0x112, 0xf012, 0);  /*function*/
        }

        /// <summary>
        /// validation methode
        /// </summary>
        /// <returns></returns>
        private bool IsValide()
        {
            if (txtLogin.Text.Trim() == string.Empty)
            {
                lblError.Text = "Le nom d'utilisateur doit être remplie";
                txtLogin.Focus();
                return false;
            }
            if (txtPassWord.Text.Trim() == string.Empty)
            {
                lblError.Text = "Le mos de passe doit être remplie";
                txtPassWord.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// event click button to connect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            if (IsValide())
            {
                var com = new SqlCommand();
                try
                {
                    com.Connection = Connection.getConnection;

                    com.CommandText = "select * from [user] where login = @login";
                    com.Parameters.Add(new SqlParameter("@login", txtLogin.Text));

                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        if (Crypt.DecrypterPassWord(dr[1].ToString()).Equals(txtPassWord.Text))
                        {
                            if (ck_save_passwrd.Checked)
                            {
                                // save login to remember it
                                if (ck_save_passwrd.Checked)
                                {
                                    using (StreamWriter sw = new StreamWriter("login.txt"))
                                    {
                                        sw.Write($"{txtLogin.Text},{dr["password"]}");
                                    }
                                }
                            }

                            // set data user to class user
                            User.login = dr[0].ToString();
                            User.dateCreation = Convert.ToDateTime(dr[2]);
                            User.dateExperation = Convert.ToDateTime(dr[3]);
                            User.nom = dr[4].ToString();
                            User.email = dr[5].ToString();
                            User.idRole = Convert.ToInt32(dr[6]);

                            SqlCommand com2 = new SqlCommand();
                            com2.Connection = Connection.getConnection;
                            com2.CommandText = "select nomRole from Roles where idRole = @idRole";
                            com2.Parameters.Add(new SqlParameter("@idRole", User.idRole));
                            User.role = com2.ExecuteScalar().ToString();
                            Connection.closeConnection();
                            com2 = null;

                            SqlCommand com3 = new SqlCommand();
                            com3.Connection = Connection.getConnection;
                            com3.CommandText = "select namePrevelege,controlName from Preveliges p " +
                            "inner join HavePrevelige h on p.idPrevelege = h.idPrevelege " +
                            "where idRole = @idRole";
                            com3.Parameters.Add(new SqlParameter("@idRole", User.idRole));

                            SqlDataReader dr1 = com3.ExecuteReader();
                            while (dr1.Read())
                            {
                                User.preveliges.Add(dr1[0].ToString());
                                User.controles.Add(dr1[1].ToString());
                            }

                            Connection.closeConnection();
                            com3 = null;
                            dr1 = null;

                            //System.Windows.Forms

                            // open user form
                            var h = new frmHome();
                            this.Hide();
                            h.ShowDialog();
                            this.Close();
                        }
                        else
                            lblError.Text = "Le mos de passe incorrect";
                    }
                    else
                        lblError.Text = "Le mos de passe incorrect";

                    Connection.closeConnection();

                    com = null;
                }
                catch (Exception ex)
                {
                    com = null;
                    LogFile.Message(ex);
                }
            }
        }

        /// <summary>
        /// exit from program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes vous sûr de quitter ce programme", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Environment.Exit(0);
        }

        /// <summary>
        /// display password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesplayPassword_Click(object sender, EventArgs e)
        {
            txtPassWord.UseSystemPasswordChar = !txtPassWord.UseSystemPasswordChar;
        }

        /// <summary>
        /// Change the backcolor of TextBox and the content of labels whene the textbox isn't empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        /// <summary>
        /// Change the backcolor of TextBox and the content of labels whene the textbox isn't empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.White;
        }

        /// <summary>
        /// Change backcolor of the TextBoxes and the content of labels whene the textbox isn't empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.LightSkyBlue;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string data = "";
            try
            {
                using (StreamReader sr = new StreamReader("login.txt"))
                {
                    data = sr.ReadToEnd();
                    txtLogin.Text = data.Split(',')[0];
                    txtPassWord.Text = Crypt.DecrypterPassWord(data.Split(',')[1].ToString());
                    ck_save_passwrd.Checked = true;
                    btnDesplayPassword.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }

            //User.preveliges.Add("label1");
            //List<Control> controles = new List<Control>();
            //controles.Add(label1);

            //foreach (Control control in controles)
            //{
            //    if (User.preveliges.IndexOf(control.Name.ToString()) == -1)
            //    {
            //        control.Visible = false;
            //    }
            //}
        }

        private void ck_save_passwrd_CheckedChanged(object sender, EventArgs e)
        {
            if (!ck_save_passwrd.Checked)
            {
                btnDesplayPassword.Enabled = !ck_save_passwrd.Checked;
                txtPassWord.Clear();
            }
            else
            {
                btnDesplayPassword.Enabled = false;
                txtPassWord.UseSystemPasswordChar = true;
            }
        }
    }
}
