using System;
using System.IO.IsolatedStorage;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace security_app
{
    public partial class frmActivateKey : Form
    {
        public frmActivateKey()
        {
            InitializeComponent();
        }

        /*mouvement form*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
        int wparam, int lparam);

        /// <summary>
        /// movment the form on mouse down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_activate_key_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); /*function*/
            SendMessage(this.Handle, 0x112, 0xf012, 0);  /*function*/
        }

        /// <summary>
        /// this method to check string from file is activate or not
        /// </summary>
        private void check_load()
        {
            using (var isolated = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
            {
                try
                {
                    using (var stream = new IsolatedStorageFileStream("setting.txt", System.IO.FileMode.OpenOrCreate, isolated))
                    {
                        using (var sr = new System.IO.StreamReader(stream))
                        {
                            var activated = Activation.is_activate(sr.ReadLine());

                            if (activated)
                            {
                                // go to activate form
                                frmLogin frm = new frmLogin();
                                this.Hide();
                                frm.ShowDialog();
                                Environment.Exit(0);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lbl_error.Text = Activation.message;
                    LogFile.Message(ex);
                }
            }
        }

        /// <summary>
        /// on load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_activate_key_Load(object sender, EventArgs e)
        {
            check_load();
        }

        private void btn_activate_Click(object sender, EventArgs e)
        {
            // make a key from textbox
            string key_activate = $"{txt_1.Text}-{txt_2.Text}-{txt_3.Text}-{txt_4.Text}";
            // send key to class activation to verify
            Activation.activate_software(key_activate);

            lbl_error.Text = Activation.message;
            check_load();
        }

        /// <summary>
        /// verified field text if empty or space
        /// </summary>
        /// <returns></returns>
        private bool if_null()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    if (String.IsNullOrEmpty(((TextBox)c).Text) && String.IsNullOrWhiteSpace(((TextBox)c).Text))
                        return false;
                    if (((TextBox)c).TextLength < 5)
                        return false;
                }
            }
            return true;
        }

        /// <summary>
        /// enable or disable button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_1_TextChanged(object sender, EventArgs e)
        {
            btn_activate.Enabled = if_null() ? true : false;
        }

        /// <summary>
        /// button connect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_connect_Click(object sender, EventArgs e)
        {
            check_load();
        }

        /// <summary>
        /// button cancel to exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tn_cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
