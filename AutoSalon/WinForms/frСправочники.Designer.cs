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
            this.navigationPageТипыКПП = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPageТипыПровода = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPageТипыТоплива = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPageЗаказыСтатусы = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPageСтраны = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonОбновить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonУдалить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonИзменить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonДобавить = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlТипыКПП = new DevExpress.XtraGrid.GridControl();
            this.gridViewТипыКпп = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane)).BeginInit();
            this.navigationPane.SuspendLayout();
            this.navigationPageТипыКПП.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlТипыКПП)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипыКпп)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane
            // 
            this.navigationPane.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.navigationPane.Controls.Add(this.navigationPageТипыКузова);
            this.navigationPane.Controls.Add(this.navigationPageТипыКПП);
            this.navigationPane.Controls.Add(this.navigationPageТипыПровода);
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
            this.navigationPageТипыПровода,
            this.navigationPageТипыТоплива,
            this.navigationPageЗаказыСтатусы,
            this.navigationPageСтраны});
            this.navigationPane.RegularSize = new System.Drawing.Size(1058, 440);
            this.navigationPane.SelectedPage = this.navigationPageТипыКПП;
            this.navigationPane.Size = new System.Drawing.Size(1058, 440);
            this.navigationPane.TabIndex = 0;
            // 
            // navigationPageТипыКузова
            // 
            this.navigationPageТипыКузова.Caption = "Типы кузова";
            this.navigationPageТипыКузова.ControlName = "";
            this.navigationPageТипыКузова.ImageOptions.Image = global::AutoSalon.Properties.Resources.Driving_16x16;
            this.navigationPageТипыКузова.Name = "navigationPageТипыКузова";
            this.navigationPageТипыКузова.Size = new System.Drawing.Size(863, 393);
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
            // navigationPageТипыПровода
            // 
            this.navigationPageТипыПровода.Caption = "Типы привода";
            this.navigationPageТипыПровода.ImageOptions.Image = global::AutoSalon.Properties.Resources.Driving_16x16;
            this.navigationPageТипыПровода.Name = "navigationPageТипыПровода";
            this.navigationPageТипыПровода.Size = new System.Drawing.Size(863, 433);
            // 
            // navigationPageТипыТоплива
            // 
            this.navigationPageТипыТоплива.Caption = "Типы топлива";
            this.navigationPageТипыТоплива.ImageOptions.Image = global::AutoSalon.Properties.Resources.Driving_16x16;
            this.navigationPageТипыТоплива.Name = "navigationPageТипыТоплива";
            this.navigationPageТипыТоплива.Size = new System.Drawing.Size(863, 433);
            // 
            // navigationPageЗаказыСтатусы
            // 
            this.navigationPageЗаказыСтатусы.Caption = "Статусы заказов";
            this.navigationPageЗаказыСтатусы.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPageЗаказыСтатусы.ImageOptions.Image")));
            this.navigationPageЗаказыСтатусы.Name = "navigationPageЗаказыСтатусы";
            this.navigationPageЗаказыСтатусы.Size = new System.Drawing.Size(863, 393);
            // 
            // navigationPageСтраны
            // 
            this.navigationPageСтраны.Caption = "Страны";
            this.navigationPageСтраны.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPageСтраны.ImageOptions.Image")));
            this.navigationPageСтраны.Name = "navigationPageСтраны";
            this.navigationPageСтраны.Size = new System.Drawing.Size(863, 433);
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
            // simpleButtonОбновить
            // 
            this.simpleButtonОбновить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Action_Reload;
            this.simpleButtonОбновить.Location = new System.Drawing.Point(114, 3);
            this.simpleButtonОбновить.Name = "simpleButtonОбновить";
            this.simpleButtonОбновить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonОбновить.Size = new System.Drawing.Size(92, 27);
            this.simpleButtonОбновить.TabIndex = 9;
            this.simpleButtonОбновить.Text = "Обновить";
            // 
            // simpleButtonУдалить
            // 
            this.simpleButtonУдалить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Delete_16x16;
            this.simpleButtonУдалить.Location = new System.Drawing.Point(69, 3);
            this.simpleButtonУдалить.Name = "simpleButtonУдалить";
            this.simpleButtonУдалить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonУдалить.Size = new System.Drawing.Size(27, 27);
            this.simpleButtonУдалить.TabIndex = 8;
            // 
            // simpleButtonИзменить
            // 
            this.simpleButtonИзменить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Edit_16x16;
            this.simpleButtonИзменить.Location = new System.Drawing.Point(36, 3);
            this.simpleButtonИзменить.Name = "simpleButtonИзменить";
            this.simpleButtonИзменить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonИзменить.Size = new System.Drawing.Size(27, 27);
            this.simpleButtonИзменить.TabIndex = 7;
            // 
            // simpleButtonДобавить
            // 
            this.simpleButtonДобавить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Add_16x16;
            this.simpleButtonДобавить.Location = new System.Drawing.Point(3, 3);
            this.simpleButtonДобавить.Name = "simpleButtonДобавить";
            this.simpleButtonДобавить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonДобавить.Size = new System.Drawing.Size(27, 27);
            this.simpleButtonДобавить.TabIndex = 6;
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(93, 0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(20, 35);
            this.separatorControl1.TabIndex = 10;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.simpleButtonОбновить);
            this.panelControl2.Controls.Add(this.simpleButtonУдалить);
            this.panelControl2.Controls.Add(this.simpleButtonДобавить);
            this.panelControl2.Controls.Add(this.simpleButtonИзменить);
            this.panelControl2.Controls.Add(this.separatorControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(846, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(210, 36);
            this.panelControl2.TabIndex = 11;
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
            this.gridControlТипыКПП.Click += new System.EventHandler(this.gridControlСотрудники_Click);
            // 
            // gridViewТипыКпп
            // 
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
            // frСправочники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 480);
            this.Controls.Add(this.navigationPane);
            this.Controls.Add(this.panelControl1);
            this.Name = "frСправочники";
            this.Text = "Должности";
            this.Load += new System.EventHandler(this.frСправочники_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane)).EndInit();
            this.navigationPane.ResumeLayout(false);
            this.navigationPageТипыКПП.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlТипыКПП)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТипыКпп)).EndInit();
            this.ResumeLayout(false);

        }

    #endregion

    private DevExpress.XtraBars.Navigation.NavigationPane navigationPane;
    private DevExpress.XtraBars.Navigation.NavigationPage navigationPageТипыКПП;
    private DevExpress.XtraBars.Navigation.NavigationPage navigationPageТипыКузова;
    private DevExpress.XtraBars.Navigation.NavigationPage navigationPageТипыПровода;
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
}
