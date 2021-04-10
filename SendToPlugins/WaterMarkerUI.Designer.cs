namespace SendToPlugins
{
    partial class WaterMarkerUI
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
            this.picWaterMarkPreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdSelectColor = new System.Windows.Forms.Button();
            this.cmdSelectFont = new System.Windows.Forms.Button();
            this.hsAlpha = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWatermarkText = new System.Windows.Forms.TextBox();
            this.ddlAlignment = new System.Windows.Forms.ComboBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWaterMarkPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // picWaterMarkPreview
            // 
            this.picWaterMarkPreview.Location = new System.Drawing.Point(12, 33);
            this.picWaterMarkPreview.Name = "picWaterMarkPreview";
            this.picWaterMarkPreview.Size = new System.Drawing.Size(275, 275);
            this.picWaterMarkPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWaterMarkPreview.TabIndex = 0;
            this.picWaterMarkPreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предварительный просмотр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цвет:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Шрифт:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Выравнивание текста:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Альфа:";
            // 
            // cmdSelectColor
            // 
            this.cmdSelectColor.Location = new System.Drawing.Point(376, 67);
            this.cmdSelectColor.Name = "cmdSelectColor";
            this.cmdSelectColor.Size = new System.Drawing.Size(164, 23);
            this.cmdSelectColor.TabIndex = 1;
            this.cmdSelectColor.Text = "&Цвет";
            this.cmdSelectColor.UseVisualStyleBackColor = true;
            this.cmdSelectColor.Click += new System.EventHandler(this.cmdSelectColor_Click);
            // 
            // cmdSelectFont
            // 
            this.cmdSelectFont.Location = new System.Drawing.Point(376, 97);
            this.cmdSelectFont.Name = "cmdSelectFont";
            this.cmdSelectFont.Size = new System.Drawing.Size(164, 23);
            this.cmdSelectFont.TabIndex = 2;
            this.cmdSelectFont.Text = "&Шрифт";
            this.cmdSelectFont.UseVisualStyleBackColor = true;
            this.cmdSelectFont.Click += new System.EventHandler(this.cmdSelectFont_Click);
            // 
            // hsAlpha
            // 
            this.hsAlpha.Location = new System.Drawing.Point(376, 134);
            this.hsAlpha.Maximum = 200;
            this.hsAlpha.Name = "hsAlpha";
            this.hsAlpha.Size = new System.Drawing.Size(164, 17);
            this.hsAlpha.TabIndex = 3;
            this.hsAlpha.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsAlpha_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Текст:";
            // 
            // txtWatermarkText
            // 
            this.txtWatermarkText.Location = new System.Drawing.Point(376, 36);
            this.txtWatermarkText.Name = "txtWatermarkText";
            this.txtWatermarkText.Size = new System.Drawing.Size(164, 20);
            this.txtWatermarkText.TabIndex = 0;
            this.txtWatermarkText.Text = "OpenRuCapture";
            this.txtWatermarkText.TextChanged += new System.EventHandler(this.txtWatermarkText_TextChanged);
            // 
            // ddlAlignment
            // 
            this.ddlAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAlignment.FormattingEnabled = true;
            this.ddlAlignment.Location = new System.Drawing.Point(376, 183);
            this.ddlAlignment.Name = "ddlAlignment";
            this.ddlAlignment.Size = new System.Drawing.Size(164, 21);
            this.ddlAlignment.TabIndex = 4;
            this.ddlAlignment.SelectedIndexChanged += new System.EventHandler(this.ddlAlignment_SelectedIndexChanged);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(465, 222);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Text = "&Закрыть";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdApply
            // 
            this.cmdApply.Location = new System.Drawing.Point(376, 222);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(75, 23);
            this.cmdApply.TabIndex = 5;
            this.cmdApply.Text = "&Применить";
            this.cmdApply.UseVisualStyleBackColor = true;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // WaterMarkerUI
            // 
            this.AcceptButton = this.cmdApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(557, 324);
            this.Controls.Add(this.cmdApply);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.ddlAlignment);
            this.Controls.Add(this.txtWatermarkText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hsAlpha);
            this.Controls.Add(this.cmdSelectFont);
            this.Controls.Add(this.cmdSelectColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picWaterMarkPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "WaterMarkerUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ВодяныеЗнаки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WaterMarkerUI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picWaterMarkPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWaterMarkPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdSelectColor;
        private System.Windows.Forms.Button cmdSelectFont;
        private System.Windows.Forms.HScrollBar hsAlpha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWatermarkText;
        private System.Windows.Forms.ComboBox ddlAlignment;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdApply;



    }
}