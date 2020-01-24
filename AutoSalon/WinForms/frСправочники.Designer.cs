    partial class frСправочники
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frСправочники));
            this.navigationPane = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPageТипыКузова = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlТипКузова = new DevExpress.XtraGrid.GridControl();
            this.gridViewТипКузова = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.navigationPageТипыКПП = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlТипыКПП = new DevExpress.XtraGrid.GridControl();
            this.gridViewТипыКпп = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.navigationPageТипыПривода = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPageТипыТоплива = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPageЗаказыСтатусы = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPageСтраны = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonУдалить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonОбновить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonДобавить = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.simpleButtonИзменить = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlТипыПривода = new DevExpress.XtraGrid.GridControl();
            this.gridViewТипыПривода = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlТипыТоплива = new DevExpress.XtraGrid.GridControl();
            this.gridViewТипыТоплива = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlСтатусыЗаказа = new DevExpress.XtraGrid.GridControl();
            this.gridViewСтатусыЗаказа = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlСтраны = new DevExpress.XtraGrid.GridControl();
            this.gridViewСтраны = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane)).BeginInit();
            this.navigationPane.SuspendLayout();
            this.navigationPageТипыКузова.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlТипКузова)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипКузова)).BeginInit();
            this.navigationPageТипыКПП.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlТипыКПП)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипыКпп)).BeginInit();
            this.navigationPageТипыПривода.SuspendLayout();
            this.navigationPageТипыТоплива.SuspendLayout();
            this.navigationPageЗаказыСтатусы.SuspendLayout();
            this.navigationPageСтраны.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlТипыПривода)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипыПривода)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlТипыТоплива)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипыТоплива)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlСтатусыЗаказа)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСтатусыЗаказа)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlСтраны)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСтраны)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane
            // 
            this.navigationPane.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.navigationPane.Controls.Add(this.navigationPageТипыКузова);
            this.navigationPane.Controls.Add(this.navigationPageТипыКПП);
            this.navigationPane.Controls.Add(this.navigationPageТипыПривода);
            this.navigationPane.Controls.Add(this.navigationPageТипыТоплива);
            this.navigationPane.Controls.Add(this.navigationPageЗаказыСтатусы);
            this.navigationPane.Controls.Add(this.navigationPageСтраны);
            this.navigationPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane.Location = new System.Drawing.Point(0, 40);
            this.navigationPane.Name = "navigationPane";
            this.navigationPane.PageProperties.ShowCollapseButton = false;
            this.navigationPane.PageProperties.ShowExpandButton = false;
            this.navigationPane.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.navigationPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageТипыКПП,
            this.navigationPageТипыКузова,
            this.navigationPageТипыПривода,
            this.navigationPageТипыТоплива,
            this.navigationPageЗаказыСтатусы,
            this.navigationPageСтраны});
            this.navigationPane.RegularSize = new System.Drawing.Size(1058, 440);
            this.navigationPane.SelectedPage = this.navigationPageТипыКПП;
            this.navigationPane.Size = new System.Drawing.Size(1058, 440);
            this.navigationPane.TabIndex = 0;
            this.navigationPane.StateChanged += new DevExpress.XtraBars.Navigation.StateChangedEventHandler(this.navigationPane_StateChanged);
            this.navigationPane.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.navigationPane_SelectedPageChanged);
            // 
            // navigationPageТипыКузова
            // 
            this.navigationPageТипыКузова.Caption = "Типы кузова";
            this.navigationPageТипыКузова.ControlName = "";
            this.navigationPageТипыКузова.Controls.Add(this.gridControlТипКузова);
            this.navigationPageТипыКузова.ImageOptions.Image = global::AutoSalon.Properties.Resources.Driving_16x16;
            this.navigationPageТипыКузова.Name = "navigationPageТипыКузова";
            this.navigationPageТипыКузова.Size = new System.Drawing.Size(863, 393);
            // 
            // gridControlТипКузова
            // 
            this.gridControlТипКузова.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlТипКузова.Location = new System.Drawing.Point(0, 0);
            this.gridControlТипКузова.MainView = this.gridViewТипКузова;
            this.gridControlТипКузова.Name = "gridControlТипКузова";
            this.gridControlТипКузова.Size = new System.Drawing.Size(863, 393);
            this.gridControlТипКузова.TabIndex = 2;
            this.gridControlТипКузова.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewТипКузова});
            // 
            // gridViewТипКузова
            // 
            this.gridViewТипКузова.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewТипКузова.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewТипКузова.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewТипКузова.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewТипКузова.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewТипКузова.GridControl = this.gridControlТипКузова;
            this.gridViewТипКузова.Name = "gridViewТипКузова";
            this.gridViewТипКузова.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewТипКузова.OptionsBehavior.ReadOnly = true;
            this.gridViewТипКузова.OptionsFind.AllowFindPanel = false;
            this.gridViewТипКузова.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewТипКузова.OptionsView.ColumnAutoWidth = false;
            this.gridViewТипКузова.OptionsView.ShowGroupPanel = false;
            // 
            // navigationPageТипыКПП
            // 
            this.navigationPageТипыКПП.Caption = "Типы КПП";
            this.navigationPageТипыКПП.Controls.Add(this.gridControlТипыКПП);
            this.navigationPageТипыКПП.ImageOptions.Image = global::AutoSalon.Properties.Resources.Driving_16x16;
            this.navigationPageТипыКПП.Name = "navigationPageТипыКПП";
            this.navigationPageТипыКПП.PageText = "Типы КПП                                 ";
            this.navigationPageТипыКПП.Properties.ShowCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPageТипыКПП.Size = new System.Drawing.Size(863, 393);
            // 
            // gridControlТипыКПП
            // 
            this.gridControlТипыКПП.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlТипыКПП.Location = new System.Drawing.Point(0, 0);
            this.gridControlТипыКПП.MainView = this.gridViewТипыКпп;
            this.gridControlТипыКПП.Name = "gridControlТипыКПП";
            this.gridControlТипыКПП.Size = new System.Drawing.Size(863, 393);
            this.gridControlТипыКПП.TabIndex = 1;
            this.gridControlТипыКПП.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewТипыКпп});
            // 
            // gridViewТипыКпп
            // 
            this.gridViewТипыКпп.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewТипыКпп.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewТипыКпп.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewТипыКпп.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewТипыКпп.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewТипыКпп.GridControl = this.gridControlТипыКПП;
            this.gridViewТипыКпп.Name = "gridViewТипыКпп";
            this.gridViewТипыКпп.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewТипыКпп.OptionsBehavior.ReadOnly = true;
            this.gridViewТипыКпп.OptionsFind.AllowFindPanel = false;
            this.gridViewТипыКпп.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewТипыКпп.OptionsView.ColumnAutoWidth = false;
            this.gridViewТипыКпп.OptionsView.ShowGroupPanel = false;
            // 
            // navigationPageТипыПривода
            // 
            this.navigationPageТипыПривода.Caption = "Типы привода";
            this.navigationPageТипыПривода.Controls.Add(this.gridControlТипыПривода);
            this.navigationPageТипыПривода.ImageOptions.Image = global::AutoSalon.Properties.Resources.Driving_16x16;
            this.navigationPageТипыПривода.Name = "navigationPageТипыПривода";
            this.navigationPageТипыПривода.Size = new System.Drawing.Size(863, 393);
            // 
            // navigationPageТипыТоплива
            // 
            this.navigationPageТипыТоплива.Caption = "Типы топлива";
            this.navigationPageТипыТоплива.Controls.Add(this.gridControlТипыТоплива);
            this.navigationPageТипыТоплива.ImageOptions.Image = global::AutoSalon.Properties.Resources.Driving_16x16;
            this.navigationPageТипыТоплива.Name = "navigationPageТипыТоплива";
            this.navigationPageТипыТоплива.Size = new System.Drawing.Size(863, 393);
            // 
            // navigationPageЗаказыСтатусы
            // 
            this.navigationPageЗаказыСтатусы.Caption = "Статусы заказов";
            this.navigationPageЗаказыСтатусы.Controls.Add(this.gridControlСтатусыЗаказа);
            this.navigationPageЗаказыСтатусы.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPageЗаказыСтатусы.ImageOptions.Image")));
            this.navigationPageЗаказыСтатусы.Name = "navigationPageЗаказыСтатусы";
            this.navigationPageЗаказыСтатусы.Size = new System.Drawing.Size(863, 393);
            // 
            // navigationPageСтраны
            // 
            this.navigationPageСтраны.Caption = "Страны";
            this.navigationPageСтраны.Controls.Add(this.gridControlСтраны);
            this.navigationPageСтраны.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPageСтраны.ImageOptions.Image")));
            this.navigationPageСтраны.Name = "navigationPageСтраны";
            this.navigationPageСтраны.Size = new System.Drawing.Size(863, 393);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1058, 40);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.simpleButtonУдалить);
            this.panelControl2.Controls.Add(this.simpleButtonОбновить);
            this.panelControl2.Controls.Add(this.simpleButtonДобавить);
            this.panelControl2.Controls.Add(this.separatorControl1);
            this.panelControl2.Controls.Add(this.simpleButtonИзменить);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(210, 36);
            this.panelControl2.TabIndex = 11;
            // 
            // simpleButtonУдалить
            // 
            this.simpleButtonУдалить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Delete_16x16;
            this.simpleButtonУдалить.Location = new System.Drawing.Point(176, 4);
            this.simpleButtonУдалить.Name = "simpleButtonУдалить";
            this.simpleButtonУдалить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonУдалить.Size = new System.Drawing.Size(27, 27);
            this.simpleButtonУдалить.TabIndex = 8;
            // 
            // simpleButtonОбновить
            // 
            this.simpleButtonОбновить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Action_Reload;
            this.simpleButtonОбновить.Location = new System.Drawing.Point(7, 4);
            this.simpleButtonОбновить.Name = "simpleButtonОбновить";
            this.simpleButtonОбновить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonОбновить.Size = new System.Drawing.Size(92, 27);
            this.simpleButtonОбновить.TabIndex = 9;
            this.simpleButtonОбновить.Text = "Обновить";
            // 
            // simpleButtonДобавить
            // 
            this.simpleButtonДобавить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Add_16x16;
            this.simpleButtonДобавить.Location = new System.Drawing.Point(110, 4);
            this.simpleButtonДобавить.Name = "simpleButtonДобавить";
            this.simpleButtonДобавить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonДобавить.Size = new System.Drawing.Size(27, 27);
            this.simpleButtonДобавить.TabIndex = 6;
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(95, -1);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(20, 35);
            this.separatorControl1.TabIndex = 10;
            // 
            // simpleButtonИзменить
            // 
            this.simpleButtonИзменить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Edit_16x16;
            this.simpleButtonИзменить.Location = new System.Drawing.Point(143, 4);
            this.simpleButtonИзменить.Name = "simpleButtonИзменить";
            this.simpleButtonИзменить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonИзменить.Size = new System.Drawing.Size(27, 27);
            this.simpleButtonИзменить.TabIndex = 7;
            // 
            // gridControlТипыПривода
            // 
            this.gridControlТипыПривода.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlТипыПривода.Location = new System.Drawing.Point(0, 0);
            this.gridControlТипыПривода.MainView = this.gridViewТипыПривода;
            this.gridControlТипыПривода.Name = "gridControlТипыПривода";
            this.gridControlТипыПривода.Size = new System.Drawing.Size(863, 393);
            this.gridControlТипыПривода.TabIndex = 3;
            this.gridControlТипыПривода.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewТипыПривода});
            // 
            // gridViewТипыПривода
            // 
            this.gridViewТипыПривода.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewТипыПривода.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewТипыПривода.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewТипыПривода.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewТипыПривода.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewТипыПривода.GridControl = this.gridControlТипыПривода;
            this.gridViewТипыПривода.Name = "gridViewТипыПривода";
            this.gridViewТипыПривода.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewТипыПривода.OptionsBehavior.ReadOnly = true;
            this.gridViewТипыПривода.OptionsFind.AllowFindPanel = false;
            this.gridViewТипыПривода.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewТипыПривода.OptionsView.ColumnAutoWidth = false;
            this.gridViewТипыПривода.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlТипыТоплива
            // 
            this.gridControlТипыТоплива.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlТипыТоплива.Location = new System.Drawing.Point(0, 0);
            this.gridControlТипыТоплива.MainView = this.gridViewТипыТоплива;
            this.gridControlТипыТоплива.Name = "gridControlТипыТоплива";
            this.gridControlТипыТоплива.Size = new System.Drawing.Size(863, 393);
            this.gridControlТипыТоплива.TabIndex = 3;
            this.gridControlТипыТоплива.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewТипыТоплива});
            // 
            // gridViewТипыТоплива
            // 
            this.gridViewТипыТоплива.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewТипыТоплива.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewТипыТоплива.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewТипыТоплива.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewТипыТоплива.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewТипыТоплива.GridControl = this.gridControlТипыТоплива;
            this.gridViewТипыТоплива.Name = "gridViewТипыТоплива";
            this.gridViewТипыТоплива.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewТипыТоплива.OptionsBehavior.ReadOnly = true;
            this.gridViewТипыТоплива.OptionsFind.AllowFindPanel = false;
            this.gridViewТипыТоплива.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewТипыТоплива.OptionsView.ColumnAutoWidth = false;
            this.gridViewТипыТоплива.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlСтатусыЗаказа
            // 
            this.gridControlСтатусыЗаказа.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlСтатусыЗаказа.Location = new System.Drawing.Point(0, 0);
            this.gridControlСтатусыЗаказа.MainView = this.gridViewСтатусыЗаказа;
            this.gridControlСтатусыЗаказа.Name = "gridControlСтатусыЗаказа";
            this.gridControlСтатусыЗаказа.Size = new System.Drawing.Size(863, 393);
            this.gridControlСтатусыЗаказа.TabIndex = 3;
            this.gridControlСтатусыЗаказа.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewСтатусыЗаказа});
            // 
            // gridViewСтатусыЗаказа
            // 
            this.gridViewСтатусыЗаказа.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewСтатусыЗаказа.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewСтатусыЗаказа.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewСтатусыЗаказа.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewСтатусыЗаказа.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewСтатусыЗаказа.GridControl = this.gridControlСтатусыЗаказа;
            this.gridViewСтатусыЗаказа.Name = "gridViewСтатусыЗаказа";
            this.gridViewСтатусыЗаказа.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewСтатусыЗаказа.OptionsBehavior.ReadOnly = true;
            this.gridViewСтатусыЗаказа.OptionsFind.AllowFindPanel = false;
            this.gridViewСтатусыЗаказа.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewСтатусыЗаказа.OptionsView.ColumnAutoWidth = false;
            this.gridViewСтатусыЗаказа.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlСтраны
            // 
            this.gridControlСтраны.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlСтраны.Location = new System.Drawing.Point(0, 0);
            this.gridControlСтраны.MainView = this.gridViewСтраны;
            this.gridControlСтраны.Name = "gridControlСтраны";
            this.gridControlСтраны.Size = new System.Drawing.Size(863, 393);
            this.gridControlСтраны.TabIndex = 3;
            this.gridControlСтраны.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewСтраны});
            // 
            // gridViewСтраны
            // 
            this.gridViewСтраны.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewСтраны.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewСтраны.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewСтраны.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewСтраны.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewСтраны.GridControl = this.gridControlСтраны;
            this.gridViewСтраны.Name = "gridViewСтраны";
            this.gridViewСтраны.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewСтраны.OptionsBehavior.ReadOnly = true;
            this.gridViewСтраны.OptionsFind.AllowFindPanel = false;
            this.gridViewСтраны.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewСтраны.OptionsView.ColumnAutoWidth = false;
            this.gridViewСтраны.OptionsView.ShowGroupPanel = false;
            // 
            // frСправочники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 480);
            this.Controls.Add(this.navigationPane);
            this.Controls.Add(this.panelControl1);
            this.Name = "frСправочники";
            this.Text = "Справочники";
            this.Load += new System.EventHandler(this.frСправочники_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane)).EndInit();
            this.navigationPane.ResumeLayout(false);
            this.navigationPageТипыКузова.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlТипКузова)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипКузова)).EndInit();
            this.navigationPageТипыКПП.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlТипыКПП)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипыКпп)).EndInit();
            this.navigationPageТипыПривода.ResumeLayout(false);
            this.navigationPageТипыТоплива.ResumeLayout(false);
            this.navigationPageЗаказыСтатусы.ResumeLayout(false);
            this.navigationPageСтраны.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlТипыПривода)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипыПривода)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlТипыТоплива)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипыТоплива)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlСтатусыЗаказа)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСтатусыЗаказа)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlСтраны)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСтраны)).EndInit();
            this.ResumeLayout(false);

        }

    #endregion

    private DevExpress.XtraBars.Navigation.NavigationPane navigationPane;
    private DevExpress.XtraBars.Navigation.NavigationPage navigationPageТипыКПП;
    private DevExpress.XtraBars.Navigation.NavigationPage navigationPageТипыКузова;
    private DevExpress.XtraBars.Navigation.NavigationPage navigationPageТипыПривода;
    private DevExpress.XtraBars.Navigation.NavigationPage navigationPageТипыТоплива;
    private DevExpress.XtraBars.Navigation.NavigationPage navigationPageЗаказыСтатусы;
    private DevExpress.XtraBars.Navigation.NavigationPage navigationPageСтраны;
    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraEditors.PanelControl panelControl2;
    private DevExpress.XtraEditors.SimpleButton simpleButtonОбновить;
    private DevExpress.XtraEditors.SimpleButton simpleButtonУдалить;
    private DevExpress.XtraEditors.SimpleButton simpleButtonДобавить;
    private DevExpress.XtraEditors.SimpleButton simpleButtonИзменить;
    private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    private DevExpress.XtraGrid.GridControl gridControlТипыКПП;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewТипыКпп;
    private DevExpress.XtraGrid.GridControl gridControlТипКузова;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewТипКузова;
    private DevExpress.XtraGrid.GridControl gridControlТипыПривода;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewТипыПривода;
    private DevExpress.XtraGrid.GridControl gridControlТипыТоплива;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewТипыТоплива;
    private DevExpress.XtraGrid.GridControl gridControlСтатусыЗаказа;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewСтатусыЗаказа;
    private DevExpress.XtraGrid.GridControl gridControlСтраны;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewСтраны;
}
