partial class dlgEditНайденныеКлиенты
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
            this.gridViewНайденныеКлиенты = new System.Windows.Forms.DataGridView();
            this.simpleButtonОтменить = new System.Windows.Forms.Button();
            this.simpleButtonСохранить = new System.Windows.Forms.Button();
            this.textBoxСтрокаПоиска = new System.Windows.Forms.TextBox();
            this.buttonПоискКлиента = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewНайденныеКлиенты)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewНайденныеКлиенты
            // 
            this.gridViewНайденныеКлиенты.AllowUserToAddRows = false;
            this.gridViewНайденныеКлиенты.AllowUserToDeleteRows = false;
            this.gridViewНайденныеКлиенты.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewНайденныеКлиенты.ColumnHeadersHeight = 20;
            this.gridViewНайденныеКлиенты.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewНайденныеКлиенты.Location = new System.Drawing.Point(12, 42);
            this.gridViewНайденныеКлиенты.MultiSelect = false;
            this.gridViewНайденныеКлиенты.Name = "gridViewНайденныеКлиенты";
            this.gridViewНайденныеКлиенты.ReadOnly = true;
            this.gridViewНайденныеКлиенты.RowHeadersWidth = 25;
            this.gridViewНайденныеКлиенты.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewНайденныеКлиенты.RowTemplate.Height = 18;
            this.gridViewНайденныеКлиенты.RowTemplate.ReadOnly = true;
            this.gridViewНайденныеКлиенты.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewНайденныеКлиенты.Size = new System.Drawing.Size(551, 221);
            this.gridViewНайденныеКлиенты.TabIndex = 5;
            // 
            // simpleButtonОтменить
            // 
            this.simpleButtonОтменить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonОтменить.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonОтменить.Image = global::AutoSalon.Properties.Resources.Action_Cancel;
            this.simpleButtonОтменить.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.simpleButtonОтменить.Location = new System.Drawing.Point(459, 289);
            this.simpleButtonОтменить.Name = "simpleButtonОтменить";
            this.simpleButtonОтменить.Size = new System.Drawing.Size(104, 23);
            this.simpleButtonОтменить.TabIndex = 35;
            this.simpleButtonОтменить.Text = "Отменить";
            this.simpleButtonОтменить.Click += new System.EventHandler(this.simpleButtonОтменить_Click);
            // 
            // simpleButtonСохранить
            // 
            this.simpleButtonСохранить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonСохранить.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonСохранить.Image = global::AutoSalon.Properties.Resources.Action_Inline_Save;
            this.simpleButtonСохранить.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.simpleButtonСохранить.Location = new System.Drawing.Point(344, 289);
            this.simpleButtonСохранить.Name = "simpleButtonСохранить";
            this.simpleButtonСохранить.Size = new System.Drawing.Size(109, 23);
            this.simpleButtonСохранить.TabIndex = 34;
            this.simpleButtonСохранить.Text = "Сохранить";
            this.simpleButtonСохранить.Click += new System.EventHandler(this.simpleButtonСохранить_Click);
            // 
            // textBoxСтрокаПоиска
            // 
            this.textBoxСтрокаПоиска.Location = new System.Drawing.Point(12, 6);
            this.textBoxСтрокаПоиска.Name = "textBoxСтрокаПоиска";
            this.textBoxСтрокаПоиска.Size = new System.Drawing.Size(325, 20);
            this.textBoxСтрокаПоиска.TabIndex = 36;
            // 
            // buttonПоискКлиента
            // 
            this.buttonПоискКлиента.Location = new System.Drawing.Point(344, 4);
            this.buttonПоискКлиента.Name = "buttonПоискКлиента";
            this.buttonПоискКлиента.Size = new System.Drawing.Size(109, 23);
            this.buttonПоискКлиента.TabIndex = 37;
            this.buttonПоискКлиента.Text = "Найти клиента";
            this.buttonПоискКлиента.UseVisualStyleBackColor = true;
            this.buttonПоискКлиента.Click += new System.EventHandler(this.buttonПоискКлиента_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(459, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "Показать всех";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dlgEditНайденныеКлиенты
            // 
            this.AcceptButton = this.buttonПоискКлиента;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonОтменить;
            this.ClientSize = new System.Drawing.Size(575, 324);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonПоискКлиента);
            this.Controls.Add(this.textBoxСтрокаПоиска);
            this.Controls.Add(this.simpleButtonОтменить);
            this.Controls.Add(this.simpleButtonСохранить);
            this.Controls.Add(this.gridViewНайденныеКлиенты);
            this.Name = "dlgEditНайденныеКлиенты";
            this.ShowInTaskbar = false;
            this.Text = "dlgEditНайденныеКлиенты";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewНайденныеКлиенты)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView gridViewНайденныеКлиенты;
    private System.Windows.Forms.Button simpleButtonОтменить;
    private System.Windows.Forms.Button simpleButtonСохранить;
    private System.Windows.Forms.TextBox textBoxСтрокаПоиска;
    private System.Windows.Forms.Button buttonПоискКлиента;
    private System.Windows.Forms.CheckBox checkBox1;
}
