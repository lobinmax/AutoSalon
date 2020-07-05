partial class frЗаказы
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonУдалитьЗаказ = new System.Windows.Forms.Button();
            this.buttonИзменитьЗаказ = new System.Windows.Forms.Button();
            this.buttonОбновить = new System.Windows.Forms.Button();
            this.gridViewЗаказы = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewЗаказы)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonУдалитьЗаказ);
            this.panel1.Controls.Add(this.buttonИзменитьЗаказ);
            this.panel1.Controls.Add(this.buttonОбновить);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 41);
            this.panel1.TabIndex = 8;
            // 
            // buttonУдалитьЗаказ
            // 
            this.buttonУдалитьЗаказ.Image = global::AutoSalon.Properties.Resources.Delete_16x16;
            this.buttonУдалитьЗаказ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonУдалитьЗаказ.Location = new System.Drawing.Point(174, 8);
            this.buttonУдалитьЗаказ.Name = "buttonУдалитьЗаказ";
            this.buttonУдалитьЗаказ.Size = new System.Drawing.Size(28, 23);
            this.buttonУдалитьЗаказ.TabIndex = 7;
            this.buttonУдалитьЗаказ.UseVisualStyleBackColor = true;
            this.buttonУдалитьЗаказ.Click += new System.EventHandler(this.УдалитьЗаказ);
            // 
            // buttonИзменитьЗаказ
            // 
            this.buttonИзменитьЗаказ.Image = global::AutoSalon.Properties.Resources.Edit_16x16;
            this.buttonИзменитьЗаказ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonИзменитьЗаказ.Location = new System.Drawing.Point(140, 8);
            this.buttonИзменитьЗаказ.Name = "buttonИзменитьЗаказ";
            this.buttonИзменитьЗаказ.Size = new System.Drawing.Size(28, 23);
            this.buttonИзменитьЗаказ.TabIndex = 6;
            this.buttonИзменитьЗаказ.UseVisualStyleBackColor = true;
            this.buttonИзменитьЗаказ.Click += new System.EventHandler(this.ИзменитьЗаказ);
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
            // gridViewЗаказы
            // 
            this.gridViewЗаказы.AllowUserToAddRows = false;
            this.gridViewЗаказы.AllowUserToDeleteRows = false;
            this.gridViewЗаказы.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewЗаказы.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewЗаказы.ColumnHeadersHeight = 20;
            this.gridViewЗаказы.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewЗаказы.Location = new System.Drawing.Point(0, 41);
            this.gridViewЗаказы.MultiSelect = false;
            this.gridViewЗаказы.Name = "gridViewЗаказы";
            this.gridViewЗаказы.ReadOnly = true;
            this.gridViewЗаказы.RowHeadersWidth = 25;
            this.gridViewЗаказы.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewЗаказы.RowTemplate.Height = 18;
            this.gridViewЗаказы.RowTemplate.ReadOnly = true;
            this.gridViewЗаказы.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewЗаказы.Size = new System.Drawing.Size(1206, 534);
            this.gridViewЗаказы.TabIndex = 7;
            this.gridViewЗаказы.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridViewЗаказы_MouseClick);
            // 
            // frЗаказы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridViewЗаказы);
            this.Name = "frЗаказы";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.frЗаказы_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewЗаказы)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button buttonУдалитьЗаказ;
    private System.Windows.Forms.Button buttonИзменитьЗаказ;
    private System.Windows.Forms.Button buttonОбновить;
    private System.Windows.Forms.DataGridView gridViewЗаказы;
}