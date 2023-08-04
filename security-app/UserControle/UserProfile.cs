using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace security_app
{
    public partial class UserProfile : UserControl
    {
        // activate field text
        bool active = false;
        public UserProfile()
        {
            InitializeComponent();
        }

        private void activate(bool v)
        {
            var UserProfile = frmHome.Instance.pnlContainer.Controls["UserProfile"];
            var tableL = (Control)UserProfile.Controls["tblLayoutAddUser"];
            var lblOldPass = (Label)tableL.Controls["lblOldPass"];
            lblOldPass.Visible = v;
            var lblNewPass = (Label)tableL.Controls["lblNewPass"];
            lblNewPass.Visible = v;
            var lblConf = (Label)tableL.Controls["lblConf"];
            lblConf.Visible = v;
            var txtOldPassword = (TextBox)tableL.Controls["txtOldPassword"];
            txtOldPassword.Visible = v;
            var txtNewPassword = (TextBox)tableL.Controls["txtNewPassword"];
            txtNewPassword.Visible = v;
            var txtConfirmPassword = (TextBox)tableL.Controls["txtConfirmPassword"];
            txtConfirmPassword.Visible = v;
            var btnConferm = (Button)tableL.Controls["btnConfirmPassword"];
            btnConferm.Visible = v;
        }
        private void clearZones()
        {
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private bool IsValide()
        {
            if (txtLogin.Text == String.Empty || !Regex.IsMatch(txtLogin.Text, @"[_]?[a-z-A-Z]+[_]?[.]?[a-z-A-Z]+$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Le nom d'utilisateur doit être remplie ou le format saisie n'est pas valide. Réessayez!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
                return false;
            }

            if (txtNom.Text == String.Empty || !Regex.IsMatch(txtNom.Text, @"[a-z-A-Z]+[ ]?[.]?[a-z-A-Z]+[ ]?[a-zA-Z]+$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Le Nom doit être remplie ou le format saisie n'est pas valide. Réessayer!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNom.Focus();
                return false;
            }
            if (txtEmail.Text == String.Empty || !Regex.IsMatch(txtEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("E-mail doit être remplie ou le format saisie n'est pas valide. Réessayer!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void pnlResetPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            txtRole.Text = User.role;
            txtLogin.Text = User.login;
            txtNom.Text = User.nom;
            txtEmail.Text = User.email;
            dpCreation.Value = User.dateCreation;
            dpExperation.Value = User.dateExperation;
            activate(active);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            active = !active;
            clearZones();
            activate(active);
            btnResetPassword.Text = active ? "Fermer" : "Rénitialiser le mot de passe";

        }

        private void btnUser_Click_1(object sender, EventArgs e)
        {
            if (txtNom.Text == User.nom && txtEmail.Text == User.email)
            {
                MessageBox.Show("Il n'y a pas de modification.");
            }
            else
            {
                try
                {
                    if (IsValide())
                    {
                        var com = new SqlCommand();
                        com.Connection = Connection.getConnection;

                        com.CommandText = "update [user] set nom=@nom,email=@email " +
                       "where login = @login";
                        com.Parameters.Add(new SqlParameter("@login", txtLogin.Text));
                        com.Parameters.Add(new SqlParameter("@nom", txtNom.Text));
                        com.Parameters.Add(new SqlParameter("@email", txtEmail.Text));

                        com.ExecuteNonQuery();
                        Connection.closeConnection();
                        com = null;

                        User.nom = txtNom.Text;
                        User.email = txtEmail.Text;

                        MessageBox.Show("les informations sont modifiées avec succès.");
                    }
                }
                catch (Exception ex)
                {
                    LogFile.Message(ex);
                }
            }
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            var com = new SqlCommand();
            com.Connection = Connection.getConnection;

            com.CommandText = "select password from [user] where login=@login";
            com.Parameters.Add(new SqlParameter("@login", txtLogin.Text));
            var pass = com.ExecuteScalar().ToString();

            if (Crypt.DecrypterPassWord(pass).Equals(txtOldPassword.Text))
            {
                //validation the content of Txetbox reset password
                if (txtNewPassword.Text == String.Empty || !Regex.IsMatch(txtNewPassword.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-])?.{8,}$", RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("Le format de mot de passe doit dépasser huit caractères et contenir des lettres majiscule,miniscule et des chiffres!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNewPassword.Focus();
                    return;
                }
                if (!txtNewPassword.Text.Equals(txtConfirmPassword.Text))
                {
                    MessageBox.Show("Le mot de passe saisie doit être identique avec le nouveau mot de passe. Réessayez!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                    return;
                }

                var com2 = new SqlCommand();
                com2.Connection = Connection.getConnection;
                com2.CommandText = "update [user] set password = @password where login=@login";
                com2.Parameters.Add(new SqlParameter("@password", Crypt.CrypterMotDePass(txtConfirmPassword.Text.ToString())));
                com2.Parameters.Add(new SqlParameter("@login", txtLogin.Text.ToString()));

                com2.ExecuteNonQuery();
                Connection.closeConnection();
                com2 = null;

                MessageBox.Show("Le mot de passe est modifié avec succès.");

                clearZones();
                btnResetPassword.PerformClick();
            }
            else
            {
                MessageBox.Show("L'ancien mot de passe est incorrect!!");
            }
            com = null;
        }
    }
}
