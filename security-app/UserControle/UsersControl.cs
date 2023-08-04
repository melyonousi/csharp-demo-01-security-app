using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace security_app
{

    public partial class UsersControl : UserControl
    {
        public UsersControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this method fill data gride view user control
        /// </summary>
        private void FillDataGridViewUser()
        {
            var com = new SqlCommand();
            try
            {
                dtGridUsers.Rows.Clear();

                com.CommandText = "select login, idRole, datecreation, dateexpiration, " +
                    "nom, email from [user] WHERE login != @login";
                com.Parameters.AddWithValue("@login", User.login);
                com.Connection = Connection.getConnection;

                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    SqlCommand cm = new SqlCommand
                    {
                        Connection = Connection.getConnection,
                        CommandText = "SELECT nomRole FROM Roles WHERE idRole like @idRole"
                    };
                    cm.Parameters.AddWithValue("@idRole", dr[1]);
                    dtGridUsers.Rows.Add(dr[0], cm.ExecuteScalar(), dr[2], dr[3], dr[4], dr[5]);
                    cm = null;
                }

                Connection.closeConnection();
                com = null;
                dr.Close();
                dr = null;
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        /// <summary>
        /// on UserControl Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsersControl_Load(object sender, EventArgs e)
        {
            FillDataGridViewUser();
        }

        /// <summary>
        /// button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //bring add user interface to front to add users 
            if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("AddUser"))
            {
                AddUser u = new AddUser();
                u.Dock = DockStyle.Fill;

                frmHome.Instance.pnlContainer.Controls.Add(u);
            }
            frmHome.Instance.pnlContainer.Controls["AddUser"].BringToFront();
            ActivateControles(true);

            // clear field text from addUser 
            Control userControl = frmHome.Instance.pnlContainer.Controls["AddUser"];
            var addUser = (Control)userControl.Controls["tblLayoutAddUser"];

            // set text to label in add user
            var lblClick = (Label)addUser.Controls["lblClick"];
            lblClick.Text = "add";

            var txtLogin = (TextBox)addUser.Controls["txtLogin"];
            txtLogin.Clear();
            var txtName = (TextBox)addUser.Controls["txtNom"];
            txtName.Clear();
            var txtEmail = (TextBox)addUser.Controls["txtEmail"];
            txtEmail.Clear();
            var dateExpe = (DateTimePicker)addUser.Controls["dpExperation"];
            dateExpe.Value = DateTime.Now;

            txtLogin.Focus();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text != "$")
            {
                FillDataGridViewUser();
                FindSelectedRow(label1);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!FindSelectedRow(txt_search))
                MessageBox.Show("Utilisateur introuvable.");
        }

        /// <summary>
        /// find item by search text box
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        private Boolean FindSelectedRow(Control control)
        {
            if (control.Text == "deleted user")
                return false;

            Boolean index = false;
            foreach (DataGridViewRow row in dtGridUsers.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower().Equals(control.Text.Trim().ToLower()) || row.Cells[3].Value.ToString().ToLower().Equals(control.Text.Trim().ToLower()))
                {
                    row.Selected = true;
                    index = true;
                }
            }

            return index;
        }

        /// <summary>
        /// on field text key up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch.PerformClick();
        }

        /// <summary>
        /// on cell content click datagride view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtGridUsers.Columns[e.ColumnIndex].Name == "Modify")
                {
                    //AddUser.resetPanel = false;

                    //if user clicks on modify they will go to modify user interface
                    string login = dtGridUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("AddUser"))
                    {
                        AddUser u = new AddUser();
                        u.Dock = DockStyle.Fill;

                        frmHome.Instance.pnlContainer.Controls.Add(u);
                    }

                    ActivateControles(false);


                    frmHome.Instance.pnlContainer.Controls["AddUser"].BringToFront();

                    Control userControl = frmHome.Instance.pnlContainer.Controls["AddUser"];

                    var addUser = (Control)userControl.Controls["tblLayoutAddUser"];

                    //show informations in add user interface
                    var lblClick = (Label)addUser.Controls["lblClick"];
                    lblClick.Text = "edit";

                    TextBox txtLogin = (TextBox)addUser.Controls["txtLogin"];

                    txtLogin.Text = dtGridUsers.Rows[e.RowIndex].Cells[0].Value.ToString();

                    TextBox txtName = (TextBox)addUser.Controls["txtNom"];
                    txtName.Text = dtGridUsers.Rows[e.RowIndex].Cells[4].Value.ToString();

                    TextBox txtEmail = (TextBox)addUser.Controls["txtEmail"];
                    txtEmail.Text = dtGridUsers.Rows[e.RowIndex].Cells[5].Value.ToString();

                    DateTimePicker dateExpe = (DateTimePicker)addUser.Controls["dpExperation"];
                    dateExpe.Value = Convert.ToDateTime(dtGridUsers.Rows[e.RowIndex].Cells[3].Value);

                    ComboBox cbRoles = (ComboBox)addUser.Controls["cbRoles"];
                    cbRoles.SelectedItem = dtGridUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                }

                if (dtGridUsers.Columns[e.ColumnIndex].Name == "Delete")
                {
                    //if user click on delete button >> delete user from database
                    if (MessageBox.Show("Voulez vous vraiment supprimer cet utilisateur?", "Suppression", MessageBoxButtons.YesNo)== DialogResult.Yes)
                    {
                        string login = dtGridUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                        var com = new SqlCommand
                        {
                            Connection = Connection.getConnection,
                            CommandText = "delete from [user] where login = @login"
                        };

                        com.Parameters.Add(new SqlParameter("@login", login));
                        com.ExecuteNonQuery();
                        Connection.closeConnection();
                        com = null;

                        //change label text to invoke refreshing datagridview

                        if (label1.Text == "deleted user")
                            label1.Text = "$";
                        label1.Text = "d";
                        label1.Text = "deleted user";

                        MessageBox.Show("Utilisateur supprimé.");
                    }
                }
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        /// <summary>
        /// activate controls
        /// </summary>
        /// <param name="v"></param>
        private void ActivateControles(bool v)
        {
            var userControl = frmHome.Instance.pnlContainer.Controls["AddUser"];

            var addUser = (Control)userControl.Controls["tblLayoutAddUser"];

            // desable textbox login and password
            var txtLogin = (TextBox)addUser.Controls["txtLogin"];
            txtLogin.Enabled = v;
            var txtPasword = (TextBox)addUser.Controls["txtPassword"];
            txtPasword.Enabled = v;

            // add user
            var btnAddRoles = (Button)addUser.Controls["btnAddRoles"];
            btnAddRoles.Visible = v;
            var btnClear = (Button)addUser.Controls["btnClear"];
            btnClear.Visible = v;

            // edit user
            var btnResetPassword = (Button)addUser.Controls["btnResetPassword"];
            btnResetPassword.Visible = !v;
            var btnEditUser = (Button)addUser.Controls["btnUser"];
            btnEditUser.Visible = !v;

            // reset password
            var lblNewPassword = (Label)addUser.Controls["lblNewPassword"];
            lblNewPassword.Visible = false;
            var lblConfirmPassword = (Label)addUser.Controls["lblConfirmPassword"];
            lblConfirmPassword.Visible = false;
            var txtNewPassword = (TextBox)addUser.Controls["txtNewPassword"];
            txtNewPassword.Visible = false;
            var txtConfirmPassword = (TextBox)addUser.Controls["txtConfirmPassword"];
            txtConfirmPassword.Visible = false;
            var btnConfirm = (Button)addUser.Controls["btnConfirmPassword"];
            btnConfirm.Visible = false;
        }
    }
}
