
namespace security_app
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            this.pnlSideLeft = new System.Windows.Forms.Panel();
            this.btnDesconnect = new FontAwesome.Sharp.IconButton();
            this.btnAboutUs = new FontAwesome.Sharp.IconButton();
            this.btnParam = new FontAwesome.Sharp.IconButton();
            this.btnPaiment = new FontAwesome.Sharp.IconButton();
            this.btnAvancement = new FontAwesome.Sharp.IconButton();
            this.btnEmploi = new FontAwesome.Sharp.IconButton();
            this.btnScolarite = new FontAwesome.Sharp.IconButton();
            this.btnExamen = new FontAwesome.Sharp.IconButton();
            this.btnEcole = new FontAwesome.Sharp.IconButton();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.pnlParam = new System.Windows.Forms.Panel();
            this.btnManagePreveliges = new FontAwesome.Sharp.IconButton();
            this.btnManageRoles = new FontAwesome.Sharp.IconButton();
            this.btnManageUsers = new FontAwesome.Sharp.IconButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlVide = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            this.pnlSideLeft.SuspendLayout();
            this.pnlParam.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(294, 100);
            label1.TabIndex = 0;
            label1.Text = "Securité App";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSideLeft
            // 
            this.pnlSideLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlSideLeft.Controls.Add(this.btnDesconnect);
            this.pnlSideLeft.Controls.Add(this.btnAboutUs);
            this.pnlSideLeft.Controls.Add(this.btnParam);
            this.pnlSideLeft.Controls.Add(this.btnPaiment);
            this.pnlSideLeft.Controls.Add(this.btnAvancement);
            this.pnlSideLeft.Controls.Add(this.btnEmploi);
            this.pnlSideLeft.Controls.Add(this.btnScolarite);
            this.pnlSideLeft.Controls.Add(this.btnExamen);
            this.pnlSideLeft.Controls.Add(this.btnEcole);
            this.pnlSideLeft.Controls.Add(this.btnProfile);
            this.pnlSideLeft.Controls.Add(label1);
            this.pnlSideLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSideLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlSideLeft.Name = "pnlSideLeft";
            this.pnlSideLeft.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlSideLeft.Size = new System.Drawing.Size(300, 702);
            this.pnlSideLeft.TabIndex = 0;
            // 
            // btnDesconnect
            // 
            this.btnDesconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDesconnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesconnect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDesconnect.FlatAppearance.BorderSize = 0;
            this.btnDesconnect.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnDesconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDesconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnDesconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconnect.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnDesconnect.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnDesconnect.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnDesconnect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDesconnect.IconSize = 35;
            this.btnDesconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesconnect.Location = new System.Drawing.Point(3, 595);
            this.btnDesconnect.Name = "btnDesconnect";
            this.btnDesconnect.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnDesconnect.Size = new System.Drawing.Size(294, 55);
            this.btnDesconnect.TabIndex = 33;
            this.btnDesconnect.Text = "Se déconnecter";
            this.btnDesconnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesconnect.UseVisualStyleBackColor = false;
            this.btnDesconnect.Click += new System.EventHandler(this.btnDeconnecter_Click_1);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnAboutUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutUs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnAboutUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAboutUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnAboutUs.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnAboutUs.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnAboutUs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAboutUs.IconSize = 35;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAboutUs.Location = new System.Drawing.Point(3, 540);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAboutUs.Size = new System.Drawing.Size(294, 55);
            this.btnAboutUs.TabIndex = 32;
            this.btnAboutUs.Text = "À Propos";
            this.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // btnParam
            // 
            this.btnParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParam.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnParam.FlatAppearance.BorderSize = 0;
            this.btnParam.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnParam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnParam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParam.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnParam.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnParam.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnParam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnParam.IconSize = 35;
            this.btnParam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParam.Location = new System.Drawing.Point(3, 485);
            this.btnParam.Name = "btnParam";
            this.btnParam.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnParam.Size = new System.Drawing.Size(294, 55);
            this.btnParam.TabIndex = 0;
            this.btnParam.Text = "Paramétres";
            this.btnParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParam.UseVisualStyleBackColor = false;
            this.btnParam.Visible = false;
            this.btnParam.Click += new System.EventHandler(this.btnParam_Click);
            // 
            // btnPaiment
            // 
            this.btnPaiment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnPaiment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaiment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPaiment.FlatAppearance.BorderSize = 0;
            this.btnPaiment.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnPaiment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPaiment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnPaiment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaiment.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnPaiment.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.btnPaiment.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnPaiment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPaiment.IconSize = 35;
            this.btnPaiment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaiment.Location = new System.Drawing.Point(3, 430);
            this.btnPaiment.Name = "btnPaiment";
            this.btnPaiment.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnPaiment.Size = new System.Drawing.Size(294, 55);
            this.btnPaiment.TabIndex = 30;
            this.btnPaiment.Text = "Paiment";
            this.btnPaiment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaiment.UseVisualStyleBackColor = false;
            this.btnPaiment.Visible = false;
            this.btnPaiment.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnAvancement
            // 
            this.btnAvancement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnAvancement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAvancement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAvancement.FlatAppearance.BorderSize = 0;
            this.btnAvancement.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnAvancement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAvancement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAvancement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancement.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnAvancement.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnAvancement.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnAvancement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAvancement.IconSize = 35;
            this.btnAvancement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAvancement.Location = new System.Drawing.Point(3, 375);
            this.btnAvancement.Name = "btnAvancement";
            this.btnAvancement.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAvancement.Size = new System.Drawing.Size(294, 55);
            this.btnAvancement.TabIndex = 29;
            this.btnAvancement.Text = "Avancement";
            this.btnAvancement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvancement.UseVisualStyleBackColor = false;
            this.btnAvancement.Visible = false;
            this.btnAvancement.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnEmploi
            // 
            this.btnEmploi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnEmploi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmploi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmploi.FlatAppearance.BorderSize = 0;
            this.btnEmploi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnEmploi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEmploi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnEmploi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploi.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnEmploi.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btnEmploi.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnEmploi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmploi.IconSize = 35;
            this.btnEmploi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmploi.Location = new System.Drawing.Point(3, 320);
            this.btnEmploi.Name = "btnEmploi";
            this.btnEmploi.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnEmploi.Size = new System.Drawing.Size(294, 55);
            this.btnEmploi.TabIndex = 28;
            this.btnEmploi.Text = "Emploi du Temps";
            this.btnEmploi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploi.UseVisualStyleBackColor = false;
            this.btnEmploi.Visible = false;
            this.btnEmploi.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnScolarite
            // 
            this.btnScolarite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnScolarite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScolarite.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnScolarite.FlatAppearance.BorderSize = 0;
            this.btnScolarite.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnScolarite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnScolarite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnScolarite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScolarite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScolarite.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnScolarite.IconChar = FontAwesome.Sharp.IconChar.University;
            this.btnScolarite.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnScolarite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnScolarite.IconSize = 35;
            this.btnScolarite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScolarite.Location = new System.Drawing.Point(3, 265);
            this.btnScolarite.Name = "btnScolarite";
            this.btnScolarite.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnScolarite.Size = new System.Drawing.Size(294, 55);
            this.btnScolarite.TabIndex = 27;
            this.btnScolarite.Text = "Scolarité";
            this.btnScolarite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScolarite.UseVisualStyleBackColor = false;
            this.btnScolarite.Visible = false;
            this.btnScolarite.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnExamen
            // 
            this.btnExamen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnExamen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExamen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExamen.FlatAppearance.BorderSize = 0;
            this.btnExamen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnExamen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExamen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamen.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnExamen.IconChar = FontAwesome.Sharp.IconChar.Vials;
            this.btnExamen.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnExamen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExamen.IconSize = 35;
            this.btnExamen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExamen.Location = new System.Drawing.Point(3, 210);
            this.btnExamen.Name = "btnExamen";
            this.btnExamen.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnExamen.Size = new System.Drawing.Size(294, 55);
            this.btnExamen.TabIndex = 31;
            this.btnExamen.Text = "Examen";
            this.btnExamen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExamen.UseVisualStyleBackColor = false;
            this.btnExamen.Visible = false;
            this.btnExamen.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // btnEcole
            // 
            this.btnEcole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnEcole.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEcole.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEcole.FlatAppearance.BorderSize = 0;
            this.btnEcole.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnEcole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEcole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnEcole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEcole.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnEcole.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnEcole.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnEcole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEcole.IconSize = 35;
            this.btnEcole.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEcole.Location = new System.Drawing.Point(3, 155);
            this.btnEcole.Name = "btnEcole";
            this.btnEcole.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnEcole.Size = new System.Drawing.Size(294, 55);
            this.btnEcole.TabIndex = 26;
            this.btnEcole.Text = "École";
            this.btnEcole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEcole.UseVisualStyleBackColor = false;
            this.btnEcole.Visible = false;
            this.btnEcole.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnProfile.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfile.IconSize = 35;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfile.Location = new System.Drawing.Point(3, 100);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(294, 55);
            this.btnProfile.TabIndex = 25;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // pnlParam
            // 
            this.pnlParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlParam.Controls.Add(this.btnManagePreveliges);
            this.pnlParam.Controls.Add(this.btnManageRoles);
            this.pnlParam.Controls.Add(this.btnManageUsers);
            this.pnlParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlParam.Location = new System.Drawing.Point(0, 0);
            this.pnlParam.Name = "pnlParam";
            this.pnlParam.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnlParam.Size = new System.Drawing.Size(870, 50);
            this.pnlParam.TabIndex = 1;
            // 
            // btnManagePreveliges
            // 
            this.btnManagePreveliges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnManagePreveliges.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnManagePreveliges.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnManagePreveliges.FlatAppearance.BorderSize = 0;
            this.btnManagePreveliges.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnManagePreveliges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnManagePreveliges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnManagePreveliges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagePreveliges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagePreveliges.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnManagePreveliges.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.btnManagePreveliges.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnManagePreveliges.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManagePreveliges.IconSize = 35;
            this.btnManagePreveliges.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManagePreveliges.Location = new System.Drawing.Point(488, 3);
            this.btnManagePreveliges.Name = "btnManagePreveliges";
            this.btnManagePreveliges.Size = new System.Drawing.Size(244, 44);
            this.btnManagePreveliges.TabIndex = 35;
            this.btnManagePreveliges.Text = "Gestion des Privilèges";
            this.btnManagePreveliges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagePreveliges.UseVisualStyleBackColor = false;
            this.btnManagePreveliges.Visible = false;
            this.btnManagePreveliges.Click += new System.EventHandler(this.iconButton8_Click_1);
            // 
            // btnManageRoles
            // 
            this.btnManageRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnManageRoles.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnManageRoles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnManageRoles.FlatAppearance.BorderSize = 0;
            this.btnManageRoles.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnManageRoles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnManageRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnManageRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRoles.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnManageRoles.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnManageRoles.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnManageRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageRoles.IconSize = 35;
            this.btnManageRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageRoles.Location = new System.Drawing.Point(244, 3);
            this.btnManageRoles.Name = "btnManageRoles";
            this.btnManageRoles.Size = new System.Drawing.Size(244, 44);
            this.btnManageRoles.TabIndex = 34;
            this.btnManageRoles.Text = "Gestion des roles";
            this.btnManageRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageRoles.UseVisualStyleBackColor = false;
            this.btnManageRoles.Visible = false;
            this.btnManageRoles.Click += new System.EventHandler(this.iconButton9_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnManageUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnManageUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnManageUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnManageUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnManageUsers.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnManageUsers.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnManageUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageUsers.IconSize = 35;
            this.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageUsers.Location = new System.Drawing.Point(0, 3);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(244, 44);
            this.btnManageUsers.TabIndex = 33;
            this.btnManageUsers.Text = "Gestion des utilisateurs";
            this.btnManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Visible = false;
            this.btnManageUsers.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(300, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(870, 652);
            this.panelContainer.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlTop.Controls.Add(this.pnlParam);
            this.pnlTop.Controls.Add(this.pnlVide);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(300, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(870, 50);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlVide
            // 
            this.pnlVide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVide.Location = new System.Drawing.Point(0, 0);
            this.pnlVide.Name = "pnlVide";
            this.pnlVide.Size = new System.Drawing.Size(870, 50);
            this.pnlVide.TabIndex = 2;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1170, 702);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSideLeft);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(1178, 647);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlSideLeft.ResumeLayout(false);
            this.pnlParam.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideLeft;
        private System.Windows.Forms.Panel pnlParam;
        private System.Windows.Forms.Panel panelContainer;
        private FontAwesome.Sharp.IconButton btnParam;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnAboutUs;
        private FontAwesome.Sharp.IconButton btnPaiment;
        private FontAwesome.Sharp.IconButton btnAvancement;
        private FontAwesome.Sharp.IconButton btnEmploi;
        private FontAwesome.Sharp.IconButton btnScolarite;
        private FontAwesome.Sharp.IconButton btnExamen;
        private FontAwesome.Sharp.IconButton btnEcole;
        private FontAwesome.Sharp.IconButton btnManageRoles;
        private FontAwesome.Sharp.IconButton btnManageUsers;
        private FontAwesome.Sharp.IconButton btnManagePreveliges;
        private FontAwesome.Sharp.IconButton btnDesconnect;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlVide;
    }
}