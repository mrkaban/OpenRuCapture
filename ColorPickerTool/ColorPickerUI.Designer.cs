namespace ColorPickerTool
{
    partial class ColorPickerUI
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
            this.picColorChooser = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.txtRgb = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picColorChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // picColorChooser
            // 
            this.picColorChooser.Image = global::ColorPickerTool.Properties.Resources.color_picker;
            this.picColorChooser.Location = new System.Drawing.Point(13, 16);
            this.picColorChooser.Name = "picColorChooser";
            this.picColorChooser.Size = new System.Drawing.Size(40, 40);
            this.picColorChooser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picColorChooser.TabIndex = 0;
            this.picColorChooser.TabStop = false;
            this.picColorChooser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picColorChooser_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цвет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RGB :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hex :";
            // 
            // picPreview
            // 
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(13, 76);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(75, 75);
            this.picPreview.TabIndex = 2;
            this.picPreview.TabStop = false;
            // 
            // txtRgb
            // 
            this.txtRgb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRgb.Location = new System.Drawing.Point(100, 90);
            this.txtRgb.Name = "txtRgb";
            this.txtRgb.ReadOnly = true;
            this.txtRgb.Size = new System.Drawing.Size(100, 20);
            this.txtRgb.TabIndex = 3;
            this.txtRgb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHex
            // 
            this.txtHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHex.Location = new System.Drawing.Point(100, 129);
            this.txtHex.Name = "txtHex";
            this.txtHex.ReadOnly = true;
            this.txtHex.Size = new System.Drawing.Size(100, 20);
            this.txtHex.TabIndex = 3;
            this.txtHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(59, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Перенесите пипетку для начала использования.";
            // 
            // cmdCopy
            // 
            this.cmdCopy.Location = new System.Drawing.Point(100, 43);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(100, 23);
            this.cmdCopy.TabIndex = 5;
            this.cmdCopy.Text = "&Копировать";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // ColorPickerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 161);
            this.Controls.Add(this.cmdCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.txtRgb);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picColorChooser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorPickerUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Выбор цвета";
            ((System.ComponentModel.ISupportInitialize)(this.picColorChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picColorChooser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.TextBox txtRgb;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdCopy;
    }
}