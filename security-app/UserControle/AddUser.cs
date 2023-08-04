using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace security_app
{
    public partial class AddUser : UserControl
    {
        public static string login;

        public AddUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// refrech datagrideview usercontrole by changing label text event
        /// </summary>
        private void updateDataGrideUserControl(string text)
        {
            //find cotrol "usersControle" then find label1 to invoke text change event then refresh datagridView
            Control userControl = frmHome.Instance.pnlContainer.Controls["UsersControl"];
            Label lb1 = (Label)userControl.Controls["label1"];
            lb1.Text = "hello";
            lb1.Text = text;
        }

        /// <summary>
        /// validation of textBox
        /// </summary>
        /// <returns></returns>
        private bool IsValide()
        {
            if (txtLogin.Text == String.Empty || !Regex.IsMatch(txtLogin.Text, @"[_]?[a-z-A-Z]+[_]?[.]?[a-z-A-Z]+$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Le Nom d'Utilisateur doit être remplie ou le format saisie n'est pas valide. Réessayez!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
                return false;
            }

            if (txtNom.Text == String.Empty || !Regex.IsMatch(txtNom.Text, @"[a-z-A-Z]+[ ]?[.]?[a-z-A-Z]+[ ]?[a-zA-Z]+$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Le Nom doit être remplie ou le format saisie n'est pas valide. Réessayez!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNom.Focus();
                return false;
            }
            if (txtEmail.Text == String.Empty || !Regex.IsMatch(txtEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("E-mail doit être remplie ou le format saisie n'est pas valide. Réessayez!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (cbRoles.Text == String.Empty)
            {
                MessageBox.Show("Il faut sélectionner un role", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbRoles.Focus();
                return false;
            }

            if (lblClick.Text.Equals("add"))
            {
                if (txtPassword.Text == String.Empty || !Regex.IsMatch(txtPassword.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-])?.{8,}$", RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("Le format de mot de passe doit dépasser huit caractères et contenir des lettres majiscule,miniscule et des chiffres!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return false;
                }
                if (dpExperation.Value < DateTime.Now)
                {
                    MessageBox.Show($"La date doit être supérieure à {DateTime.Now.ToString("dd/MM/yyyy")}", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                Control userControl = frmHome.Instance.pnlContainer.Controls["UsersControl"];
                var user = (Control)userControl.Controls["tblLytPnlUserControl"];
                var row = ((DataGridView)user.Controls["dtGridUsers"]).SelectedRows[0];
                var dtCreation = Convert.ToDateTime(row.Cells[2].Value);

                if (dpExperation.Value < dtCreation)
                {
                    MessageBox.Show($"La date doit être supérieure à {DateTime.Now.ToString("dd/MM/yyyy")}", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private bool AddUserToDB()
        {
            try
            {
                if (IsValide())
                {
                    SqlCommand commad = new SqlCommand
                    {
                        Connection = Connection.getConnection,
                        CommandText = "exec getIdRoleFromCombo @nomRole"
                    };
                    commad.Parameters.AddWithValue("@nomRole", cbRoles.SelectedItem);
                    int idRole = int.Parse(commad.ExecuteScalar().ToString());

                    SqlCommand com = new SqlCommand();
                    com.Connection = Connection.getConnection;
                    com.CommandText = "insert into [user] values (@login, @password, @dateCreation, @dateExperation, @nom, @email, @idRole)";

                    com.Parameters.AddWithValue("@login", txtLogin.Text);
                    com.Parameters.AddWithValue("@password", Crypt.CrypterMotDePass(txtPassword.Text.Trim()));
                    com.Parameters.AddWithValue("@dateExperation", dpExperation.Value);
                    com.Parameters.AddWithValue("@dateCreation", DateTime.Today);
                    com.Parameters.AddWithValue("@nom", txtNom.Text);
                    com.Parameters.AddWithValue("@email", txtEmail.Text);

                    com.Parameters.AddWithValue("@idRole", idRole);

                    com.ExecuteNonQuery();

                    Connection.closeConnection();
                    com = null;

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Connection.closeConnection();
                if (ex.Message.Contains("PRIMARY KEY constraint"))
                    MessageBox.Show($"{login} existe déjà.");
                txtLogin.Focus();
                LogFile.Message(ex);
                return false;
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Connection.getConnection,
                    CommandText = "SELECT nomRole FROM Roles"
                };
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbRoles.Items.Add(reader[0]);
                }
                cmd = null;
                Connection.closeConnection();
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValide())
                {
                    Control userControl = frmHome.Instance.pnlContainer.Controls["UsersControl"];

                    var addUser = (Control)userControl.Controls["tblLytPnlUserControl"];
                    DataGridViewRow row = ((DataGridView)addUser.Controls["dtGridUsers"]).SelectedRows[0];

                    login = txtLogin.Text.Trim();

                    if (
                        dpExperation.Value.Equals(row.Cells[3].Value)
                        && txtNom.Text.Equals(row.Cells[4].Value)
                        && txtEmail.Text.Equals(row.Cells[5].Value)
                        && cbRoles.Text.Equals(row.Cells[1].Value))
                    {
                        MessageBox.Show("Il n'y a pas de modification.");
                    }
                    else
                    {
                        SqlCommand commad = new SqlCommand
                        {
                            Connection = Connection.getConnection,
                            CommandText = "exec getIdRoleFromCombo @nomRole"
                        };
                        commad.Parameters.AddWithValue("@nomRole", cbRoles.SelectedItem);
                        int idRole = int.Parse(commad.ExecuteScalar().ToString());
                        var com = new SqlCommand();
                        com.Connection = Connection.getConnection;

                        com.CommandText = "update [user] set dateexpiration=@dateEx,nom=@nom,email=@email, idRole=@idRole " +
                            "where login = @login";
                        com.Parameters.Add(new SqlParameter("@login", txtLogin.Text));
                        com.Parameters.Add(new SqlParameter("@dateEx", dpExperation.Value));
                        com.Parameters.Add(new SqlParameter("@nom", txtNom.Text));
                        com.Parameters.Add(new SqlParameter("@email", txtEmail.Text));
                        com.Parameters.Add(new SqlParameter("@idRole", idRole));

                        com.ExecuteNonQuery();
                        Connection.closeConnection();
                        com = null;

                        if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("UsersControl"))
                        {
                            AddUser u = new AddUser();
                            u.Dock = DockStyle.Fill;

                            frmHome.Instance.pnlContainer.Controls.Add(u);
                        }

                        frmHome.Instance.pnlContainer.Controls["UsersControl"].BringToFront();
                        MessageBox.Show("Les informations sont modifiées avec succès.");
                        updateDataGrideUserControl(txtLogin.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            btnResetPassword.Text = btnResetPassword.Text == "Réinitialiser le mot de passe" ? "Fermer" : "Réinitialiser le mot de passe";
            lblNewPassword.Visible = !lblNewPassword.Visible;
            lblConfirmPassword.Visible = !lblConfirmPassword.Visible;
            txtNewPassword.Visible = !txtNewPassword.Visible;
            txtConfirmPassword.Visible = !txtConfirmPassword.Visible;
            btnConfirmPassword.Visible = !btnConfirmPassword.Visible;
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            //validation the content of Txetbox reset password
            if (txtNewPassword.Text == String.Empty || !Regex.IsMatch(txtNewPassword.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-])?.{8,}$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Le format de nouveau mot de passe doit dépasser huit caractères et contenir des lettres majiscule,miniscule et des chiffres!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }
            if (!txtNewPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Le mot de passe saisie doit être identique avec le nouveau mot de passe. Réessayez!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            var com = new SqlCommand();
            com.Connection = Connection.getConnection;
            com.CommandText = "update [user] set password = @password where login=@login";
            com.Parameters.Add(new SqlParameter("@password", Crypt.CrypterMotDePass(txtConfirmPassword.Text.ToString())));
            com.Parameters.Add(new SqlParameter("@login", txtLogin.Text.ToString()));

            com.ExecuteNonQuery();
            Connection.closeConnection();
            com = null;

            if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("UsersControl"))
            {
                AddUser u = new AddUser();
                u.Dock = DockStyle.Fill;

                frmHome.Instance.pnlContainer.Controls.Add(u);
            }

            frmHome.Instance.pnlContainer.Controls["UsersControl"].BringToFront();
            MessageBox.Show("Le mot de passe est modifié avec succès");
            updateDataGrideUserControl(txtLogin.Text);
        }

        /// <summary>
        /// Clear Text Boxes
        /// </summary>
        private void clear()
        {
            foreach (Control c in tblLayoutAddUser.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
            }
            dpExperation.Value = DateTime.Now;
            txtPassword.Clear();
            cbRoles.SelectedItem = null;
            txtLogin.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAddRoles_Click(object sender, EventArgs e)
        {
            if (AddUserToDB())
            {
                //save login in label6 text
                login = txtLogin.Text;

                clear();
                if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("UsersControl"))
                {
                    AddUser u = new AddUser();
                    u.Dock = DockStyle.Fill;

                    frmHome.Instance.pnlContainer.Controls.Add(u);
                }

                frmHome.Instance.pnlContainer.Controls["UsersControl"].BringToFront();
                MessageBox.Show("Utilisateur est ajouté avec succès.");
                updateDataGrideUserControl(txtLogin.Text);
            }
        }

        private void lblPass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
