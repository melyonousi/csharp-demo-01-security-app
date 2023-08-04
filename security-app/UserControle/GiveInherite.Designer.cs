namespace security_app
{
    partial class GiveInherite
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.btnAllPer = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtRols = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inherite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblGiveInherite = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtRols)).BeginInit();
            this.tblGiveInherite.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de role : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoleName.Enabled = false;
            this.txtRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleName.Location = new System.Drawing.Point(377, 72);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(183, 26);
            this.txtRoleName.TabIndex = 1;
            this.txtRoleName.TextChanged += new System.EventHandler(this.txtRoleName_TextChanged);
            // 
            // btnAllPer
            // 
            this.btnAllPer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAllPer.BackColor = System.Drawing.Color.White;
            this.btnAllPer.FlatAppearance.BorderSize = 0;
            this.btnAllPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllPer.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAllPer.Location = new System.Drawing.Point(566, 70);
            this.btnAllPer.Name = "btnAllPer";
            this.btnAllPer.Size = new System.Drawing.Size(234, 31);
            this.btnAllPer.TabIndex = 6;
            this.btnAllPer.Text = "hériter tous";
            this.btnAllPer.UseVisualStyleBackColor = false;
            this.btnAllPer.Click += new System.EventHandler(this.btnAllPer_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(566, 437);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(234, 31);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Enregistrer";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(157, 437);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(214, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtRols
            // 
            this.dtRols.AllowUserToAddRows = false;
            this.dtRols.AllowUserToDeleteRows = false;
            this.dtRols.AllowUserToResizeColumns = false;
            this.dtRols.AllowUserToResizeRows = false;
            this.dtRols.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtRols.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtRols.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtRols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRols.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Role,
            this.Inherite});
            this.tblGiveInherite.SetColumnSpan(this.dtRols, 3);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtRols.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtRols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtRols.Location = new System.Drawing.Point(157, 123);
            this.dtRols.Name = "dtRols";
            this.dtRols.RowHeadersVisible = false;
            this.dtRols.RowHeadersWidth = 45;
            this.dtRols.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.dtRols.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRols.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtRols.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dtRols.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dtRols.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.SteelBlue;
            this.dtRols.RowTemplate.Height = 35;
            this.dtRols.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtRols.Size = new System.Drawing.Size(643, 239);
            this.dtRols.TabIndex = 9;
            // 
            // id
            // 
            this.id.FillWeight = 96.06347F;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Role
            // 
            this.Role.FillWeight = 103.9365F;
            this.Role.HeaderText = "Nom de role";
            this.Role.Name = "Role";
            // 
            // Inherite
            // 
            this.Inherite.HeaderText = "Hériter";
            this.Inherite.Name = "Inherite";
            // 
            // tblGiveInherite
            // 
            this.tblGiveInherite.ColumnCount = 5;
            this.tblGiveInherite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.35021F));
            this.tblGiveInherite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.31224F));
            this.tblGiveInherite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblGiveInherite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.42194F));
            this.tblGiveInherite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.18987F));
            this.tblGiveInherite.Controls.Add(this.btnConfirm, 3, 3);
            this.tblGiveInherite.Controls.Add(this.btnCancel, 1, 3);
            this.tblGiveInherite.Controls.Add(this.dtRols, 1, 2);
            this.tblGiveInherite.Controls.Add(this.txtRoleName, 2, 1);
            this.tblGiveInherite.Controls.Add(this.btnAllPer, 3, 1);
            this.tblGiveInherite.Controls.Add(this.label1, 1, 1);
            this.tblGiveInherite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGiveInherite.Location = new System.Drawing.Point(0, 0);
            this.tblGiveInherite.Name = "tblGiveInherite";
            this.tblGiveInherite.RowCount = 4;
            this.tblGiveInherite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.607194F));
            this.tblGiveInherite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.93579F));
            this.tblGiveInherite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.43304F));
            this.tblGiveInherite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.02398F));
            this.tblGiveInherite.Size = new System.Drawing.Size(948, 541);
            this.tblGiveInherite.TabIndex = 10;
            // 
            // GiveInherite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblGiveInherite);
            this.Name = "GiveInherite";
            this.Size = new System.Drawing.Size(948, 541);
            this.Load += new System.EventHandler(this.GiveInherite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRols)).EndInit();
            this.tblGiveInherite.ResumeLayout(false);
            this.tblGiveInherite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Button btnAllPer;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dtRols;
        private System.Windows.Forms.TableLayoutPanel tblGiveInherite;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Inherite;
    }
}
