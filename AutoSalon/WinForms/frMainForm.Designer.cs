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
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.barButtonItemСправочники = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemАвтоВПродаже = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemЗаказы = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemДанныеКлиентов = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItemВремяТекущее = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItemDB = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItemServer = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItemМаркиАвто = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageАдминистрирование = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupШтат = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageГараж = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupНаПродаже = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageКлиенты = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupКлиентскаяБаза = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageОтчеты = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupОтчетныеФормы = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            this.skinDropDownButtonItem1,
            this.barButtonItemСправочники,
            this.barButtonItemАвтоВПродаже,
            this.barButtonItemЗаказы,
            this.barButtonItemДанныеКлиентов,
            this.barStaticItemВремяТекущее,
            this.barStaticItemDB,
            this.barStaticItemServer,
            this.barButtonItemМаркиАвто});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageАдминистрирование,
            this.ribbonPageГараж,
            this.ribbonPageКлиенты,
            this.ribbonPageОтчеты});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(980, 150);
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
            this.barButtonItemСотрудники.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemСотрудники_ItemClick);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 3;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // barButtonItemСправочники
            // 
            this.barButtonItemСправочники.Caption = "Справочники";
            this.barButtonItemСправочники.Id = 6;
            this.barButtonItemСправочники.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemСправочники.ImageOptions.Image")));
            this.barButtonItemСправочники.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemСправочники.ImageOptions.LargeImage")));
            this.barButtonItemСправочники.Name = "barButtonItemСправочники";
            this.barButtonItemСправочники.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemСправочники_ItemClick);
            // 
            // barButtonItemАвтоВПродаже
            // 
            this.barButtonItemАвтоВПродаже.Caption = "Авто в продаже";
            this.barButtonItemАвтоВПродаже.Id = 7;
            this.barButtonItemАвтоВПродаже.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemАвтоВПродаже.ImageOptions.Image")));
            this.barButtonItemАвтоВПродаже.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemАвтоВПродаже.ImageOptions.LargeImage")));
            this.barButtonItemАвтоВПродаже.Name = "barButtonItemАвтоВПродаже";
            // 
            // barButtonItemЗаказы
            // 
            this.barButtonItemЗаказы.Caption = "Заказы";
            this.barButtonItemЗаказы.Id = 8;
            this.barButtonItemЗаказы.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemЗаказы.ImageOptions.Image")));
            this.barButtonItemЗаказы.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemЗаказы.ImageOptions.LargeImage")));
            this.barButtonItemЗаказы.Name = "barButtonItemЗаказы";
            // 
            // barButtonItemДанныеКлиентов
            // 
            this.barButtonItemДанныеКлиентов.Caption = "Данные клиентов";
            this.barButtonItemДанныеКлиентов.Id = 9;
            this.barButtonItemДанныеКлиентов.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemДанныеКлиентов.ImageOptions.Image")));
            this.barButtonItemДанныеКлиентов.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemДанныеКлиентов.ImageOptions.LargeImage")));
            this.barButtonItemДанныеКлиентов.Name = "barButtonItemДанныеКлиентов";
            // 
            // barStaticItemВремяТекущее
            // 
            this.barStaticItemВремяТекущее.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItemВремяТекущее.Id = 10;
            this.barStaticItemВремяТекущее.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStaticItemВремяТекущее.ImageOptions.Image")));
            this.barStaticItemВремяТекущее.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barStaticItemВремяТекущее.ImageOptions.LargeImage")));
            this.barStaticItemВремяТекущее.Name = "barStaticItemВремяТекущее";
            this.barStaticItemВремяТекущее.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barStaticItemDB
            // 
            this.barStaticItemDB.Id = 11;
            this.barStaticItemDB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStaticItemDB.ImageOptions.Image")));
            this.barStaticItemDB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barStaticItemDB.ImageOptions.LargeImage")));
            this.barStaticItemDB.Name = "barStaticItemDB";
            this.barStaticItemDB.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barStaticItemServer
            // 
            this.barStaticItemServer.Id = 12;
            this.barStaticItemServer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStaticItemServer.ImageOptions.Image")));
            this.barStaticItemServer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barStaticItemServer.ImageOptions.LargeImage")));
            this.barStaticItemServer.Name = "barStaticItemServer";
            this.barStaticItemServer.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItemМаркиАвто
            // 
            this.barButtonItemМаркиАвто.Caption = "Марки автомобилей";
            this.barButtonItemМаркиАвто.Id = 13;
            this.barButtonItemМаркиАвто.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemМаркиАвто.ImageOptions.Image")));
            this.barButtonItemМаркиАвто.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemМаркиАвто.ImageOptions.LargeImage")));
            this.barButtonItemМаркиАвто.Name = "barButtonItemМаркиАвто";
            this.barButtonItemМаркиАвто.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemМаркиАвто_ItemClick);
            // 
            // ribbonPageАдминистрирование
            // 
            this.ribbonPageАдминистрирование.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupШтат,
            this.ribbonPageGroup2});
            this.ribbonPageАдминистрирование.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageАдминистрирование.ImageOptions.Image")));
            this.ribbonPageАдминистрирование.Name = "ribbonPageАдминистрирование";
            this.ribbonPageАдминистрирование.Text = "Администрирование";
            // 
            // ribbonPageGroupШтат
            // 
            this.ribbonPageGroupШтат.ItemLinks.Add(this.barButtonItemСотрудники);
            this.ribbonPageGroupШтат.Name = "ribbonPageGroupШтат";
            this.ribbonPageGroupШтат.Text = "Штат";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemСправочники);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemМаркиАвто);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Справочники";
            // 
            // ribbonPageГараж
            // 
            this.ribbonPageГараж.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupНаПродаже});
            this.ribbonPageГараж.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageГараж.ImageOptions.Image")));
            this.ribbonPageГараж.Name = "ribbonPageГараж";
            this.ribbonPageГараж.Text = "Гараж";
            // 
            // ribbonPageGroupНаПродаже
            // 
            this.ribbonPageGroupНаПродаже.ItemLinks.Add(this.barButtonItemАвтоВПродаже);
            this.ribbonPageGroupНаПродаже.ItemLinks.Add(this.barButtonItemЗаказы);
            this.ribbonPageGroupНаПродаже.Name = "ribbonPageGroupНаПродаже";
            this.ribbonPageGroupНаПродаже.Text = "На продаже";
            // 
            // ribbonPageКлиенты
            // 
            this.ribbonPageКлиенты.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupКлиентскаяБаза});
            this.ribbonPageКлиенты.Name = "ribbonPageКлиенты";
            this.ribbonPageКлиенты.Text = "Клиенты";
            // 
            // ribbonPageGroupКлиентскаяБаза
            // 
            this.ribbonPageGroupКлиентскаяБаза.ItemLinks.Add(this.barButtonItemДанныеКлиентов);
            this.ribbonPageGroupКлиентскаяБаза.Name = "ribbonPageGroupКлиентскаяБаза";
            this.ribbonPageGroupКлиентскаяБаза.Text = "Клиентская база";
            // 
            // ribbonPageОтчеты
            // 
            this.ribbonPageОтчеты.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupОтчетныеФормы});
            this.ribbonPageОтчеты.Name = "ribbonPageОтчеты";
            this.ribbonPageОтчеты.Text = "Отчеты";
            // 
            // ribbonPageGroupОтчетныеФормы
            // 
            this.ribbonPageGroupОтчетныеФормы.Name = "ribbonPageGroupОтчетныеФормы";
            this.ribbonPageGroupОтчетныеФормы.Text = "Отчетные формы";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItemВремяТекущее);
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItemServer);
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItemDB);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 426);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(980, 23);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frMainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 449);
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupШтат;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemСотрудники;
    private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
    private DevExpress.XtraBars.BarButtonItem barButtonItemСправочники;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageГараж;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupНаПродаже;
    private DevExpress.XtraBars.BarButtonItem barButtonItemАвтоВПродаже;
    private DevExpress.XtraBars.BarButtonItem barButtonItemЗаказы;
    private DevExpress.XtraBars.BarButtonItem barButtonItemДанныеКлиентов;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageКлиенты;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupКлиентскаяБаза;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageОтчеты;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupОтчетныеФормы;
    private DevExpress.XtraBars.BarStaticItem barStaticItemВремяТекущее;
    private System.Windows.Forms.Timer timer;
    private DevExpress.XtraBars.BarStaticItem barStaticItemServer;
    private DevExpress.XtraBars.BarStaticItem barStaticItemDB;
    private DevExpress.XtraBars.BarButtonItem barButtonItemМаркиАвто;
}
