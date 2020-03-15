partial class frГаражАвто
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlИсторияЦены = new DevExpress.XtraGrid.GridControl();
            this.gridViewИсторияЦены = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlГараж = new DevExpress.XtraGrid.GridControl();
            this.gridViewГараж = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButtonОбновить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonУдалить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonИзменить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonДобавить = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlИсторияЦены)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewИсторияЦены)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlГараж)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewГараж)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlИсторияЦены);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(343, 587);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "История изменений стоимости";
            // 
            // gridControlИсторияЦены
            // 
            this.gridControlИсторияЦены.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlИсторияЦены.Location = new System.Drawing.Point(2, 22);
            this.gridControlИсторияЦены.MainView = this.gridViewИсторияЦены;
            this.gridControlИсторияЦены.Name = "gridControlИсторияЦены";
            this.gridControlИсторияЦены.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControlИсторияЦены.Size = new System.Drawing.Size(339, 563);
            this.gridControlИсторияЦены.TabIndex = 3;
            this.gridControlИсторияЦены.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewИсторияЦены});
            // 
            // gridViewИсторияЦены
            // 
            this.gridViewИсторияЦены.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewИсторияЦены.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewИсторияЦены.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewИсторияЦены.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewИсторияЦены.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewИсторияЦены.GridControl = this.gridControlИсторияЦены;
            this.gridViewИсторияЦены.Name = "gridViewИсторияЦены";
            this.gridViewИсторияЦены.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewИсторияЦены.OptionsBehavior.ReadOnly = true;
            this.gridViewИсторияЦены.OptionsFind.AllowFindPanel = false;
            this.gridViewИсторияЦены.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewИсторияЦены.OptionsView.ColumnAutoWidth = false;
            this.gridViewИсторияЦены.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlГараж
            // 
            this.gridControlГараж.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlГараж.Location = new System.Drawing.Point(0, 0);
            this.gridControlГараж.MainView = this.gridViewГараж;
            this.gridControlГараж.Name = "gridControlГараж";
            this.gridControlГараж.Size = new System.Drawing.Size(1004, 587);
            this.gridControlГараж.TabIndex = 2;
            this.gridControlГараж.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewГараж});
            // 
            // gridViewГараж
            // 
            this.gridViewГараж.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewГараж.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewГараж.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewГараж.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewГараж.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewГараж.GridControl = this.gridControlГараж;
            this.gridViewГараж.Name = "gridViewГараж";
            this.gridViewГараж.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewГараж.OptionsBehavior.ReadOnly = true;
            this.gridViewГараж.OptionsFind.AlwaysVisible = true;
            this.gridViewГараж.OptionsFind.ShowCloseButton = false;
            this.gridViewГараж.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewГараж.OptionsView.ColumnAutoWidth = false;
            this.gridViewГараж.OptionsView.ShowGroupPanel = false;
            this.gridViewГараж.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewГаражи_PopupMenuShowing);
            this.gridViewГараж.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewГараж_FocusedRowChanged);
            this.gridViewГараж.ColumnFilterChanged += new System.EventHandler(this.gridViewГараж_ColumnFilterDataSourceChanged);
            this.gridViewГараж.DataSourceChanged += new System.EventHandler(this.gridViewГараж_ColumnFilterDataSourceChanged);
            // 
            // simpleButtonОбновить
            // 
            this.simpleButtonОбновить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Action_Reload;
            this.simpleButtonОбновить.Location = new System.Drawing.Point(495, 10);
            this.simpleButtonОбновить.Name = "simpleButtonОбновить";
            this.simpleButtonОбновить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonОбновить.Size = new System.Drawing.Size(92, 27);
            this.simpleButtonОбновить.TabIndex = 9;
            this.simpleButtonОбновить.Text = "Обновить";
            this.simpleButtonОбновить.Click += new System.EventHandler(this.simpleButtonОбновить_Click);
            // 
            // simpleButtonУдалить
            // 
            this.simpleButtonУдалить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Delete_16x16;
            this.simpleButtonУдалить.Location = new System.Drawing.Point(673, 10);
            this.simpleButtonУдалить.Name = "simpleButtonУдалить";
            this.simpleButtonУдалить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonУдалить.Size = new System.Drawing.Size(27, 27);
            this.simpleButtonУдалить.TabIndex = 8;
            this.simpleButtonУдалить.Click += new System.EventHandler(this.simpleButtonУдалить_Click);
            // 
            // simpleButtonИзменить
            // 
            this.simpleButtonИзменить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Edit_16x16;
            this.simpleButtonИзменить.Location = new System.Drawing.Point(640, 10);
            this.simpleButtonИзменить.Name = "simpleButtonИзменить";
            this.simpleButtonИзменить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonИзменить.Size = new System.Drawing.Size(27, 27);
            this.simpleButtonИзменить.TabIndex = 7;
            this.simpleButtonИзменить.Click += new System.EventHandler(this.simpleButtonИзменить_Click);
            // 
            // simpleButtonДобавить
            // 
            this.simpleButtonДобавить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Add_16x16;
            this.simpleButtonДобавить.Location = new System.Drawing.Point(607, 10);
            this.simpleButtonДобавить.Name = "simpleButtonДобавить";
            this.simpleButtonДобавить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonДобавить.Size = new System.Drawing.Size(27, 27);
            this.simpleButtonДобавить.TabIndex = 6;
            this.simpleButtonДобавить.Click += new System.EventHandler(this.simpleButtonДобавить_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButtonОбновить);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButtonУдалить);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButtonДобавить);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButtonИзменить);
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlГараж);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1353, 587);
            this.splitContainerControl1.SplitterPosition = 343;
            this.splitContainerControl1.TabIndex = 10;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n2";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // frГаражАвто
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 587);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frГаражАвто";
            this.ShowInTaskbar = false;
            this.Text = "Витрина";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlИсторияЦены)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewИсторияЦены)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlГараж)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewГараж)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    private DevExpress.XtraEditors.GroupControl groupControl1;
    private DevExpress.XtraGrid.GridControl gridControlГараж;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewГараж;
    private DevExpress.XtraEditors.SimpleButton simpleButtonОбновить;
    private DevExpress.XtraEditors.SimpleButton simpleButtonУдалить;
    private DevExpress.XtraEditors.SimpleButton simpleButtonИзменить;
    private DevExpress.XtraEditors.SimpleButton simpleButtonДобавить;
    private DevExpress.XtraGrid.GridControl gridControlИсторияЦены;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewИсторияЦены;
    private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
}
