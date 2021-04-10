namespace OpenRuCapture.Capturemodes
{
    partial class frmWindowCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWindowCapture));
            this.label1 = new System.Windows.Forms.Label();
            this.picFinder = new System.Windows.Forms.PictureBox();
            this.lblWindowName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFinder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перетащите инструмент Finder в окно, \r\nчтобы выбрать его, \r\nзатем отпустите кнопк" +
    "у мыши.";
            // 
            // picFinder
            // 
            this.picFinder.Image = ((System.Drawing.Image)(resources.GetObject("picFinder.Image")));
            this.picFinder.Location = new System.Drawing.Point(13, 56);
            this.picFinder.Name = "picFinder";
            this.picFinder.Size = new System.Drawing.Size(24, 24);
            this.picFinder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFinder.TabIndex = 1;
            this.picFinder.TabStop = false;
            this.picFinder.Click += new System.EventHandler(this.picFinder_Click_1);
            this.picFinder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picFinder_MouseDown);
            // 
            // lblWindowName
            // 
            this.lblWindowName.AutoEllipsis = true;
            this.lblWindowName.Location = new System.Drawing.Point(71, 57);
            this.lblWindowName.Name = "lblWindowName";
            this.lblWindowName.Size = new System.Drawing.Size(212, 23);
            this.lblWindowName.TabIndex = 2;
            // 
            // frmWindowCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 97);
            this.Controls.Add(this.lblWindowName);
            this.Controls.Add(this.picFinder);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWindowCapture";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Захват окна";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmWindowCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFinder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picFinder;
        private System.Windows.Forms.Label lblWindowName;
    }
}