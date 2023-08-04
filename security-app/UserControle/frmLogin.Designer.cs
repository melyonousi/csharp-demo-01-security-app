namespace security_app
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDesplayPassword = new FontAwesome.Sharp.IconButton();
            this.lblError = new System.Windows.Forms.Label();
            this.ck_save_passwrd = new System.Windows.Forms.CheckBox();
            this.pc_logo = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pc_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom d\'Utilisateur :";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(30, 288);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(6);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(369, 32);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(30, 395);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(329, 32);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.UseSystemPasswordChar = true;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            this.txtPassWord.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtPassWord.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mos de passe :";
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(33, 543);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(366, 44);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Se connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(33, 599);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(366, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnDesplayPassword
            // 
            this.btnDesplayPassword.BackColor = System.Drawing.Color.White;
            this.btnDesplayPassword.FlatAppearance.BorderSize = 0;
            this.btnDesplayPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesplayPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesplayPassword.ForeColor = System.Drawing.Color.White;
            this.btnDesplayPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnDesplayPassword.IconColor = System.Drawing.Color.SteelBlue;
            this.btnDesplayPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDesplayPassword.IconSize = 30;
            this.btnDesplayPassword.Location = new System.Drawing.Point(358, 396);
            this.btnDesplayPassword.Name = "btnDesplayPassword";
            this.btnDesplayPassword.Size = new System.Drawing.Size(41, 30);
            this.btnDesplayPassword.TabIndex = 5;
            this.btnDesplayPassword.UseVisualStyleBackColor = false;
            this.btnDesplayPassword.Click += new System.EventHandler(this.btnDesplayPassword_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(30, 478);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(369, 33);
            this.lblError.TabIndex = 6;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ck_save_passwrd
            // 
            this.ck_save_passwrd.AutoSize = true;
            this.ck_save_passwrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_save_passwrd.ForeColor = System.Drawing.Color.White;
            this.ck_save_passwrd.Location = new System.Drawing.Point(30, 436);
            this.ck_save_passwrd.Name = "ck_save_passwrd";
            this.ck_save_passwrd.Size = new System.Drawing.Size(249, 24);
            this.ck_save_passwrd.TabIndex = 7;
            this.ck_save_passwrd.Text = "Enregistrer le mot de passe";
            this.ck_save_passwrd.UseVisualStyleBackColor = true;
            this.ck_save_passwrd.CheckedChanged += new System.EventHandler(this.ck_save_passwrd_CheckedChanged);
            // 
            // pc_logo
            // 
            this.pc_logo.BackColor = System.Drawing.Color.SteelBlue;
            this.pc_logo.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.pc_logo.IconColor = System.Drawing.Color.White;
            this.pc_logo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pc_logo.IconSize = 192;
            this.pc_logo.Location = new System.Drawing.Point(118, 20);
            this.pc_logo.Name = "pc_logo";
            this.pc_logo.Size = new System.Drawing.Size(192, 201);
            this.pc_logo.TabIndex = 8;
            this.pc_logo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(429, 663);
            this.Controls.Add(this.pc_logo);
            this.Controls.Add(this.ck_save_passwrd);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnDesplayPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Securité Application";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pc_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnExit;
        private FontAwesome.Sharp.IconButton btnDesplayPassword;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox ck_save_passwrd;
        private FontAwesome.Sharp.IconPictureBox pc_logo;
    }
}

