partial class frMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.гаражToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barButtonItemАвтоВПродаже = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barButtonItemСотрудники = new System.Windows.Forms.ToolStripMenuItem();
            this.barButtonItemСправочники = new System.Windows.Forms.ToolStripMenuItem();
            this.barButtonItemМаркиАвто = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barStaticItemDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.barStaticItemServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMDI = new MdiTabControl.TabControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гаражToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.администрированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1291, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // гаражToolStripMenuItem
            // 
            this.гаражToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barButtonItemАвтоВПродаже,
            this.toolStripMenuItem2});
            this.гаражToolStripMenuItem.Name = "гаражToolStripMenuItem";
            this.гаражToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.гаражToolStripMenuItem.Text = "Гараж";
            // 
            // barButtonItemАвтоВПродаже
            // 
            this.barButtonItemАвтоВПродаже.Name = "barButtonItemАвтоВПродаже";
            this.barButtonItemАвтоВПродаже.Size = new System.Drawing.Size(160, 22);
            this.barButtonItemАвтоВПродаже.Text = "Авто в продаже";
            this.barButtonItemАвтоВПродаже.Click += new System.EventHandler(this.barButtonItemАвтоВПродаже_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem2.Text = "Заказы";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem3.Text = "Данные клиентов";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barButtonItemСотрудники,
            this.barButtonItemСправочники,
            this.barButtonItemМаркиАвто});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // barButtonItemСотрудники
            // 
            this.barButtonItemСотрудники.Name = "barButtonItemСотрудники";
            this.barButtonItemСотрудники.Size = new System.Drawing.Size(188, 22);
            this.barButtonItemСотрудники.Text = "Сотрудники";
            this.barButtonItemСотрудники.Click += new System.EventHandler(this.barButtonItemСотрудники_Click);
            // 
            // barButtonItemСправочники
            // 
            this.barButtonItemСправочники.Name = "barButtonItemСправочники";
            this.barButtonItemСправочники.Size = new System.Drawing.Size(188, 22);
            this.barButtonItemСправочники.Text = "Справочники";
            this.barButtonItemСправочники.Click += new System.EventHandler(this.barButtonItemСправочники_Click);
            // 
            // barButtonItemМаркиАвто
            // 
            this.barButtonItemМаркиАвто.Name = "barButtonItemМаркиАвто";
            this.barButtonItemМаркиАвто.Size = new System.Drawing.Size(188, 22);
            this.barButtonItemМаркиАвто.Text = "Марки автомобилей";
            this.barButtonItemМаркиАвто.Click += new System.EventHandler(this.barButtonItemМаркиАвто_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barStaticItemDB,
            this.barStaticItemServer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 618);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1291, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barStaticItemDB
            // 
            this.barStaticItemDB.Image = ((System.Drawing.Image)(resources.GetObject("barStaticItemDB.Image")));
            this.barStaticItemDB.Name = "barStaticItemDB";
            this.barStaticItemDB.Size = new System.Drawing.Size(134, 17);
            this.barStaticItemDB.Text = "toolStripStatusLabel1";
            // 
            // barStaticItemServer
            // 
            this.barStaticItemServer.Image = ((System.Drawing.Image)(resources.GetObject("barStaticItemServer.Image")));
            this.barStaticItemServer.Name = "barStaticItemServer";
            this.barStaticItemServer.Size = new System.Drawing.Size(134, 17);
            this.barStaticItemServer.Text = "toolStripStatusLabel2";
            // 
            // tabControlMDI
            // 
            this.tabControlMDI.BackColor = System.Drawing.SystemColors.Control;
            this.tabControlMDI.BackLowColor = System.Drawing.SystemColors.Control;
            this.tabControlMDI.CloseButtonVisible = true;
            this.tabControlMDI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMDI.Location = new System.Drawing.Point(0, 24);
            this.tabControlMDI.MenuRenderer = null;
            this.tabControlMDI.Name = "tabControlMDI";
            this.tabControlMDI.Size = new System.Drawing.Size(1291, 594);
            this.tabControlMDI.TabBorderEnhanced = true;
            this.tabControlMDI.TabCloseButtonImage = null;
            this.tabControlMDI.TabCloseButtonImageDisabled = null;
            this.tabControlMDI.TabCloseButtonImageHot = null;
            this.tabControlMDI.TabCloseButtonSize = new System.Drawing.Size(14, 14);
            this.tabControlMDI.TabCloseButtonVisible = false;
            this.tabControlMDI.TabGlassGradient = true;
            this.tabControlMDI.TabHeight = 20;
            this.tabControlMDI.TabIconSize = new System.Drawing.Size(0, 0);
            this.tabControlMDI.TabIndex = 3;
            // 
            // frMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 640);
            this.Controls.Add(this.tabControlMDI);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Автосалон";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem гаражToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barButtonItemАвтоВПродаже;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem barButtonItemСотрудники;
        private System.Windows.Forms.ToolStripMenuItem barButtonItemСправочники;
        private System.Windows.Forms.ToolStripMenuItem barButtonItemМаркиАвто;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel barStaticItemDB;
        private System.Windows.Forms.ToolStripStatusLabel barStaticItemServer;
    private MdiTabControl.TabControl tabControlMDI;
}
