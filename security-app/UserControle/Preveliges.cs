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
    public partial class Preveliges : UserControl
    {

        public Preveliges()
        {
            InitializeComponent();
        }

        private void Preveliges_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand();
                com.Connection = Connection.getConnection;
                com.CommandText = "select nomRole from Roles";
                SqlDataReader dr = com.ExecuteReader();
                //List<Roles> roles = new List<Roles>();
                //roles.Add(new Roles(-1, "All"));
                while (dr.Read())
                {
                    cbRoles.Items.Add(dr[0].ToString());
                }
                //cbRoles.DataSource = roles;
                //cbRoles.DisplayMember = "nomRole";
                //cbRoles.ValueMember = "idRole";
                Connection.closeConnection();
                com = null;

                if (cbRoles.Items.Count > 0)
                    cbRoles.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        private void cbRoles_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cbRoles.SelectedValue.GetType().Name.Equals("Int32"))
            //{
            //    try
            //    {
            //        SqlCommand com = new SqlCommand();
            //        com.Connection = Connection.getConnection;
            //        com.CommandText = "select * from getPreveliges(@idRole)";
            //        com.Parameters.Add(new SqlParameter("@idRole", cbRoles.SelectedValue));
            //        SqlDataReader dr = com.ExecuteReader();
            //        dataGridView1.Rows.Clear();
            //        while (dr.Read())
            //        {
            //            dataGridView1.Rows.Add(dr[0], dr[1], dr[2]);
            //        }


            //        SqlCommand cmd = new SqlCommand
            //        {
            //            Connection = Connection.getConnection,
            //            CommandText = "exec getNamePrevelegeByNomRole @nomRole"
            //        };
            //        cmd.Parameters.AddWithValue("@nomRole", cbRoles.DisplayMember);
            //        SqlDataReader reader = cmd.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            MessageBox.Show(reader[0].ToString());
            //            lstRight.Items.Add(reader[0].ToString());
            //        }
            //        Connection.closeConnection();
            //    }
            //    catch (Exception ex)
            //    {
            //        LogFile.Message(ex);
            //    }

            //}


        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Connection.getConnection,
                    CommandText = "exec getNamePrevelegeByNomRole @nomRole"
                };
                cmd.Parameters.AddWithValue("@nomRole", cbRoles.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                lstLeft.Items.Clear();
                while (reader.Read())
                {
                    lstLeft.Items.Add(reader[0].ToString());
                }
                cmd = null;

                SqlCommand cmd2 = new SqlCommand
                {
                    Connection = Connection.getConnection,
                    CommandText = "exec getNamePrevelegeByNomRoleNotIn @nomRole"
                };
                cmd2.Parameters.AddWithValue("@nomRole", cbRoles.SelectedItem);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                lstRight.Items.Clear();
                while (reader2.Read())
                {
                    lstRight.Items.Add(reader2[0].ToString());
                }

                Connection.closeConnection();
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        private void btnAllRightLeft_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Connection.getConnection,
                    CommandText = "exec getIdRoleFromCombo @nomRole"
                };
                cmd.Parameters.AddWithValue("@nomRole", cbRoles.SelectedItem);
                int idRole = int.Parse(cmd.ExecuteScalar().ToString());
                cmd = null;

                SqlCommand cmd2 = new SqlCommand
                {
                    Connection = Connection.getConnection,
                    CommandText = "exec insertAllPrevelege @idRole"
                };
                cmd2.Parameters.AddWithValue("@idRole", idRole);
                SqlDataReader reader = cmd2.ExecuteReader();

                
                while (reader.Read())
                {
                    SqlCommand cm = new SqlCommand
                    {
                        Connection = Connection.getConnection,
                        CommandText = "exec insertAllIntoPriviliges @idRole, @idPrevelege"
                    };

                    cm.Parameters.AddWithValue("@idRole", idRole);
                    cm.Parameters.AddWithValue("@idPrevelege", reader[0]);
                    cm.ExecuteNonQuery();
                }
                cmd = null;

                Connection.closeConnection();

                cbRoles_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        private void btnOneRightLeft_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Connection.getConnection,
                    CommandText = "exec insertSelectPrevelege @nomRole, @nomPrevelege"
                };
                cmd.Parameters.AddWithValue("@nomRole", cbRoles.SelectedItem);
                cmd.Parameters.AddWithValue("@nomPrevelege", lstRight.SelectedItem);
                cmd.ExecuteNonQuery();
                cmd = null;

                Connection.closeConnection();

                cbRoles_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        private void btnOneLeftRight_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Connection.getConnection,
                    CommandText = "exec deletePrevelegeFromHavePreveleges @nomRole, @nomPrevelege"
                };
                cmd.Parameters.AddWithValue("@nomRole", cbRoles.SelectedItem);
                cmd.Parameters.AddWithValue("@nomPrevelege", lstLeft.SelectedItem);
                cmd.ExecuteNonQuery();
                cmd = null;

                Connection.closeConnection();

                cbRoles_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }

        private void btnAllLeftRight_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Connection.getConnection,
                    CommandText = "exec deleteAllHavePreveleges @nomRole"
                };
                cmd.Parameters.AddWithValue("@nomRole", cbRoles.SelectedItem);
                cmd.ExecuteNonQuery();
                cmd = null;

                Connection.closeConnection();

                cbRoles_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }
    }
}
