using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace security_app
{
    public partial class AddRole : UserControl
    {
        public AddRole()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viderZone();
        }

        private void viderZone()
        {
            txtDesc.Clear();
            txtNom.Clear();
            txtNom.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //cancel adding new role and go back to roles management
            if (txtNom.Text != "" ||  txtDesc.Text != "")
            {
                if(MessageBox.Show("Êtes vous sûr d'annuler cette opération?", "leave", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    goToManagement();
                }
            }
            else
            {
                goToManagement();
            }
        }

        private void goToManagement()
        {
            //clear zones and go back to roles management
            viderZone();
            if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("RolesManagment"))
            {
                RolesManagment u = new RolesManagment();
                u.Dock = DockStyle.Fill;

                frmHome.Instance.pnlContainer.Controls.Add(u);
            }
            frmHome.Instance.pnlContainer.Controls["RolesManagment"].BringToFront();
        }
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            //add role to database
            try
            {
                SqlCommand com = new SqlCommand();
                com.Connection = Connection.getConnection;
                com.CommandText = "insert into Roles(nomRole,description,createdBy,dateCreation) values(@nomRole,@description,@createdBy,@dateCreation)";
                com.Parameters.Add(new SqlParameter("@nomRole", txtNom.Text));
                com.Parameters.Add(new SqlParameter("@description", txtDesc.Text));
                com.Parameters.Add(new SqlParameter("@createdBy", User.login));
                com.Parameters.Add(new SqlParameter("@dateCreation", DateTime.Now));

                com.ExecuteNonQuery();
                Connection.closeConnection();
               
                com = null;
                MessageBox.Show("Le role est ajouté avec succès.");

                //invoke labeltext changed to update datagrid view
                Control RolesManagement = frmHome.Instance.pnlContainer.Controls["RolesManagment"];
                var roles = (Control)RolesManagement.Controls["tableLayoutPanel1"];
                var label2 = (Label)roles.Controls["label2"];
                label2.Text = txtNom.Text;

            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
                MessageBox.Show("Erreur !! Essayer plutard.");
            }
            goToManagement();
        }
    }
}