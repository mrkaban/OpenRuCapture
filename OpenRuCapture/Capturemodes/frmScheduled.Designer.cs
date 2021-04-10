namespace OpenRuCapture.Capturemodes
{
    partial class frmScheduled
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
            this.ddlWindows = new System.Windows.Forms.ComboBox();
            this.rbWindow = new System.Windows.Forms.RadioButton();
            this.rbActiveWindow = new System.Windows.Forms.RadioButton();
            this.rbFullScreen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numScheduleTime = new System.Windows.Forms.NumericUpDown();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numScheduleTime)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddlWindows
            // 
            this.ddlWindows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlWindows.Enabled = false;
            this.ddlWindows.FormattingEnabled = true;
            this.ddlWindows.Location = new System.Drawing.Point(134, 112);
            this.ddlWindows.Name = "ddlWindows";
            this.ddlWindows.Size = new System.Drawing.Size(233, 21);
            this.ddlWindows.TabIndex = 14;
            // 
            // rbWindow
            // 
            this.rbWindow.AutoSize = true;
            this.rbWindow.Location = new System.Drawing.Point(174, 89);
            this.rbWindow.Name = "rbWindow";
            this.rbWindow.Size = new System.Drawing.Size(51, 17);
            this.rbWindow.TabIndex = 13;
            this.rbWindow.Tag = "OpenRuCapture.Capturemodes.WindowCaptureHelper";
            this.rbWindow.Text = "&Окно";
            this.rbWindow.UseVisualStyleBackColor = true;
            this.rbWindow.CheckedChanged += new System.EventHandler(this.rbWindow_CheckedChanged);
            // 
            // rbActiveWindow
            // 
            this.rbActiveWindow.AutoSize = true;
            this.rbActiveWindow.Location = new System.Drawing.Point(174, 59);
            this.rbActiveWindow.Name = "rbActiveWindow";
            this.rbActiveWindow.Size = new System.Drawing.Size(100, 17);
            this.rbActiveWindow.TabIndex = 12;
            this.rbActiveWindow.Tag = "OpenRuCapture.Capturemodes.ActiveWindowCapture";
            this.rbActiveWindow.Text = "&Активное окно";
            this.rbActiveWindow.UseVisualStyleBackColor = true;
            // 
            // rbFullScreen
            // 
            this.rbFullScreen.AutoSize = true;
            this.rbFullScreen.Checked = true;
            this.rbFullScreen.Location = new System.Drawing.Point(174, 36);
            this.rbFullScreen.Name = "rbFullScreen";
            this.rbFullScreen.Size = new System.Drawing.Size(98, 17);
            this.rbFullScreen.TabIndex = 11;
            this.rbFullScreen.TabStop = true;
            this.rbFullScreen.Tag = "OpenRuCapture.Capturemodes.FullScreenCapture";
            this.rbFullScreen.Text = "&Полный экран";
            this.rbFullScreen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Запланировать захват после:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "секунд";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Доступные окна:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Режим захвата:";
            // 
            // numScheduleTime
            // 
            this.numScheduleTime.Location = new System.Drawing.Point(174, 10);
            this.numScheduleTime.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numScheduleTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numScheduleTime.Name = "numScheduleTime";
            this.numScheduleTime.Size = new System.Drawing.Size(53, 20);
            this.numScheduleTime.TabIndex = 6;
            this.numScheduleTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(294, 160);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 16;
            this.cmdCancel.Text = "&Отмена";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOk.Location = new System.Drawing.Point(213, 160);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 15;
            this.cmdOk.Text = "Ок";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ddlWindows);
            this.panel1.Controls.Add(this.rbWindow);
            this.panel1.Controls.Add(this.rbActiveWindow);
            this.panel1.Controls.Add(this.rbFullScreen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numScheduleTime);
            this.panel1.Location = new System.Drawing.Point(2, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 147);
            this.panel1.TabIndex = 17;
            // 
            // frmScheduled
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(387, 190);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScheduled";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запланированный захват экрана";
            this.Load += new System.EventHandler(this.frmScheduled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numScheduleTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlWindows;
        private System.Windows.Forms.RadioButton rbWindow;
        private System.Windows.Forms.RadioButton rbActiveWindow;
        private System.Windows.Forms.RadioButton rbFullScreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numScheduleTime;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Panel panel1;
    }
}