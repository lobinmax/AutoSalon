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
            this.gridViewГараж = new System.Windows.Forms.DataGridView();
            this.gridViewИсторияЦены = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewГараж)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewИсторияЦены)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewГараж
            // 
            this.gridViewГараж.AllowUserToAddRows = false;
            this.gridViewГараж.AllowUserToDeleteRows = false;
            this.gridViewГараж.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewГараж.ColumnHeadersHeight = 20;
            this.gridViewГараж.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewГараж.Location = new System.Drawing.Point(43, 12);
            this.gridViewГараж.MultiSelect = false;
            this.gridViewГараж.Name = "gridViewГараж";
            this.gridViewГараж.ReadOnly = true;
            this.gridViewГараж.RowHeadersWidth = 25;
            this.gridViewГараж.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewГараж.RowTemplate.Height = 18;
            this.gridViewГараж.RowTemplate.ReadOnly = true;
            this.gridViewГараж.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewГараж.Size = new System.Drawing.Size(1090, 288);
            this.gridViewГараж.TabIndex = 2;
            this.gridViewГараж.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridViewГаражи_MouseClick);
            // 
            // gridViewИсторияЦены
            // 
            this.gridViewИсторияЦены.AllowUserToAddRows = false;
            this.gridViewИсторияЦены.AllowUserToDeleteRows = false;
            this.gridViewИсторияЦены.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewИсторияЦены.ColumnHeadersHeight = 20;
            this.gridViewИсторияЦены.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewИсторияЦены.Location = new System.Drawing.Point(43, 322);
            this.gridViewИсторияЦены.MultiSelect = false;
            this.gridViewИсторияЦены.Name = "gridViewИсторияЦены";
            this.gridViewИсторияЦены.ReadOnly = true;
            this.gridViewИсторияЦены.RowHeadersWidth = 25;
            this.gridViewИсторияЦены.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewИсторияЦены.RowTemplate.Height = 18;
            this.gridViewИсторияЦены.RowTemplate.ReadOnly = true;
            this.gridViewИсторияЦены.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewИсторияЦены.Size = new System.Drawing.Size(1090, 143);
            this.gridViewИсторияЦены.TabIndex = 3;
            // 
            // frГаражАвто
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 587);
            this.Controls.Add(this.gridViewИсторияЦены);
            this.Controls.Add(this.gridViewГараж);
            this.Name = "frГаражАвто";
            this.ShowInTaskbar = false;
            this.Text = "Витрина";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewГараж)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewИсторияЦены)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView gridViewГараж;
    private System.Windows.Forms.DataGridView gridViewИсторияЦены;
}
