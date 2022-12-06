namespace user_authentication
{
    partial class FrmRemoveUser
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
            this.pnlRemoveUser = new System.Windows.Forms.Panel();
            this.lblRemoveUser = new System.Windows.Forms.Label();
            this.txbAdminPassword = new System.Windows.Forms.TextBox();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.cbxUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRemoveUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRemoveUser
            // 
            this.pnlRemoveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlRemoveUser.Controls.Add(this.label1);
            this.pnlRemoveUser.Controls.Add(this.cbxUsers);
            this.pnlRemoveUser.Controls.Add(this.btnRemoveUser);
            this.pnlRemoveUser.Controls.Add(this.lblRemoveUser);
            this.pnlRemoveUser.Controls.Add(this.lblAdminPassword);
            this.pnlRemoveUser.Controls.Add(this.txbAdminPassword);
            this.pnlRemoveUser.Location = new System.Drawing.Point(-1, -1);
            this.pnlRemoveUser.Name = "pnlRemoveUser";
            this.pnlRemoveUser.Size = new System.Drawing.Size(406, 319);
            this.pnlRemoveUser.TabIndex = 0;
            // 
            // lblRemoveUser
            // 
            this.lblRemoveUser.AutoSize = true;
            this.lblRemoveUser.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveUser.ForeColor = System.Drawing.Color.Black;
            this.lblRemoveUser.Location = new System.Drawing.Point(116, 26);
            this.lblRemoveUser.Name = "lblRemoveUser";
            this.lblRemoveUser.Size = new System.Drawing.Size(179, 32);
            this.lblRemoveUser.TabIndex = 2;
            this.lblRemoveUser.Text = "Remove User";
            // 
            // txbAdminPassword
            // 
            this.txbAdminPassword.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAdminPassword.Location = new System.Drawing.Point(74, 167);
            this.txbAdminPassword.Name = "txbAdminPassword";
            this.txbAdminPassword.Size = new System.Drawing.Size(257, 31);
            this.txbAdminPassword.TabIndex = 1;
            this.txbAdminPassword.UseSystemPasswordChar = true;
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdminPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAdminPassword.Location = new System.Drawing.Point(74, 145);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(135, 19);
            this.lblAdminPassword.TabIndex = 3;
            this.lblAdminPassword.Text = "ADMIN PASSWORD";
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveUser.FlatAppearance.BorderSize = 0;
            this.btnRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUser.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemoveUser.Location = new System.Drawing.Point(87, 221);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(230, 47);
            this.btnRemoveUser.TabIndex = 4;
            this.btnRemoveUser.Text = "REMOVE USER";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // cbxUsers
            // 
            this.cbxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsers.Font = new System.Drawing.Font("Consolas", 12F);
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.Items.AddRange(new object[] {
            ""});
            this.cbxUsers.Location = new System.Drawing.Point(74, 98);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(257, 27);
            this.cbxUsers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(74, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "SELECT USER";
            // 
            // FrmRemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 316);
            this.Controls.Add(this.pnlRemoveUser);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRemoveUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove User";
            this.Load += new System.EventHandler(this.FrmRemoveUser_Load);
            this.pnlRemoveUser.ResumeLayout(false);
            this.pnlRemoveUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRemoveUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Label lblRemoveUser;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.TextBox txbAdminPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxUsers;
    }
}