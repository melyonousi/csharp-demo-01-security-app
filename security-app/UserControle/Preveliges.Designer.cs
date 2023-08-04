namespace security_app
{
    partial class Preveliges
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.lstLeft = new System.Windows.Forms.ListBox();
            this.lstRight = new System.Windows.Forms.ListBox();
            this.btnAllLeftRight = new System.Windows.Forms.Button();
            this.btnAllRightLeft = new System.Windows.Forms.Button();
            this.btnOneLeftRight = new System.Windows.Forms.Button();
            this.btnOneRightLeft = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRoles
            // 
            this.cbRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbRoles, 2);
            this.cbRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(374, 59);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(412, 28);
            this.cbRoles.TabIndex = 1;
            this.cbRoles.SelectedIndexChanged += new System.EventHandler(this.cbRoles_SelectedIndexChanged);
            this.cbRoles.SelectedValueChanged += new System.EventHandler(this.cbRoles_SelectedValueChanged);
            // 
            // lstLeft
            // 
            this.lstLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLeft.FormattingEnabled = true;
            this.lstLeft.ItemHeight = 20;
            this.lstLeft.Location = new System.Drawing.Point(142, 138);
            this.lstLeft.Name = "lstLeft";
            this.tableLayoutPanel1.SetRowSpan(this.lstLeft, 4);
            this.lstLeft.Size = new System.Drawing.Size(226, 314);
            this.lstLeft.TabIndex = 4;
            // 
            // lstRight
            // 
            this.lstRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRight.FormattingEnabled = true;
            this.lstRight.ItemHeight = 20;
            this.lstRight.Location = new System.Drawing.Point(560, 138);
            this.lstRight.Name = "lstRight";
            this.tableLayoutPanel1.SetRowSpan(this.lstRight, 4);
            this.lstRight.Size = new System.Drawing.Size(226, 314);
            this.lstRight.TabIndex = 5;
            // 
            // btnAllLeftRight
            // 
            this.btnAllLeftRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAllLeftRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnAllLeftRight.FlatAppearance.BorderSize = 0;
            this.btnAllLeftRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAllLeftRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAllLeftRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllLeftRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllLeftRight.ForeColor = System.Drawing.Color.White;
            this.btnAllLeftRight.Location = new System.Drawing.Point(374, 397);
            this.btnAllLeftRight.Name = "btnAllLeftRight";
            this.btnAllLeftRight.Size = new System.Drawing.Size(180, 35);
            this.btnAllLeftRight.TabIndex = 6;
            this.btnAllLeftRight.Text = ">>";
            this.btnAllLeftRight.UseVisualStyleBackColor = false;
            this.btnAllLeftRight.Click += new System.EventHandler(this.btnAllLeftRight_Click);
            // 
            // btnAllRightLeft
            // 
            this.btnAllRightLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAllRightLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnAllRightLeft.FlatAppearance.BorderSize = 0;
            this.btnAllRightLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAllRightLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAllRightLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllRightLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllRightLeft.ForeColor = System.Drawing.Color.White;
            this.btnAllRightLeft.Location = new System.Drawing.Point(374, 157);
            this.btnAllRightLeft.Name = "btnAllRightLeft";
            this.btnAllRightLeft.Size = new System.Drawing.Size(180, 35);
            this.btnAllRightLeft.TabIndex = 7;
            this.btnAllRightLeft.Text = "<<";
            this.btnAllRightLeft.UseVisualStyleBackColor = false;
            this.btnAllRightLeft.Click += new System.EventHandler(this.btnAllRightLeft_Click);
            // 
            // btnOneLeftRight
            // 
            this.btnOneLeftRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOneLeftRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnOneLeftRight.FlatAppearance.BorderSize = 0;
            this.btnOneLeftRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnOneLeftRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOneLeftRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneLeftRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneLeftRight.ForeColor = System.Drawing.Color.White;
            this.btnOneLeftRight.Location = new System.Drawing.Point(374, 317);
            this.btnOneLeftRight.Name = "btnOneLeftRight";
            this.btnOneLeftRight.Size = new System.Drawing.Size(180, 35);
            this.btnOneLeftRight.TabIndex = 8;
            this.btnOneLeftRight.Text = ">";
            this.btnOneLeftRight.UseVisualStyleBackColor = false;
            this.btnOneLeftRight.Click += new System.EventHandler(this.btnOneLeftRight_Click);
            // 
            // btnOneRightLeft
            // 
            this.btnOneRightLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOneRightLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnOneRightLeft.FlatAppearance.BorderSize = 0;
            this.btnOneRightLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnOneRightLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOneRightLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneRightLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneRightLeft.ForeColor = System.Drawing.Color.White;
            this.btnOneRightLeft.Location = new System.Drawing.Point(374, 237);
            this.btnOneRightLeft.Name = "btnOneRightLeft";
            this.btnOneRightLeft.Size = new System.Drawing.Size(180, 35);
            this.btnOneRightLeft.TabIndex = 9;
            this.btnOneRightLeft.Text = "<";
            this.btnOneRightLeft.UseVisualStyleBackColor = false;
            this.btnOneRightLeft.Click += new System.EventHandler(this.btnOneRightLeft_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.btnAllLeftRight, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnOneLeftRight, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnOneRightLeft, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAllRightLeft, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lstRight, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lstLeft, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbRoles, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.964413F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.3879F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.803738F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25234F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25234F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25234F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25234F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.69159F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 562);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Privilèges inclus :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sélectionnez un role :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(560, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Privilèges Exclus :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Preveliges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Preveliges";
            this.Size = new System.Drawing.Size(930, 562);
            this.Load += new System.EventHandler(this.Preveliges_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.ListBox lstLeft;
        private System.Windows.Forms.ListBox lstRight;
        private System.Windows.Forms.Button btnAllLeftRight;
        private System.Windows.Forms.Button btnAllRightLeft;
        private System.Windows.Forms.Button btnOneLeftRight;
        private System.Windows.Forms.Button btnOneRightLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
