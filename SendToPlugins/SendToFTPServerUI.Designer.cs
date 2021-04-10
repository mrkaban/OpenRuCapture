namespace SendToPlugins
{
    partial class SendToFTPServerUI
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
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdConnectAndUpload = new System.Windows.Forms.Button();
            this.chkAnonymous = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сервер:";
            // 
            // txtServer
            // 
            this.txtServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txtServer.Location = new System.Drawing.Point(78, 10);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(343, 20);
            this.txtServer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Логин:";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(78, 68);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(343, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Пароль:";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(78, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(343, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cmdClose
            // 
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Location = new System.Drawing.Point(345, 139);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "&Закрыть";
            this.cmdClose.UseVisualStyleBackColor = true;
            // 
            // cmdConnectAndUpload
            // 
            this.cmdConnectAndUpload.Location = new System.Drawing.Point(173, 139);
            this.cmdConnectAndUpload.Name = "cmdConnectAndUpload";
            this.cmdConnectAndUpload.Size = new System.Drawing.Size(166, 23);
            this.cmdConnectAndUpload.TabIndex = 4;
            this.cmdConnectAndUpload.Text = "&Подключиться и загрузить";
            this.cmdConnectAndUpload.UseVisualStyleBackColor = true;
            this.cmdConnectAndUpload.Click += new System.EventHandler(this.cmdConnectAndUpload_Click);
            // 
            // chkAnonymous
            // 
            this.chkAnonymous.AutoSize = true;
            this.chkAnonymous.Checked = true;
            this.chkAnonymous.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnonymous.Location = new System.Drawing.Point(78, 37);
            this.chkAnonymous.Name = "chkAnonymous";
            this.chkAnonymous.Size = new System.Drawing.Size(117, 17);
            this.chkAnonymous.TabIndex = 1;
            this.chkAnonymous.Text = "Анонимный вход?";
            this.chkAnonymous.UseVisualStyleBackColor = true;
            this.chkAnonymous.CheckedChanged += new System.EventHandler(this.chkAnonymous_CheckedChanged);
            // 
            // SendToFTPServerUI
            // 
            this.AcceptButton = this.cmdConnectAndUpload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdClose;
            this.ClientSize = new System.Drawing.Size(434, 173);
            this.ControlBox = false;
            this.Controls.Add(this.chkAnonymous);
            this.Controls.Add(this.cmdConnectAndUpload);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendToFTPServerUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправить на FTP Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdConnectAndUpload;
        private System.Windows.Forms.CheckBox chkAnonymous;
    }
}