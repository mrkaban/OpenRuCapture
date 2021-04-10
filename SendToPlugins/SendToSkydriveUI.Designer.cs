namespace SendToPlugins
{
    partial class SendToSkydriveUI
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
            this.uploadProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uploadProgress
            // 
            this.uploadProgress.Location = new System.Drawing.Point(22, 74);
            this.uploadProgress.Name = "uploadProgress";
            this.uploadProgress.Size = new System.Drawing.Size(337, 23);
            this.uploadProgress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пожалуйста подождите...";
            // 
            // cmdSignIn
            // 
            this.cmdSignIn.Location = new System.Drawing.Point(131, 13);
            this.cmdSignIn.Name = "cmdSignIn";
            this.cmdSignIn.Size = new System.Drawing.Size(134, 23);
            this.cmdSignIn.TabIndex = 4;
            this.cmdSignIn.Text = "Вход в Skydrive";
            this.cmdSignIn.UseVisualStyleBackColor = true;
            this.cmdSignIn.Click += new System.EventHandler(this.cmdSignIn_Click);
            // 
            // SendToSkydriveUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 109);
            this.ControlBox = false;
            this.Controls.Add(this.cmdSignIn);
            this.Controls.Add(this.uploadProgress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "SendToSkydriveUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправить на Skydrive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar uploadProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSignIn;
    }
}