partial class frМаркиАвто
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonОбновить = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlМарки = new DevExpress.XtraGrid.GridControl();
            this.gridViewМарки = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlМодели = new DevExpress.XtraGrid.GridControl();
            this.gridViewМодели = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlПоколения = new DevExpress.XtraGrid.GridControl();
            this.gridViewПоколения = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlМарки)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewМарки)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlМодели)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewМодели)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlПоколения)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewПоколения)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1189, 40);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.simpleButtonОбновить);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(106, 36);
            this.panelControl2.TabIndex = 11;
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
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 40);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlМарки);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1189, 549);
            this.splitContainerControl1.SplitterPosition = 325;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // gridControlМарки
            // 
            this.gridControlМарки.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlМарки.Location = new System.Drawing.Point(0, 0);
            this.gridControlМарки.MainView = this.gridViewМарки;
            this.gridControlМарки.Name = "gridControlМарки";
            this.gridControlМарки.Size = new System.Drawing.Size(325, 549);
            this.gridControlМарки.TabIndex = 2;
            this.gridControlМарки.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewМарки});
            // 
            // gridViewМарки
            // 
            this.gridViewМарки.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewМарки.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewМарки.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewМарки.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewМарки.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewМарки.GridControl = this.gridControlМарки;
            this.gridViewМарки.Name = "gridViewМарки";
            this.gridViewМарки.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewМарки.OptionsBehavior.ReadOnly = true;
            this.gridViewМарки.OptionsFind.AllowFindPanel = false;
            this.gridViewМарки.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewМарки.OptionsView.ShowGroupPanel = false;
            this.gridViewМарки.OptionsView.ShowViewCaption = true;
            this.gridViewМарки.ViewCaption = "Марки автомобилей";
            this.gridViewМарки.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewМарки_PopupMenuShowing);
            this.gridViewМарки.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewМарки_FocusedRowChanged);
            this.gridViewМарки.ColumnFilterChanged += new System.EventHandler(this.gridViewМарки_FilterRowChanged);
            this.gridViewМарки.DataSourceChanged += new System.EventHandler(this.gridViewМарки_FilterRowChanged);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControlМодели);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControlПоколения);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(858, 549);
            this.splitContainerControl2.SplitterPosition = 287;
            this.splitContainerControl2.TabIndex = 0;
            // 
            // gridControlМодели
            // 
            this.gridControlМодели.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlМодели.Location = new System.Drawing.Point(0, 0);
            this.gridControlМодели.MainView = this.gridViewМодели;
            this.gridControlМодели.Name = "gridControlМодели";
            this.gridControlМодели.Size = new System.Drawing.Size(858, 287);
            this.gridControlМодели.TabIndex = 2;
            this.gridControlМодели.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewМодели});
            // 
            // gridViewМодели
            // 
            this.gridViewМодели.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewМодели.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewМодели.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewМодели.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewМодели.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewМодели.GridControl = this.gridControlМодели;
            this.gridViewМодели.Name = "gridViewМодели";
            this.gridViewМодели.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewМодели.OptionsBehavior.ReadOnly = true;
            this.gridViewМодели.OptionsFind.AllowFindPanel = false;
            this.gridViewМодели.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewМодели.OptionsView.ColumnAutoWidth = false;
            this.gridViewМодели.OptionsView.ShowGroupPanel = false;
            this.gridViewМодели.OptionsView.ShowViewCaption = true;
            this.gridViewМодели.ViewCaption = "Модели авмобилей";
            this.gridViewМодели.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewМодели_PopupMenuShowing);
            this.gridViewМодели.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewМодели_FocusedRowChanged);
            this.gridViewМодели.ColumnFilterChanged += new System.EventHandler(this.gridViewМодели_FilterRowChanged);
            this.gridViewМодели.DataSourceChanged += new System.EventHandler(this.gridViewМодели_FilterRowChanged);
            // 
            // gridControlПоколения
            // 
            this.gridControlПоколения.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlПоколения.Location = new System.Drawing.Point(0, 0);
            this.gridControlПоколения.MainView = this.gridViewПоколения;
            this.gridControlПоколения.Name = "gridControlПоколения";
            this.gridControlПоколения.Size = new System.Drawing.Size(858, 256);
            this.gridControlПоколения.TabIndex = 2;
            this.gridControlПоколения.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewПоколения});
            // 
            // gridViewПоколения
            // 
            this.gridViewПоколения.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewПоколения.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewПоколения.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewПоколения.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewПоколения.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewПоколения.GridControl = this.gridControlПоколения;
            this.gridViewПоколения.Name = "gridViewПоколения";
            this.gridViewПоколения.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewПоколения.OptionsBehavior.ReadOnly = true;
            this.gridViewПоколения.OptionsFind.AllowFindPanel = false;
            this.gridViewПоколения.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewПоколения.OptionsView.ColumnAutoWidth = false;
            this.gridViewПоколения.OptionsView.ShowGroupPanel = false;
            this.gridViewПоколения.OptionsView.ShowViewCaption = true;
            this.gridViewПоколения.ViewCaption = "Поколения автомобилей";
            this.gridViewПоколения.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewПоколения_PopupMenuShowing);
            // 
            // frМаркиАвто
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 589);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frМаркиАвто";
            this.Text = "Марки автомобилей";
            this.Load += new System.EventHandler(this.frМаркиАвто_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlМарки)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewМарки)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlМодели)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewМодели)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlПоколения)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewПоколения)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraEditors.PanelControl panelControl2;
    private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
    private DevExpress.XtraEditors.SimpleButton simpleButtonОбновить;
    private DevExpress.XtraGrid.GridControl gridControlМарки;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewМарки;
    private DevExpress.XtraGrid.GridControl gridControlМодели;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewМодели;
    private DevExpress.XtraGrid.GridControl gridControlПоколения;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewПоколения;
}
