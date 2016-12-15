namespace Lungs
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._ProgressBar = new System.Windows.Forms.ProgressBar();
            this._MainMenu = new System.Windows.Forms.MenuStrip();
            this._FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ExportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Line1 = new System.Windows.Forms.ToolStripSeparator();
            this._ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ModelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ModelRotationOXMI = new System.Windows.Forms.ToolStripMenuItem();
            this._ModelRotationOYMI = new System.Windows.Forms.ToolStripMenuItem();
            this._ModelRotationOZMI = new System.Windows.Forms.ToolStripMenuItem();
            this._ModelScalingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ModelScalingInMI = new System.Windows.Forms.ToolStripMenuItem();
            this._ModelScalingOutMI = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LightMovementMI = new System.Windows.Forms.ToolStripMenuItem();
            this._LightMovementUpMI = new System.Windows.Forms.ToolStripMenuItem();
            this._LightMovementDownMI = new System.Windows.Forms.ToolStripMenuItem();
            this._LightMovementRightMI = new System.Windows.Forms.ToolStripMenuItem();
            this._LightMovementLeftMI = new System.Windows.Forms.ToolStripMenuItem();
            this._LightMovementForwardMI = new System.Windows.Forms.ToolStripMenuItem();
            this._LightMovementBackMI = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this._SmokingTimeTB = new System.Windows.Forms.TrackBar();
            this._MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SmokingTimeTB)).BeginInit();
            this.SuspendLayout();
            // 
            // _ProgressBar
            // 
            this._ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._ProgressBar.ForeColor = System.Drawing.SystemColors.Desktop;
            this._ProgressBar.Location = new System.Drawing.Point(-1, 280);
            this._ProgressBar.Name = "_ProgressBar";
            this._ProgressBar.Size = new System.Drawing.Size(769, 23);
            this._ProgressBar.TabIndex = 4;
            // 
            // _MainMenu
            // 
            this._MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._FileMenuItem,
            this._ModelMenuItem,
            this.lightToolStripMenuItem,
            this.helpToolStripMenuItem});
            this._MainMenu.Location = new System.Drawing.Point(0, 0);
            this._MainMenu.Name = "_MainMenu";
            this._MainMenu.Size = new System.Drawing.Size(768, 24);
            this._MainMenu.TabIndex = 5;
            // 
            // _FileMenuItem
            // 
            this._FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._OpenMenuItem,
            this._SaveMenuItem,
            this._ExportMenuItem,
            this._Line1,
            this._ExitMenuItem});
            this._FileMenuItem.Name = "_FileMenuItem";
            this._FileMenuItem.Size = new System.Drawing.Size(48, 20);
            this._FileMenuItem.Text = "Файл";
            // 
            // _OpenMenuItem
            // 
            this._OpenMenuItem.Name = "_OpenMenuItem";
            this._OpenMenuItem.Size = new System.Drawing.Size(152, 22);
            this._OpenMenuItem.Text = "Открыть";
            this._OpenMenuItem.Click += new System.EventHandler(this._OpenMenuItem_Click);
            // 
            // _SaveMenuItem
            // 
            this._SaveMenuItem.Name = "_SaveMenuItem";
            this._SaveMenuItem.Size = new System.Drawing.Size(152, 22);
            this._SaveMenuItem.Text = "Сохранить";
            this._SaveMenuItem.Visible = false;
            // 
            // _ExportMenuItem
            // 
            this._ExportMenuItem.Name = "_ExportMenuItem";
            this._ExportMenuItem.Size = new System.Drawing.Size(152, 22);
            this._ExportMenuItem.Text = "Экспорт";
            this._ExportMenuItem.Visible = false;
            // 
            // _Line1
            // 
            this._Line1.Name = "_Line1";
            this._Line1.Size = new System.Drawing.Size(149, 6);
            this._Line1.Visible = false;
            // 
            // _ExitMenuItem
            // 
            this._ExitMenuItem.Name = "_ExitMenuItem";
            this._ExitMenuItem.Size = new System.Drawing.Size(152, 22);
            this._ExitMenuItem.Text = "Выход";
            this._ExitMenuItem.Visible = false;
            // 
            // _ModelMenuItem
            // 
            this._ModelMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotationToolStripMenuItem,
            this._ModelScalingMenuItem});
            this._ModelMenuItem.Name = "_ModelMenuItem";
            this._ModelMenuItem.Size = new System.Drawing.Size(62, 20);
            this._ModelMenuItem.Text = "Модель";
            // 
            // rotationToolStripMenuItem
            // 
            this.rotationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ModelRotationOXMI,
            this._ModelRotationOYMI,
            this._ModelRotationOZMI});
            this.rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            this.rotationToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.rotationToolStripMenuItem.Text = "Вращение";
            // 
            // _ModelRotationOXMI
            // 
            this._ModelRotationOXMI.Name = "_ModelRotationOXMI";
            this._ModelRotationOXMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this._ModelRotationOXMI.Size = new System.Drawing.Size(131, 22);
            this._ModelRotationOXMI.Text = "OX";
            this._ModelRotationOXMI.Click += new System.EventHandler(this.ModifyModel);
            // 
            // _ModelRotationOYMI
            // 
            this._ModelRotationOYMI.Name = "_ModelRotationOYMI";
            this._ModelRotationOYMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this._ModelRotationOYMI.Size = new System.Drawing.Size(131, 22);
            this._ModelRotationOYMI.Text = "OY";
            this._ModelRotationOYMI.Click += new System.EventHandler(this.ModifyModel);
            // 
            // _ModelRotationOZMI
            // 
            this._ModelRotationOZMI.Name = "_ModelRotationOZMI";
            this._ModelRotationOZMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this._ModelRotationOZMI.Size = new System.Drawing.Size(131, 22);
            this._ModelRotationOZMI.Text = "OZ";
            this._ModelRotationOZMI.Click += new System.EventHandler(this.ModifyModel);
            // 
            // _ModelScalingMenuItem
            // 
            this._ModelScalingMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ModelScalingInMI,
            this._ModelScalingOutMI});
            this._ModelScalingMenuItem.Name = "_ModelScalingMenuItem";
            this._ModelScalingMenuItem.Size = new System.Drawing.Size(179, 22);
            this._ModelScalingMenuItem.Text = "Масштабирование";
            // 
            // _ModelScalingInMI
            // 
            this._ModelScalingInMI.Name = "_ModelScalingInMI";
            this._ModelScalingInMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this._ModelScalingInMI.Size = new System.Drawing.Size(189, 22);
            this._ModelScalingInMI.Text = "Увеличение";
            this._ModelScalingInMI.Click += new System.EventHandler(this.ModifyModel);
            // 
            // _ModelScalingOutMI
            // 
            this._ModelScalingOutMI.Name = "_ModelScalingOutMI";
            this._ModelScalingOutMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this._ModelScalingOutMI.Size = new System.Drawing.Size(189, 22);
            this._ModelScalingOutMI.Text = "Уменьшение";
            this._ModelScalingOutMI.Click += new System.EventHandler(this.ModifyModel);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._LightMovementMI});
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.lightToolStripMenuItem.Text = "Свет";
            // 
            // _LightMovementMI
            // 
            this._LightMovementMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._LightMovementUpMI,
            this._LightMovementDownMI,
            this._LightMovementRightMI,
            this._LightMovementLeftMI,
            this._LightMovementForwardMI,
            this._LightMovementBackMI});
            this._LightMovementMI.Name = "_LightMovementMI";
            this._LightMovementMI.Size = new System.Drawing.Size(154, 22);
            this._LightMovementMI.Text = "Перемещение";
            // 
            // _LightMovementUpMI
            // 
            this._LightMovementUpMI.Name = "_LightMovementUpMI";
            this._LightMovementUpMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this._LightMovementUpMI.Size = new System.Drawing.Size(155, 22);
            this._LightMovementUpMI.Text = "Вверх";
            this._LightMovementUpMI.Click += new System.EventHandler(this.ModifyLight);
            // 
            // _LightMovementDownMI
            // 
            this._LightMovementDownMI.Name = "_LightMovementDownMI";
            this._LightMovementDownMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this._LightMovementDownMI.Size = new System.Drawing.Size(155, 22);
            this._LightMovementDownMI.Text = "Вниз";
            this._LightMovementDownMI.Click += new System.EventHandler(this.ModifyLight);
            // 
            // _LightMovementRightMI
            // 
            this._LightMovementRightMI.Name = "_LightMovementRightMI";
            this._LightMovementRightMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this._LightMovementRightMI.Size = new System.Drawing.Size(155, 22);
            this._LightMovementRightMI.Text = "Вправо";
            this._LightMovementRightMI.Click += new System.EventHandler(this.ModifyLight);
            // 
            // _LightMovementLeftMI
            // 
            this._LightMovementLeftMI.Name = "_LightMovementLeftMI";
            this._LightMovementLeftMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this._LightMovementLeftMI.Size = new System.Drawing.Size(155, 22);
            this._LightMovementLeftMI.Text = "Влево";
            this._LightMovementLeftMI.Click += new System.EventHandler(this.ModifyLight);
            // 
            // _LightMovementForwardMI
            // 
            this._LightMovementForwardMI.Name = "_LightMovementForwardMI";
            this._LightMovementForwardMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this._LightMovementForwardMI.Size = new System.Drawing.Size(155, 22);
            this._LightMovementForwardMI.Text = "Вперед";
            this._LightMovementForwardMI.Click += new System.EventHandler(this.ModifyLight);
            // 
            // _LightMovementBackMI
            // 
            this._LightMovementBackMI.Name = "_LightMovementBackMI";
            this._LightMovementBackMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this._LightMovementBackMI.Size = new System.Drawing.Size(155, 22);
            this._LightMovementBackMI.Text = "Назад";
            this._LightMovementBackMI.Click += new System.EventHandler(this.ModifyLight);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            this.helpToolStripMenuItem.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 229);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // _FolderBrowserDialog
            // 
            this._FolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // _SmokingTimeTB
            // 
            this._SmokingTimeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._SmokingTimeTB.AutoSize = false;
            this._SmokingTimeTB.Location = new System.Drawing.Point(0, 23);
            this._SmokingTimeTB.Maximum = 48;
            this._SmokingTimeTB.Name = "_SmokingTimeTB";
            this._SmokingTimeTB.Size = new System.Drawing.Size(768, 22);
            this._SmokingTimeTB.TabIndex = 8;
            this._SmokingTimeTB.Scroll += new System.EventHandler(this.Smoke);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(768, 302);
            this.Controls.Add(this._SmokingTimeTB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._ProgressBar);
            this.Controls.Add(this._MainMenu);
            this.KeyPreview = true;
            this.MainMenuStrip = this._MainMenu;
            this.Name = "MainForm";
            this.Text = "Модель легких человека";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._MainMenu.ResumeLayout(false);
            this._MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SmokingTimeTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar _ProgressBar;
        private System.Windows.Forms.MenuStrip _MainMenu;
        private System.Windows.Forms.ToolStripMenuItem _FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _ExportMenuItem;
        private System.Windows.Forms.ToolStripSeparator _Line1;
        private System.Windows.Forms.ToolStripMenuItem _ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _ModelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem rotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _ModelScalingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _ModelRotationOXMI;
        private System.Windows.Forms.ToolStripMenuItem _ModelRotationOYMI;
        private System.Windows.Forms.ToolStripMenuItem _ModelRotationOZMI;
        private System.Windows.Forms.ToolStripMenuItem _ModelScalingInMI;
        private System.Windows.Forms.ToolStripMenuItem _ModelScalingOutMI;
        private System.Windows.Forms.ToolStripMenuItem _LightMovementMI;
        private System.Windows.Forms.ToolStripMenuItem _LightMovementUpMI;
        private System.Windows.Forms.ToolStripMenuItem _LightMovementDownMI;
        private System.Windows.Forms.ToolStripMenuItem _LightMovementRightMI;
        private System.Windows.Forms.ToolStripMenuItem _LightMovementLeftMI;
        private System.Windows.Forms.ToolStripMenuItem _LightMovementForwardMI;
        private System.Windows.Forms.ToolStripMenuItem _LightMovementBackMI;
        private System.Windows.Forms.FolderBrowserDialog _FolderBrowserDialog;
        private System.Windows.Forms.TrackBar _SmokingTimeTB;
    }
}

