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
    public partial class ModifyRole : UserControl
    {
        public ModifyRole()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Clear();
            txtDescription.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
                
           
        }

        private void goToManagement()
        {
            //clear zones and go back to roles management
            
            if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("RolesManagment"))
            {
                RolesManagment u = new RolesManagment();
                u.Dock = DockStyle.Fill;

                frmHome.Instance.pnlContainer.Controls.Add(u);
            }
            frmHome.Instance.pnlContainer.Controls["RolesManagment"].BringToFront();
        }

        private void btnConrirmer_Click(object sender, EventArgs e)
        {
            //update role to database
            
            try
            {
                SqlCommand com = new SqlCommand();
                com.Connection = Connection.getConnection;
                com.CommandText = "update Roles set description = @description where nomRole=@nomRole";
                com.Parameters.Add(new SqlParameter("@nomRole", txtNom.Text));
                com.Parameters.Add(new SqlParameter("@description", txtDescription.Text));
                
                com.ExecuteNonQuery();
                Connection.closeConnection();

                com = null;
                MessageBox.Show("Le role est modifié avec succès.");

                //invoke labeltext changed to update datagrid view
                Control RolesManagement = frmHome.Instance.pnlContainer.Controls["RolesManagment"];
                var roles = (Control)RolesManagement.Controls["tableLayoutPanel1"];
                var label2 = (Label)roles.Controls["label2"];
                label2.Text = "$";
                label2.Text = txtNom.Text;

            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
                MessageBox.Show("Erreur!! Essayer plutard.");
            }

            goToManagement();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete user from database
            if(MessageBox.Show("Êtes vous sûr de supprimer ce role?", "Supprission", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //update role to database

                try
                {
                    SqlCommand com = new SqlCommand();
                    com.Connection = Connection.getConnection;
                    com.CommandText = "delete from Roles where nomRole = @nomRole ";
                    com.Parameters.Add(new SqlParameter("@nomRole", txtNom.Text));
                    
                    com.ExecuteNonQuery();
                    Connection.closeConnection();

                    com = null;
                    MessageBox.Show("Le role est suprimé avec succès.");

                    //invoke labeltext changed to update datagrid view
                    Control RolesManagement = frmHome.Instance.pnlContainer.Controls["RolesManagment"];
                    var roles = (Control)RolesManagement.Controls["tableLayoutPanel1"];
                    var label2 = (Label)roles.Controls["label2"];
                    label2.Text = "deleted user";

                }
                catch (Exception ex)
                {
                    LogFile.Message(ex);
                    MessageBox.Show("Erreur!! Essayer plutard.");
                }

                goToManagement();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes vous sûr d'nnuler cet opération?", "Annulation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                goToManagement();
            }
        }

        private void btnEnherited_Click(object sender, EventArgs e)
        {

            //go to GiveInherite interface

            if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("GiveInherite"))
            {
                GiveInherite u = new GiveInherite();
                u.Dock = DockStyle.Fill;

                frmHome.Instance.pnlContainer.Controls.Add(u);
            }
            frmHome.Instance.pnlContainer.Controls["GiveInherite"].BringToFront();


            Control GiveInherite = frmHome.Instance.pnlContainer.Controls["GiveInherite"];
            var give = (Control)GiveInherite.Controls["tblGiveInherite"];
            var roles = (Control)give.Controls["txtRoleName"];
            roles.Text = txtNom.Text;
        }
    }
}
