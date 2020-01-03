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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMainForm));
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemСотрудники = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemДолжности = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageАдминистрирование = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupСотрудники = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AutoSaveLayoutToXml = true;
            this.ribbonControl1.AutoSizeItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItemСотрудники,
            this.barButtonItemДолжности,
            this.skinDropDownButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageАдминистрирование});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(1022, 150);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItemСотрудники
            // 
            this.barButtonItemСотрудники.Caption = "Сотрудники";
            this.barButtonItemСотрудники.Id = 1;
            this.barButtonItemСотрудники.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemСотрудники.ImageOptions.Image")));
            this.barButtonItemСотрудники.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemСотрудники.ImageOptions.LargeImage")));
            this.barButtonItemСотрудники.Name = "barButtonItemСотрудники";
            this.barButtonItemСотрудники.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barButtonItemДолжности
            // 
            this.barButtonItemДолжности.Caption = "Должности";
            this.barButtonItemДолжности.Id = 2;
            this.barButtonItemДолжности.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemДолжности.ImageOptions.Image")));
            this.barButtonItemДолжности.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemДолжности.ImageOptions.LargeImage")));
            this.barButtonItemДолжности.Name = "barButtonItemДолжности";
            // 
            // ribbonPageАдминистрирование
            // 
            this.ribbonPageАдминистрирование.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupСотрудники,
            this.ribbonPageGroup2});
            this.ribbonPageАдминистрирование.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPageАдминистрирование.Name = "ribbonPageАдминистрирование";
            this.ribbonPageАдминистрирование.Text = "Администрирование";
            // 
            // ribbonPageGroupСотрудники
            // 
            this.ribbonPageGroupСотрудники.ItemLinks.Add(this.barButtonItemСотрудники);
            this.ribbonPageGroupСотрудники.ItemLinks.Add(this.barButtonItemДолжности);
            this.ribbonPageGroupСотрудники.Name = "ribbonPageGroupСотрудники";
            this.ribbonPageGroupСотрудники.Text = "Сотрудники";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Справочники";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 426);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1022, 23);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 3;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // frMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 449);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frMainForm.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Name = "frMainForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Автосалон";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.XtraForm1_FormClosed);
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageАдминистрирование;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupСотрудники;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemСотрудники;
        private DevExpress.XtraBars.BarButtonItem barButtonItemДолжности;
    private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
}
