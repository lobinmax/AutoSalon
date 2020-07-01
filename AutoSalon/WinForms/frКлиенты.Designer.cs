partial class frКлиенты
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
            this.gridViewКлиента = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonУдалитьКлиента = new System.Windows.Forms.Button();
            this.buttonИзменитьКлиента = new System.Windows.Forms.Button();
            this.buttonДобавитьКлиента = new System.Windows.Forms.Button();
            this.buttonОбновить = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewКлиента)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewКлиента
            // 
            this.gridViewКлиента.AllowUserToAddRows = false;
            this.gridViewКлиента.AllowUserToDeleteRows = false;
            this.gridViewКлиента.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewКлиента.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewКлиента.ColumnHeadersHeight = 20;
            this.gridViewКлиента.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewКлиента.Location = new System.Drawing.Point(0, 40);
            this.gridViewКлиента.MultiSelect = false;
            this.gridViewКлиента.Name = "gridViewКлиента";
            this.gridViewКлиента.ReadOnly = true;
            this.gridViewКлиента.RowHeadersWidth = 25;
            this.gridViewКлиента.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewКлиента.RowTemplate.Height = 18;
            this.gridViewКлиента.RowTemplate.ReadOnly = true;
            this.gridViewКлиента.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewКлиента.Size = new System.Drawing.Size(1090, 498);
            this.gridViewКлиента.TabIndex = 5;
            this.gridViewКлиента.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridViewКлиента_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonУдалитьКлиента);
            this.panel1.Controls.Add(this.buttonИзменитьКлиента);
            this.panel1.Controls.Add(this.buttonДобавитьКлиента);
            this.panel1.Controls.Add(this.buttonОбновить);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 41);
            this.panel1.TabIndex = 6;
            // 
            // buttonУдалитьКлиента
            // 
            this.buttonУдалитьКлиента.Image = global::AutoSalon.Properties.Resources.Delete_16x16;
            this.buttonУдалитьКлиента.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonУдалитьКлиента.Location = new System.Drawing.Point(208, 8);
            this.buttonУдалитьКлиента.Name = "buttonУдалитьКлиента";
            this.buttonУдалитьКлиента.Size = new System.Drawing.Size(28, 23);
            this.buttonУдалитьКлиента.TabIndex = 7;
            this.buttonУдалитьКлиента.UseVisualStyleBackColor = true;
            this.buttonУдалитьКлиента.Click += new System.EventHandler(this.buttonУдалитьКлиента_Click);
            // 
            // buttonИзменитьКлиента
            // 
            this.buttonИзменитьКлиента.Image = global::AutoSalon.Properties.Resources.Edit_16x16;
            this.buttonИзменитьКлиента.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonИзменитьКлиента.Location = new System.Drawing.Point(174, 8);
            this.buttonИзменитьКлиента.Name = "buttonИзменитьКлиента";
            this.buttonИзменитьКлиента.Size = new System.Drawing.Size(28, 23);
            this.buttonИзменитьКлиента.TabIndex = 6;
            this.buttonИзменитьКлиента.UseVisualStyleBackColor = true;
            this.buttonИзменитьКлиента.Click += new System.EventHandler(this.buttonИзменитьКлиента_Click);
            // 
            // buttonДобавитьКлиента
            // 
            this.buttonДобавитьКлиента.Image = global::AutoSalon.Properties.Resources.Add_16x16;
            this.buttonДобавитьКлиента.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonДобавитьКлиента.Location = new System.Drawing.Point(140, 8);
            this.buttonДобавитьКлиента.Name = "buttonДобавитьКлиента";
            this.buttonДобавитьКлиента.Size = new System.Drawing.Size(28, 23);
            this.buttonДобавитьКлиента.TabIndex = 5;
            this.buttonДобавитьКлиента.UseVisualStyleBackColor = true;
            this.buttonДобавитьКлиента.Click += new System.EventHandler(this.buttonДобавитьКлиента_Click);
            // 
            // buttonОбновить
            // 
            this.buttonОбновить.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonОбновить.Location = new System.Drawing.Point(10, 8);
            this.buttonОбновить.Name = "buttonОбновить";
            this.buttonОбновить.Size = new System.Drawing.Size(104, 23);
            this.buttonОбновить.TabIndex = 4;
            this.buttonОбновить.Text = "Обновить";
            this.buttonОбновить.UseVisualStyleBackColor = true;
            this.buttonОбновить.Click += new System.EventHandler(this.buttonОбновить_Click);
            // 
            // frКлиенты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridViewКлиента);
            this.Name = "frКлиенты";
            this.Text = "Данные клиентов";
            this.Load += new System.EventHandler(this.frКлиенты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewКлиента)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView gridViewКлиента;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button buttonУдалитьКлиента;
    private System.Windows.Forms.Button buttonИзменитьКлиента;
    private System.Windows.Forms.Button buttonДобавитьКлиента;
    private System.Windows.Forms.Button buttonОбновить;
}
