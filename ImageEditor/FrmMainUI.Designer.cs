namespace ImageEditor
{
    partial class FrmMainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainUI));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendToMailMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highlighterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectMenuToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawingTools = new System.Windows.Forms.ToolStrip();
            this.OpenImageButton = new System.Windows.Forms.ToolStripButton();
            this.SaveImageButton = new System.Windows.Forms.ToolStripButton();
            this.CopyImageButton = new System.Windows.Forms.ToolStripButton();
            this.SendImageButton = new System.Windows.Forms.ToolStripButton();
            this.Sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.DefaultButton = new System.Windows.Forms.ToolStripButton();
            this.PenButton = new System.Windows.Forms.ToolStripButton();
            this.HighlighterButton = new System.Windows.Forms.ToolStripButton();
            this.EraserButton = new System.Windows.Forms.ToolStripButton();
            this.TextButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.DrawingTools.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(796, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(342, 17);
            this.toolStripStatusLabel1.Text = "Добро пожаловать в OpenRuCapture - Редактор скриншотов";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sendToMailMenuItem6,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpening);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.openFileToolStripMenuItem.Text = "&Открыть изображение...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(247, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.saveToolStripMenuItem.Text = "&Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.saveAsToolStripMenuItem.Text = "&Сохранить как...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(247, 6);
            // 
            // sendToMailMenuItem6
            // 
            this.sendToMailMenuItem6.Name = "sendToMailMenuItem6";
            this.sendToMailMenuItem6.Size = new System.Drawing.Size(250, 22);
            this.sendToMailMenuItem6.Text = "Отправить в &получатель почты";
            this.sendToMailMenuItem6.Click += new System.EventHandler(this.sendToMailMenuItem6_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(247, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.exitToolStripMenuItem.Text = "&Выход...";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(108, 20);
            this.toolStripMenuItem5.Text = "&Редактирование";
            this.toolStripMenuItem5.DropDownOpening += new System.EventHandler(this.toolStripMenuItem5_DropDownOpening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.copyToolStripMenuItem.Text = "&Копировать";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penToolStripMenuItem,
            this.highlighterToolStripMenuItem,
            this.eraserToolStripMenuItem,
            this.TextToolStripMenuItem,
            this.SelectMenuToolStripItem,
            this.toolStripMenuItem3,
            this.changeColorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.toolsToolStripMenuItem.Text = "&Инструменты";
            this.toolsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.toolsToolStripMenuItem_DropDownOpening);
            // 
            // penToolStripMenuItem
            // 
            this.penToolStripMenuItem.Checked = true;
            this.penToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.penToolStripMenuItem.Name = "penToolStripMenuItem";
            this.penToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.penToolStripMenuItem.Text = "&Ручка";
            this.penToolStripMenuItem.Click += new System.EventHandler(this.penToolStripMenuItem_Click);
            // 
            // highlighterToolStripMenuItem
            // 
            this.highlighterToolStripMenuItem.Name = "highlighterToolStripMenuItem";
            this.highlighterToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.highlighterToolStripMenuItem.Text = "&Маркер";
            this.highlighterToolStripMenuItem.Click += new System.EventHandler(this.highlighterToolStripMenuItem_Click);
            // 
            // eraserToolStripMenuItem
            // 
            this.eraserToolStripMenuItem.Name = "eraserToolStripMenuItem";
            this.eraserToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.eraserToolStripMenuItem.Text = "&Ластик";
            this.eraserToolStripMenuItem.Click += new System.EventHandler(this.eraserToolStripMenuItem_Click);
            // 
            // TextToolStripMenuItem
            // 
            this.TextToolStripMenuItem.Name = "TextToolStripMenuItem";
            this.TextToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.TextToolStripMenuItem.Text = "&Текст";
            this.TextToolStripMenuItem.Click += new System.EventHandler(this.TextToolStripMenuItem_Click);
            // 
            // SelectMenuToolStripItem
            // 
            this.SelectMenuToolStripItem.Name = "SelectMenuToolStripItem";
            this.SelectMenuToolStripItem.Size = new System.Drawing.Size(167, 22);
            this.SelectMenuToolStripItem.Text = "&Выбор";
            this.SelectMenuToolStripItem.Click += new System.EventHandler(this.SelectMenuToolStripItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 6);
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.changeColorToolStripMenuItem.Text = "&Настроить ручку";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thinToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.thickToolStripMenuItem});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sizeToolStripMenuItem.Text = "Размер";
            // 
            // thinToolStripMenuItem
            // 
            this.thinToolStripMenuItem.Checked = true;
            this.thinToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.thinToolStripMenuItem.Name = "thinToolStripMenuItem";
            this.thinToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.thinToolStripMenuItem.Text = "Хороший";
            this.thinToolStripMenuItem.Click += new System.EventHandler(this.thinToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.mediumToolStripMenuItem.Text = "Средний";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // thickToolStripMenuItem
            // 
            this.thickToolStripMenuItem.Name = "thickToolStripMenuItem";
            this.thickToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.thickToolStripMenuItem.Text = "Толстый";
            this.thickToolStripMenuItem.Click += new System.EventHandler(this.thickToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.toolStripMenuItem4,
            this.customToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.colorToolStripMenuItem.Text = "Цвет";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Checked = true;
            this.redToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.redToolStripMenuItem.Text = "Красный";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.blueToolStripMenuItem.Text = "Синий";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.greenToolStripMenuItem.Text = "Зеленый";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(174, 6);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.customToolStripMenuItem.Text = "Пользовательский";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "&Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "&О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // DrawingTools
            // 
            this.DrawingTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenImageButton,
            this.SaveImageButton,
            this.CopyImageButton,
            this.SendImageButton,
            this.Sep1,
            this.DefaultButton,
            this.PenButton,
            this.HighlighterButton,
            this.EraserButton,
            this.TextButton});
            this.DrawingTools.Location = new System.Drawing.Point(0, 24);
            this.DrawingTools.Name = "DrawingTools";
            this.DrawingTools.Size = new System.Drawing.Size(796, 25);
            this.DrawingTools.TabIndex = 3;
            this.DrawingTools.Text = "toolStrip1";
            // 
            // OpenImageButton
            // 
            this.OpenImageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenImageButton.Image = global::ImageEditor.Properties.Resources.Open;
            this.OpenImageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenImageButton.Name = "OpenImageButton";
            this.OpenImageButton.Size = new System.Drawing.Size(23, 22);
            this.OpenImageButton.Text = "toolStripButton1";
            this.OpenImageButton.ToolTipText = "Открыть изображение";
            this.OpenImageButton.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // SaveImageButton
            // 
            this.SaveImageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveImageButton.Image = global::ImageEditor.Properties.Resources.Save;
            this.SaveImageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveImageButton.Name = "SaveImageButton";
            this.SaveImageButton.Size = new System.Drawing.Size(23, 22);
            this.SaveImageButton.Text = "Save";
            this.SaveImageButton.ToolTipText = "Сохранить";
            this.SaveImageButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // CopyImageButton
            // 
            this.CopyImageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyImageButton.Image = global::ImageEditor.Properties.Resources.Copy;
            this.CopyImageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyImageButton.Name = "CopyImageButton";
            this.CopyImageButton.Size = new System.Drawing.Size(23, 22);
            this.CopyImageButton.Text = "Copy";
            this.CopyImageButton.ToolTipText = "Копировать";
            this.CopyImageButton.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // SendImageButton
            // 
            this.SendImageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SendImageButton.Image = global::ImageEditor.Properties.Resources.Mail;
            this.SendImageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SendImageButton.Name = "SendImageButton";
            this.SendImageButton.Size = new System.Drawing.Size(23, 22);
            this.SendImageButton.Text = "Send Image";
            this.SendImageButton.ToolTipText = "Отправить изображение";
            this.SendImageButton.Click += new System.EventHandler(this.sendToMailMenuItem6_Click);
            // 
            // Sep1
            // 
            this.Sep1.Name = "Sep1";
            this.Sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // DefaultButton
            // 
            this.DefaultButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DefaultButton.Image = global::ImageEditor.Properties.Resources.Pointer;
            this.DefaultButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(23, 22);
            this.DefaultButton.Text = "toolStripButton1";
            this.DefaultButton.ToolTipText = "Указатель";
            this.DefaultButton.Click += new System.EventHandler(this.SelectMenuToolStripItem_Click);
            // 
            // PenButton
            // 
            this.PenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PenButton.Image = global::ImageEditor.Properties.Resources.Pen;
            this.PenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(23, 22);
            this.PenButton.Text = "Pen";
            this.PenButton.ToolTipText = "Ручка";
            this.PenButton.Click += new System.EventHandler(this.penToolStripMenuItem_Click);
            // 
            // HighlighterButton
            // 
            this.HighlighterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HighlighterButton.Image = global::ImageEditor.Properties.Resources.Highlighter;
            this.HighlighterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HighlighterButton.Name = "HighlighterButton";
            this.HighlighterButton.Size = new System.Drawing.Size(23, 22);
            this.HighlighterButton.Text = "Highlighter";
            this.HighlighterButton.ToolTipText = "Маркер";
            this.HighlighterButton.Click += new System.EventHandler(this.highlighterToolStripMenuItem_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EraserButton.Image = global::ImageEditor.Properties.Resources.Eraser;
            this.EraserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(23, 22);
            this.EraserButton.Text = "Eraser";
            this.EraserButton.ToolTipText = "Ластик";
            this.EraserButton.Click += new System.EventHandler(this.eraserToolStripMenuItem_Click);
            // 
            // TextButton
            // 
            this.TextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TextButton.Image = global::ImageEditor.Properties.Resources.Text;
            this.TextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(23, 22);
            this.TextButton.Text = "Insert Text";
            this.TextButton.ToolTipText = "Вставить текст";
            this.TextButton.Click += new System.EventHandler(this.TextToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 470);
            this.panel1.TabIndex = 4;
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.White;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(0, 0);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(795, 470);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            this.picPreview.Click += new System.EventHandler(this.picPreview_Click);
            this.picPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.picPreview_Paint);
            this.picPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPreview_MouseDown);
            this.picPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPreview_MouseMove);
            this.picPreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picPreview_MouseUp);
            // 
            // FrmMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DrawingTools);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMainUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Редактор снимков экрана";
            this.Activated += new System.EventHandler(this.FrmMainUI_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainUI_FormClosing);
            this.Resize += new System.EventHandler(this.FrmMainUI_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DrawingTools.ResumeLayout(false);
            this.DrawingTools.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highlighterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToMailMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip DrawingTools;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.ToolStripButton OpenImageButton;
        private System.Windows.Forms.ToolStripButton SaveImageButton;
        private System.Windows.Forms.ToolStripButton CopyImageButton;
        private System.Windows.Forms.ToolStripButton SendImageButton;
        private System.Windows.Forms.ToolStripSeparator Sep1;
        private System.Windows.Forms.ToolStripButton HighlighterButton;
        private System.Windows.Forms.ToolStripButton EraserButton;
        private System.Windows.Forms.ToolStripButton PenButton;
        private System.Windows.Forms.ToolStripMenuItem TextToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton TextButton;
        private System.Windows.Forms.ToolStripButton DefaultButton;
        private System.Windows.Forms.ToolStripMenuItem SelectMenuToolStripItem;
    }
}

