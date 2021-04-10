namespace SendToPlugins
{
    partial class SendToFacebookUI
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
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmdUpload = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.progressUpload = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сообщение";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(16, 30);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(350, 117);
            this.txtComment.TabIndex = 1;
            this.txtComment.Text = "Загружено через OpenRuCapture";
            // 
            // cmdUpload
            // 
            this.cmdUpload.Location = new System.Drawing.Point(16, 154);
            this.cmdUpload.Name = "cmdUpload";
            this.cmdUpload.Size = new System.Drawing.Size(75, 23);
            this.cmdUpload.TabIndex = 2;
            this.cmdUpload.Text = "Загрузить";
            this.cmdUpload.UseVisualStyleBackColor = true;
            this.cmdUpload.Click += new System.EventHandler(this.cmdUpload_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(98, 154);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 3;
            this.cmdClose.Text = "Закрыть";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(384, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(187, 160);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 4;
            this.picPreview.TabStop = false;
            // 
            // progressUpload
            // 
            this.progressUpload.Location = new System.Drawing.Point(180, 154);
            this.progressUpload.Name = "progressUpload";
            this.progressUpload.Size = new System.Drawing.Size(186, 23);
            this.progressUpload.TabIndex = 5;
            this.progressUpload.Visible = false;
            // 
            // SendToFacebookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 185);
            this.ControlBox = false;
            this.Controls.Add(this.progressUpload);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdUpload);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SendToFacebookUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправить в Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button cmdUpload;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.ProgressBar progressUpload;
    }
}