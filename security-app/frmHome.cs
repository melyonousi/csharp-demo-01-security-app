using System;
using System.Drawing;
using FontAwesome.Sharp;
using System.Windows.Forms;

namespace security_app
{
    public partial class frmHome : Form
    {
        /// <summary>
        /// to change backColor of button click
        /// </summary>
        private IconButton currentButton;
        private Panel leftBorderButton;

        private IconButton currentButtonTop;
        private Panel topBorderButton;

        public static string login = "";

        static frmHome _obj;
        public static frmHome Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frmHome();
                }
                return _obj;
            }
        }
        public frmHome()
        {
            InitializeComponent();

            // initialize
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(10, 55);
            pnlSideLeft.Controls.Add(leftBorderButton);

            // initialize
            topBorderButton = new Panel();
            topBorderButton.Size = new Size(244, 10);
            pnlParam.Controls.Add(topBorderButton);
        }

        /// <summary>
        /// visile controls
        /// </summary>
        /// <param name="control"></param>
        private void visibleControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Button)
                {
                    if (User.controles.IndexOf(c.Name) != -1)
                    {
                        c.Visible = true;
                    }
                }
            }
        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                DisableButton();

                // button active
                currentButton = (IconButton)sender;
                currentButton.BackColor = Color.SteelBlue;
                currentButton.ForeColor = Color.White;
                currentButton.IconColor = Color.White;

                //left border
                leftBorderButton.BackColor = Color.White;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                // button active
                currentButton.BackColor = Color.FromArgb(31, 31, 31);
                currentButton.ForeColor = Color.LightSkyBlue;
                currentButton.IconColor = Color.LightSkyBlue;
                leftBorderButton.Visible = false;
            }
        }

        private void ActivateButtonTop(object sender)
        {
            if (sender != null)
            {
                DisableButtonTop();

                // button active
                currentButtonTop = (IconButton)sender;
                currentButtonTop.BackColor = Color.SteelBlue;
                currentButtonTop.ForeColor = Color.White;
                currentButtonTop.IconColor = Color.White;

                //left border
                topBorderButton.BackColor = Color.White;
                topBorderButton.Location = new Point(currentButtonTop.Location.X, 40);
                topBorderButton.Visible = true;
                topBorderButton.BringToFront();
            }
        }

        private void DisableButtonTop()
        {
            if (currentButtonTop != null)
            {
                // button active
                currentButtonTop.BackColor = Color.FromArgb(31, 31, 31);
                currentButtonTop.ForeColor = Color.LightSkyBlue;
                currentButtonTop.IconColor = Color.LightSkyBlue;
                topBorderButton.Visible = false;
            }
        }


        public frmHome(string login)
        {
            InitializeComponent();
            // this.login = login;
        }

        public Panel pnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        private void btnParam_Click(object sender, EventArgs e)
        {



            ActivateButton(sender);
            ActivateButtonTop(btnManageUsers);

            pnlParam.BringToFront();
            //bring user management panel to front
            _obj = this;

            for (int i = pnlParam.Controls.Count -1; i >= 0; i--)
            {
                if (pnlParam.Controls[i].Visible == true)
                {
                    ((Button)pnlParam.Controls[i]).PerformClick();
                    break;
                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            visibleControls(pnlSideLeft);
            visibleControls(pnlParam);

            _obj = this;
            HomePage u = new HomePage();
            u.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(u);
            panelContainer.Controls["ExampleControl"].BringToFront();

            pnlVide.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            DisableButtonTop();

            pnlVide.BringToFront();
            _obj = this;
            if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("UserProfile"))
            {
                UserProfile u = new UserProfile();
                u.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(u);
            }
            else
            {
                frmHome.Instance.pnlContainer.Controls.Clear();
                UserProfile u = new UserProfile();
                u.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(u);
            }
            panelContainer.Controls["UserProfile"].BringToFront();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ActivateButtonTop(sender);

            _obj = this;
            if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("UsersControl"))
            {
                UsersControl u = new UsersControl();
                u.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(u);
            }
            else
            {
                frmHome.Instance.pnlContainer.Controls.Clear();
                UsersControl u = new UsersControl();
                u.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(u);
            }

            panelContainer.Controls["UsersControl"].BringToFront();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            ActivateButtonTop(sender);

            //bring user management panel to front
            _obj = this;
            if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("RolesManagment"))
            {
                RolesManagment u = new RolesManagment();
                u.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(u);
            }

            panelContainer.Controls["RolesManagment"].BringToFront();
        }

        private void iconButton8_Click_1(object sender, EventArgs e)
        {
            ActivateButtonTop(sender);

            _obj = this;
            if (!frmHome.Instance.pnlContainer.Controls.ContainsKey("Preveliges"))
            {
                Preveliges u = new Preveliges();
                u.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(u);
            }
            else
            {
                frmHome.Instance.pnlContainer.Controls.Clear();
                Preveliges u = new Preveliges();
                u.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(u);
            }
            panelContainer.Controls["Preveliges"].BringToFront();
        }

        private void btnDeconnecter_Click_1(object sender, EventArgs e)
        {
            // set data user to class user
            User.preveliges.Clear();
            User.controles.Clear();
            User.login = null;
            User.nom = null;
            User.email = null;
            User.idRole = 0;
            this.Hide();
            this.Close();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
    }
}
