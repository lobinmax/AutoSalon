    partial class frСотрудники
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
            this.gridControlСотрудники = new DevExpress.XtraGrid.GridControl();
            this.gridViewСотрудники = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButtonУдалить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonИзменить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonДобавить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonОбновить = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlСотрудники)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСотрудники)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlСотрудники
            // 
            this.gridControlСотрудники.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlСотрудники.Location = new System.Drawing.Point(0, 0);
            this.gridControlСотрудники.MainView = this.gridViewСотрудники;
            this.gridControlСотрудники.Name = "gridControlСотрудники";
            this.gridControlСотрудники.Size = new System.Drawing.Size(1146, 576);
            this.gridControlСотрудники.TabIndex = 0;
            this.gridControlСотрудники.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewСотрудники});
            // 
            // gridViewСотрудники
            // 
            this.gridViewСотрудники.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewСотрудники.GridControl = this.gridControlСотрудники;
            this.gridViewСотрудники.Name = "gridViewСотрудники";
            this.gridViewСотрудники.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewСотрудники.OptionsBehavior.ReadOnly = true;
            this.gridViewСотрудники.OptionsFind.AlwaysVisible = true;
            this.gridViewСотрудники.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewСотрудники.OptionsView.ColumnAutoWidth = false;
            this.gridViewСотрудники.OptionsView.ShowGroupPanel = false;
            this.gridViewСотрудники.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewСотрудники_PopupMenuShowing);
            // 
            // simpleButtonУдалить
            // 
            this.simpleButtonУдалить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Delete_16x16;
            this.simpleButtonУдалить.Location = new System.Drawing.Point(666, 11);
            this.simpleButtonУдалить.Name = "simpleButtonУдалить";
            this.simpleButtonУдалить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonУдалить.Size = new System.Drawing.Size(27, 27);
            this.simpleButtonУдалить.TabIndex = 4;
            this.simpleButtonУдалить.Click += new System.EventHandler(this.simpleButtonУдалить_Click);
            // 
            // simpleButtonИзменить
            // 
            this.simpleButtonИзменить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Edit_16x16;
            this.simpleButtonИзменить.Location = new System.Drawing.Point(633, 11);
            this.simpleButtonИзменить.Name = "simpleButtonИзменить";
            this.simpleButtonИзменить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonИзменить.Size = new System.Drawing.Size(27, 27);
            this.simpleButtonИзменить.TabIndex = 3;
            this.simpleButtonИзменить.Click += new System.EventHandler(this.simpleButtonИзменить_Click);
            // 
            // simpleButtonДобавить
            // 
            this.simpleButtonДобавить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Add_16x16;
            this.simpleButtonДобавить.Location = new System.Drawing.Point(600, 11);
            this.simpleButtonДобавить.Name = "simpleButtonДобавить";
            this.simpleButtonДобавить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonДобавить.Size = new System.Drawing.Size(27, 27);
            this.simpleButtonДобавить.TabIndex = 2;
            this.simpleButtonДобавить.Click += new System.EventHandler(this.simpleButtonДобавить_Click);
            // 
            // simpleButtonОбновить
            // 
            this.simpleButtonОбновить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Action_Reload;
            this.simpleButtonОбновить.Location = new System.Drawing.Point(488, 11);
            this.simpleButtonОбновить.Name = "simpleButtonОбновить";
            this.simpleButtonОбновить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonОбновить.Size = new System.Drawing.Size(92, 27);
            this.simpleButtonОбновить.TabIndex = 5;
            this.simpleButtonОбновить.Text = "Обновить";
            this.simpleButtonОбновить.Click += new System.EventHandler(this.simpleButtonОбновить_Click);
            // 
            // frСотрудники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 576);
            this.Controls.Add(this.simpleButtonОбновить);
            this.Controls.Add(this.simpleButtonУдалить);
            this.Controls.Add(this.simpleButtonИзменить);
            this.Controls.Add(this.simpleButtonДобавить);
            this.Controls.Add(this.gridControlСотрудники);
            this.Name = "frСотрудники";
            this.Text = "Сотрудники";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frСотрудники_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlСотрудники)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewСотрудники)).EndInit();
            this.ResumeLayout(false);

        }

    #endregion

    private DevExpress.XtraGrid.GridControl gridControlСотрудники;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewСотрудники;
    private DevExpress.XtraEditors.SimpleButton simpleButtonДобавить;
    private DevExpress.XtraEditors.SimpleButton simpleButtonУдалить;
    private DevExpress.XtraEditors.SimpleButton simpleButtonИзменить;
    private DevExpress.XtraEditors.SimpleButton simpleButtonОбновить;
}
