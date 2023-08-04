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
    public partial class RolesManagment : UserControl
    {
        public RolesManagment()
        {
            InitializeComponent();
        }

        private void RolesManagment_Load(object sender, EventArgs e)
        {
            FillDataGridViewUser();

        }

        private void FillDataGridViewUser()
        {
            //fill datagrid view with roles informations
            try
            {
                var com = new SqlCommand();
                dataGridView1.Rows.Clear();

                com.CommandText = "select * from Roles";
                com.Connection = Connection.getConnection;

                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
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

        private void button1_Click(object sender, EventArgs e)
        {
            //open add roles panel
            if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("AddRole"))
            {
                AddRole u = new AddRole();
                u.Dock = DockStyle.Fill;

                frmHome.Instance.pnlContainer.Controls.Add(u);
            }
            frmHome.Instance.pnlContainer.Controls["AddRole"].BringToFront();
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {

            FillDataGridViewUser();
            FindSelectedRow(label2);
        }

        private Boolean FindSelectedRow(Control control)
        {
            if (control.Text == "deleted user")
                return false;

            Boolean index = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString().ToLower().Equals(control.Text.Trim().ToLower()))
                {
                    row.Selected = true;
                    index = true;
                }
            }

            return index;
        }

        private void btn_search_user_Click(object sender, EventArgs e)
        {
            if (!FindSelectedRow(txtSearch))
                MessageBox.Show("Le role est introuvable.");
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch.PerformClick();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "modify")
                {
                    
                    if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("ModifyRole"))
                    {
                        ModifyRole u = new ModifyRole();
                        u.Dock = DockStyle.Fill;

                        frmHome.Instance.pnlContainer.Controls.Add(u);
                    }
                    frmHome.Instance.pnlContainer.Controls["ModifyRole"].BringToFront();

                    Control ModifyRole = frmHome.Instance.pnlContainer.Controls["ModifyRole"];
                    var groupeInher = (Control)ModifyRole.Controls["tblModifyRole"];
                    TextBox txtInherite = (TextBox)groupeInher.Controls["txtInherite"];
                    

                    SqlCommand com = new SqlCommand();
                    com.Connection = Connection.getConnection;
                    com.CommandText = "getInheriteList";
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@idRole", dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                    com.Parameters.Add("@roles", SqlDbType.VarChar, 255);
                    com.Parameters["@roles"].Direction = ParameterDirection.Output;
                    string list = "";
                    com.ExecuteNonQuery();
                    list = (string)com.Parameters["@roles"].Value;
                    txtInherite.Text = list;

                    Connection.closeConnection();
                    com = null;
                    // var addUser = (Control)userControl.Controls["tblLayoutAddUser"];

                    //show informations in modify role interface

                    //save role name and role id in program to use them later

                    Program.roleName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Program.idRole = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                    TextBox txtNom = (TextBox)groupeInher.Controls["txtNom"];
                txtNom.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                
                TextBox txtDescription = (TextBox)groupeInher.Controls["txtDescription"];
                txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                TextBox txtNbr = (TextBox)groupeInher.Controls["txtNbr"];
                txtNbr.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                TextBox txtCreator = (TextBox)groupeInher.Controls["txtCreator"];
                txtCreator.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();



                DateTimePicker dpCreation = (DateTimePicker)groupeInher.Controls["dpCreation"];
                dpCreation.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            }

            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
            }
        }
    }
}
