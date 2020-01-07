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
            this.gridViewСотрудники.GridControl = this.gridControlСотрудники;
            this.gridViewСотрудники.Name = "gridViewСотрудники";
            this.gridViewСотрудники.OptionsBehavior.Editable = false;
            this.gridViewСотрудники.OptionsFind.AlwaysVisible = true;
            this.gridViewСотрудники.OptionsView.ColumnAutoWidth = false;
            this.gridViewСотрудники.OptionsView.ShowGroupPanel = false;
            this.gridViewСотрудники.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewСотрудники_PopupMenuShowing);
            // 
            // frСотрудники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 576);
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
}
