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
    public partial class GiveInherite : UserControl
    {
        bool giveallPemitions = false;

        List<int> idIhreritedRoles;

        public GiveInherite()
        {
            InitializeComponent();
        }

        private void GiveInherite_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnAllPer_Click(object sender, EventArgs e)
        {
            giveallPemitions = !giveallPemitions;

            foreach (DataGridViewRow row in dtRols.Rows)
            {
                row.Cells[2].Value = giveallPemitions;
            }
            if (giveallPemitions)
                btnAllPer.Text = "annuler tous";
            else
                btnAllPer.Text = "hériter tous";
        }

        private void RefreshDataGridView()
        {
            dtRols.Rows.Clear();
            try
            {
                SqlCommand com = new SqlCommand();
                com.Connection = Connection.getConnection;
                com.CommandText = "select idRole,nomRole from Roles where nomRole not like @nomRole";
                com.Parameters.Add(new SqlParameter("@nomRole", Program.roleName));
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    dtRols.Rows.Add(dr[0], dr[1]);
                }

                Connection.closeConnection();
                com = null;
                dr = null;

                SqlCommand com2 = new SqlCommand();
                com2.Connection = Connection.getConnection;
                com2.CommandText = "select idInhertedRole from herite where idRole = @idRole";
                com2.Parameters.Add(new SqlParameter("@idRole", Program.idRole));
                SqlDataReader dr2 = com2.ExecuteReader();

                idIhreritedRoles = new List<int>();

                while (dr2.Read())
                {
                    idIhreritedRoles.Add(Convert.ToInt32(dr2[0]));
                }

                foreach (DataGridViewRow row in dtRols.Rows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    if (idIhreritedRoles.IndexOf(id) != -1)
                    {
                        row.Cells[2].Value = true;
                    }
                    else
                    {
                        row.Cells[2].Value = false;
                    }
                }

                Connection.closeConnection();
                com2 = null;

            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        private void txtRoleName_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("ModifyRole"))
            {
                ModifyRole u = new ModifyRole();
                u.Dock = DockStyle.Fill;

                frmHome.Instance.pnlContainer.Controls.Add(u);
            }
            frmHome.Instance.pnlContainer.Controls["ModifyRole"].BringToFront();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voulez vraiment enregistrer ces changements?", "Enregistrer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool done = true;
                foreach (DataGridViewRow row in dtRols.Rows)
                {
                    if (row.Cells[2].Value.Equals(true))
                    {
                        if (idIhreritedRoles.IndexOf(Convert.ToInt32(row.Cells[0].Value)) > -1)
                            continue;

                        try
                        {
                            SqlCommand com = new SqlCommand();
                            com.Connection = Connection.getConnection;
                            com.CommandText = "insert into Herite values (@idRole,@idInherRole)";
                            com.Parameters.Add(new SqlParameter("@idRole", Program.idRole));
                            com.Parameters.Add(new SqlParameter("@idInherRole", row.Cells[0].Value));
                            com.ExecuteNonQuery();
                            Connection.closeConnection();
                            idIhreritedRoles.Add(Convert.ToInt32(row.Cells[0].Value));
                            com = null;
                        }
                        catch (Exception ex)
                        {
                            LogFile.Message(ex);
                            done = false;
                        }
                    }
                    else
                    {
                        // if checkbox not checked then delete role from inherite if it exists in list of inherited roles
                        try
                        {
                            //check if the role exists in list of inherited roles
                            if (idIhreritedRoles.IndexOf(Convert.ToInt32(row.Cells[0].Value)) > -1)
                            {
                                SqlCommand com = new SqlCommand();
                                com.Connection = Connection.getConnection;
                                com.CommandText = "delete from Herite where idRole= @idRole and idInhertedRole = @idInherRole";
                                com.Parameters.Add(new SqlParameter("@idRole", Program.idRole));
                                com.Parameters.Add(new SqlParameter("@idInherRole", row.Cells[0].Value));
                                com.ExecuteNonQuery();
                                Connection.closeConnection();
                                idIhreritedRoles.Remove(Convert.ToInt32(row.Cells[0].Value));
                                com = null;
                            }
                        }
                        catch (Exception ex)
                        {
                            LogFile.Message(ex);
                            done = false;
                        }
                    }
                }

                //change text in inherited roles in modifyRole :
                Control ModifyRole = frmHome.Instance.pnlContainer.Controls["ModifyRole"];
                var groupeInher = (Control)ModifyRole.Controls["tblModifyRole"];
                TextBox txtInherite = (TextBox)groupeInher.Controls["txtInherite"];

                try
                {
                    //get the list of inherited roles of the actual role from dababase
                    SqlCommand com2 = new SqlCommand();
                    com2.Connection = Connection.getConnection;
                    com2.CommandText = "getInheriteList";
                    com2.CommandType = CommandType.StoredProcedure;
                    com2.Parameters.AddWithValue("@idRole", Program.idRole);

                    com2.Parameters.Add("@roles", SqlDbType.VarChar, 255);
                    com2.Parameters["@roles"].Direction = ParameterDirection.Output;
                    string list = "";
                    com2.ExecuteNonQuery();
                    list = (string)com2.Parameters["@roles"].Value;
                    txtInherite.Text = list;

                    Connection.closeConnection();
                    com2 = null;
                }
                catch (Exception ex)
                {
                    LogFile.Message(ex);
                    done = false;
                }

                if (done)
                    MessageBox.Show("Les informations sont modifiées avec succès");
                else
                    MessageBox.Show("Erreur!!");

                btnCancel.PerformClick();

            }
        }
    }
}
