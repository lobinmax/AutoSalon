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
            this.panelControl1 = new System.Windows.Forms.Panel();
            this.panelControl2 = new System.Windows.Forms.Panel();
            this.simpleButtonОбновить = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridViewМарки = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gridViewМодели = new System.Windows.Forms.DataGridView();
            this.gridViewПоколения = new System.Windows.Forms.DataGridView();
            this.panelControl1.SuspendLayout();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewМарки)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewМодели)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewПоколения)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1189, 40);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButtonОбновить);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(103, 38);
            this.panelControl2.TabIndex = 11;
            // 
            // simpleButtonОбновить
            // 
            this.simpleButtonОбновить.Image = global::AutoSalon.Properties.Resources.Action_Reload;
            this.simpleButtonОбновить.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.simpleButtonОбновить.Location = new System.Drawing.Point(7, 4);
            this.simpleButtonОбновить.Name = "simpleButtonОбновить";
            this.simpleButtonОбновить.Size = new System.Drawing.Size(83, 27);
            this.simpleButtonОбновить.TabIndex = 9;
            this.simpleButtonОбновить.Text = "Обновить";
            this.simpleButtonОбновить.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.simpleButtonОбновить.Click += new System.EventHandler(this.simpleButtonОбновить_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridViewМарки);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1189, 549);
            this.splitContainer1.SplitterDistance = 335;
            this.splitContainer1.TabIndex = 3;
            // 
            // gridViewМарки
            // 
            this.gridViewМарки.AllowUserToAddRows = false;
            this.gridViewМарки.AllowUserToDeleteRows = false;
            this.gridViewМарки.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewМарки.ColumnHeadersHeight = 20;
            this.gridViewМарки.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewМарки.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewМарки.Location = new System.Drawing.Point(0, 0);
            this.gridViewМарки.MultiSelect = false;
            this.gridViewМарки.Name = "gridViewМарки";
            this.gridViewМарки.ReadOnly = true;
            this.gridViewМарки.RowHeadersWidth = 25;
            this.gridViewМарки.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewМарки.RowTemplate.Height = 18;
            this.gridViewМарки.RowTemplate.ReadOnly = true;
            this.gridViewМарки.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewМарки.Size = new System.Drawing.Size(333, 547);
            this.gridViewМарки.TabIndex = 2;
            this.gridViewМарки.DataSourceChanged += new System.EventHandler(this.gridViewМарки_DataSourceChanged);
            this.gridViewМарки.SelectionChanged += new System.EventHandler(this.gridViewМарки_SelectionChanged);
            this.gridViewМарки.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridViewМарки_MouseClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gridViewМодели);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridViewПоколения);
            this.splitContainer2.Size = new System.Drawing.Size(850, 549);
            this.splitContainer2.SplitterDistance = 266;
            this.splitContainer2.TabIndex = 0;
            // 
            // gridViewМодели
            // 
            this.gridViewМодели.AllowUserToAddRows = false;
            this.gridViewМодели.AllowUserToDeleteRows = false;
            this.gridViewМодели.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewМодели.ColumnHeadersHeight = 20;
            this.gridViewМодели.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewМодели.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewМодели.Location = new System.Drawing.Point(0, 0);
            this.gridViewМодели.MultiSelect = false;
            this.gridViewМодели.Name = "gridViewМодели";
            this.gridViewМодели.ReadOnly = true;
            this.gridViewМодели.RowHeadersWidth = 25;
            this.gridViewМодели.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewМодели.RowTemplate.Height = 18;
            this.gridViewМодели.RowTemplate.ReadOnly = true;
            this.gridViewМодели.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewМодели.Size = new System.Drawing.Size(848, 264);
            this.gridViewМодели.TabIndex = 2;
            this.gridViewМодели.DataSourceChanged += new System.EventHandler(this.gridViewМодели_DataSourceChanged);
            this.gridViewМодели.SelectionChanged += new System.EventHandler(this.gridViewМодели_SelectionChanged);
            this.gridViewМодели.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridViewМодели_MouseClick);
            // 
            // gridViewПоколения
            // 
            this.gridViewПоколения.AllowUserToAddRows = false;
            this.gridViewПоколения.AllowUserToDeleteRows = false;
            this.gridViewПоколения.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewПоколения.ColumnHeadersHeight = 20;
            this.gridViewПоколения.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewПоколения.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewПоколения.Location = new System.Drawing.Point(0, 0);
            this.gridViewПоколения.MultiSelect = false;
            this.gridViewПоколения.Name = "gridViewПоколения";
            this.gridViewПоколения.ReadOnly = true;
            this.gridViewПоколения.RowHeadersWidth = 25;
            this.gridViewПоколения.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewПоколения.RowTemplate.Height = 18;
            this.gridViewПоколения.RowTemplate.ReadOnly = true;
            this.gridViewПоколения.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewПоколения.Size = new System.Drawing.Size(848, 277);
            this.gridViewПоколения.TabIndex = 2;
            this.gridViewПоколения.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridViewПоколения_MouseClick);
            // 
            // frМаркиАвто
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 589);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frМаркиАвто";
            this.Text = "Марки автомобилей";
            this.Load += new System.EventHandler(this.frМаркиАвто_Load);
            this.panelControl1.ResumeLayout(false);
            this.panelControl2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewМарки)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewМодели)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewПоколения)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelControl1;
    private System.Windows.Forms.Panel panelControl2;
    private System.Windows.Forms.Button simpleButtonОбновить;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.DataGridView gridViewМарки;
    private System.Windows.Forms.DataGridView gridViewМодели;
    private System.Windows.Forms.DataGridView gridViewПоколения;
}
