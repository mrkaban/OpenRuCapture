namespace SendToPlugins
{
    partial class CommonAuthDialog
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
            this.webBrowserAuth = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserAuth
            // 
            this.webBrowserAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserAuth.Location = new System.Drawing.Point(0, 0);
            this.webBrowserAuth.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserAuth.Name = "webBrowserAuth";
            this.webBrowserAuth.Size = new System.Drawing.Size(514, 443);
            this.webBrowserAuth.TabIndex = 0;
            this.webBrowserAuth.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserAuth_DocumentCompleted);
            this.webBrowserAuth.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowserAuth_Navigated);
            // 
            // CommonAuthDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 443);
            this.ControlBox = false;
            this.Controls.Add(this.webBrowserAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CommonAuthDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аутентификация";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CommonAuthDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserAuth;
    }
}