namespace OpenRuCapture.Capturemodes
{
    partial class frmOverlay
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
            if (_pen != null)
            {
                _pen.Dispose();
                _pen = null;
            }

            if (_freeformPath != null)
            {
                _freeformPath.Dispose();
                _freeformPath = null;
            }

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
            this.frRectangle = new OpenRuCapture.Capturemodes.FixedRegion();
            this.SuspendLayout();
            // 
            // frRectangle
            // 
            this.frRectangle.BackColor = System.Drawing.Color.SkyBlue;
            this.frRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frRectangle.Location = new System.Drawing.Point(29, 12);
            this.frRectangle.Name = "frRectangle";
            this.frRectangle.Size = new System.Drawing.Size(350, 250);
            this.frRectangle.TabIndex = 0;
            this.frRectangle.Text = "fixedRegion1";
            this.frRectangle.Visible = false;
            this.frRectangle.Paint += new System.Windows.Forms.PaintEventHandler(this.frRectangle_Paint);
            // 
            // frmOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 285);
            this.Controls.Add(this.frRectangle);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmOverlay";
            this.Opacity = 0.25D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmOverlay_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOverlay_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onMouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private FixedRegion frRectangle;

    }
}