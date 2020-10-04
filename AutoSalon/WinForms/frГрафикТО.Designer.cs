partial class frГрафикТО
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonУдалитьФакт = new System.Windows.Forms.Button();
            this.buttonЗадатьФакт = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonОбновить = new System.Windows.Forms.Button();
            this.label1НаименованиеТовара = new System.Windows.Forms.Label();
            this.gridViewТОфакт = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridПереченьРабот = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridЗапчасти = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonУдалитьРаботу = new System.Windows.Forms.Button();
            this.buttonИзменитьРаботу = new System.Windows.Forms.Button();
            this.buttonДобавитьРаботу = new System.Windows.Forms.Button();
            this.buttonУдалитьЗапчасть = new System.Windows.Forms.Button();
            this.buttonИзменитьЗапчасть = new System.Windows.Forms.Button();
            this.buttonДобавитьЗапчасть = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТОфакт)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridПереченьРабот)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridЗапчасти)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonУдалитьФакт);
            this.splitContainer1.Panel1.Controls.Add(this.buttonЗадатьФакт);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonОбновить);
            this.splitContainer1.Panel1.Controls.Add(this.label1НаименованиеТовара);
            this.splitContainer1.Panel1.Controls.Add(this.gridViewТОфакт);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1282, 564);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonУдалитьФакт
            // 
            this.buttonУдалитьФакт.Location = new System.Drawing.Point(317, 173);
            this.buttonУдалитьФакт.Name = "buttonУдалитьФакт";
            this.buttonУдалитьФакт.Size = new System.Drawing.Size(29, 22);
            this.buttonУдалитьФакт.TabIndex = 14;
            this.buttonУдалитьФакт.Text = "Х";
            this.buttonУдалитьФакт.UseVisualStyleBackColor = true;
            this.buttonУдалитьФакт.Click += new System.EventHandler(this.buttonУдалитьФакт_Click);
            // 
            // buttonЗадатьФакт
            // 
            this.buttonЗадатьФакт.Location = new System.Drawing.Point(249, 173);
            this.buttonЗадатьФакт.Name = "buttonЗадатьФакт";
            this.buttonЗадатьФакт.Size = new System.Drawing.Size(62, 22);
            this.buttonЗадатьФакт.TabIndex = 13;
            this.buttonЗадатьФакт.Text = "Задать";
            this.buttonЗадатьФакт.UseVisualStyleBackColor = true;
            this.buttonЗадатьФакт.Click += new System.EventHandler(this.buttonЗадатьФакт_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Фактическая дата ТО:";
            // 
            // buttonОбновить
            // 
            this.buttonОбновить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonОбновить.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonОбновить.Location = new System.Drawing.Point(1166, 10);
            this.buttonОбновить.Name = "buttonОбновить";
            this.buttonОбновить.Size = new System.Drawing.Size(104, 23);
            this.buttonОбновить.TabIndex = 5;
            this.buttonОбновить.Text = "Обновить";
            this.buttonОбновить.UseVisualStyleBackColor = true;
            this.buttonОбновить.Click += new System.EventHandler(this.buttonОбновить_Click);
            // 
            // label1НаименованиеТовара
            // 
            this.label1НаименованиеТовара.AutoSize = true;
            this.label1НаименованиеТовара.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1НаименованиеТовара.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1НаименованиеТовара.Location = new System.Drawing.Point(7, 13);
            this.label1НаименованиеТовара.Name = "label1НаименованиеТовара";
            this.label1НаименованиеТовара.Size = new System.Drawing.Size(283, 16);
            this.label1НаименованиеТовара.TabIndex = 10;
            this.label1НаименованиеТовара.Text = "График технического обслуживания:";
            // 
            // gridViewТОфакт
            // 
            this.gridViewТОфакт.AllowUserToAddRows = false;
            this.gridViewТОфакт.AllowUserToDeleteRows = false;
            this.gridViewТОфакт.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewТОфакт.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewТОфакт.ColumnHeadersHeight = 20;
            this.gridViewТОфакт.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewТОфакт.Location = new System.Drawing.Point(3, 47);
            this.gridViewТОфакт.MultiSelect = false;
            this.gridViewТОфакт.Name = "gridViewТОфакт";
            this.gridViewТОфакт.ReadOnly = true;
            this.gridViewТОфакт.RowHeadersWidth = 25;
            this.gridViewТОфакт.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewТОфакт.RowTemplate.Height = 18;
            this.gridViewТОфакт.RowTemplate.ReadOnly = true;
            this.gridViewТОфакт.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewТОфакт.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewТОфакт.Size = new System.Drawing.Size(1276, 122);
            this.gridViewТОфакт.TabIndex = 8;
            this.gridViewТОфакт.DataSourceChanged += new System.EventHandler(this.gridViewТОфакт_SelectionChanged);
            this.gridViewТОфакт.SelectionChanged += new System.EventHandler(this.gridViewТОфакт_SelectionChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(1282, 360);
            this.splitContainer2.SplitterDistance = 748;
            this.splitContainer2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridПереченьРабот);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Перечень работ";
            // 
            // dataGridПереченьРабот
            // 
            this.dataGridПереченьРабот.AllowUserToAddRows = false;
            this.dataGridПереченьРабот.AllowUserToDeleteRows = false;
            this.dataGridПереченьРабот.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridПереченьРабот.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridПереченьРабот.ColumnHeadersHeight = 20;
            this.dataGridПереченьРабот.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridПереченьРабот.Location = new System.Drawing.Point(3, 50);
            this.dataGridПереченьРабот.MultiSelect = false;
            this.dataGridПереченьРабот.Name = "dataGridПереченьРабот";
            this.dataGridПереченьРабот.ReadOnly = true;
            this.dataGridПереченьРабот.RowHeadersWidth = 25;
            this.dataGridПереченьРабот.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridПереченьРабот.RowTemplate.Height = 18;
            this.dataGridПереченьРабот.RowTemplate.ReadOnly = true;
            this.dataGridПереченьРабот.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridПереченьРабот.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridПереченьРабот.Size = new System.Drawing.Size(742, 304);
            this.dataGridПереченьРабот.TabIndex = 11;
            this.dataGridПереченьРабот.DataSourceChanged += new System.EventHandler(this.dataGridПереченьРабот_SelectionChanged);
            this.dataGridПереченьРабот.SelectionChanged += new System.EventHandler(this.dataGridПереченьРабот_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonУдалитьРаботу);
            this.panel1.Controls.Add(this.buttonИзменитьРаботу);
            this.panel1.Controls.Add(this.buttonДобавитьРаботу);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 32);
            this.panel1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridЗапчасти);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 360);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Используемые запчасти";
            // 
            // dataGridЗапчасти
            // 
            this.dataGridЗапчасти.AllowUserToAddRows = false;
            this.dataGridЗапчасти.AllowUserToDeleteRows = false;
            this.dataGridЗапчасти.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridЗапчасти.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridЗапчасти.ColumnHeadersHeight = 20;
            this.dataGridЗапчасти.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridЗапчасти.Location = new System.Drawing.Point(3, 50);
            this.dataGridЗапчасти.MultiSelect = false;
            this.dataGridЗапчасти.Name = "dataGridЗапчасти";
            this.dataGridЗапчасти.ReadOnly = true;
            this.dataGridЗапчасти.RowHeadersWidth = 25;
            this.dataGridЗапчасти.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridЗапчасти.RowTemplate.Height = 18;
            this.dataGridЗапчасти.RowTemplate.ReadOnly = true;
            this.dataGridЗапчасти.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridЗапчасти.Size = new System.Drawing.Size(524, 304);
            this.dataGridЗапчасти.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonУдалитьЗапчасть);
            this.panel2.Controls.Add(this.buttonИзменитьЗапчасть);
            this.panel2.Controls.Add(this.buttonДобавитьЗапчасть);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 32);
            this.panel2.TabIndex = 11;
            // 
            // buttonУдалитьРаботу
            // 
            this.buttonУдалитьРаботу.Image = global::AutoSalon.Properties.Resources.Delete_16x16;
            this.buttonУдалитьРаботу.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonУдалитьРаботу.Location = new System.Drawing.Point(73, 3);
            this.buttonУдалитьРаботу.Name = "buttonУдалитьРаботу";
            this.buttonУдалитьРаботу.Size = new System.Drawing.Size(28, 23);
            this.buttonУдалитьРаботу.TabIndex = 7;
            this.buttonУдалитьРаботу.UseVisualStyleBackColor = true;
            this.buttonУдалитьРаботу.Click += new System.EventHandler(this.buttonУдалитьРаботу_Click);
            // 
            // buttonИзменитьРаботу
            // 
            this.buttonИзменитьРаботу.Image = global::AutoSalon.Properties.Resources.Edit_16x16;
            this.buttonИзменитьРаботу.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonИзменитьРаботу.Location = new System.Drawing.Point(39, 3);
            this.buttonИзменитьРаботу.Name = "buttonИзменитьРаботу";
            this.buttonИзменитьРаботу.Size = new System.Drawing.Size(28, 23);
            this.buttonИзменитьРаботу.TabIndex = 6;
            this.buttonИзменитьРаботу.UseVisualStyleBackColor = true;
            this.buttonИзменитьРаботу.Click += new System.EventHandler(this.buttonИзменитьРаботу_Click);
            // 
            // buttonДобавитьРаботу
            // 
            this.buttonДобавитьРаботу.Image = global::AutoSalon.Properties.Resources.Add_16x16;
            this.buttonДобавитьРаботу.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonДобавитьРаботу.Location = new System.Drawing.Point(5, 3);
            this.buttonДобавитьРаботу.Name = "buttonДобавитьРаботу";
            this.buttonДобавитьРаботу.Size = new System.Drawing.Size(28, 23);
            this.buttonДобавитьРаботу.TabIndex = 5;
            this.buttonДобавитьРаботу.UseVisualStyleBackColor = true;
            this.buttonДобавитьРаботу.Click += new System.EventHandler(this.buttonДобавитьРаботу_Click);
            // 
            // buttonУдалитьЗапчасть
            // 
            this.buttonУдалитьЗапчасть.Image = global::AutoSalon.Properties.Resources.Delete_16x16;
            this.buttonУдалитьЗапчасть.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonУдалитьЗапчасть.Location = new System.Drawing.Point(73, 3);
            this.buttonУдалитьЗапчасть.Name = "buttonУдалитьЗапчасть";
            this.buttonУдалитьЗапчасть.Size = new System.Drawing.Size(28, 23);
            this.buttonУдалитьЗапчасть.TabIndex = 7;
            this.buttonУдалитьЗапчасть.UseVisualStyleBackColor = true;
            // 
            // buttonИзменитьЗапчасть
            // 
            this.buttonИзменитьЗапчасть.Image = global::AutoSalon.Properties.Resources.Edit_16x16;
            this.buttonИзменитьЗапчасть.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonИзменитьЗапчасть.Location = new System.Drawing.Point(39, 3);
            this.buttonИзменитьЗапчасть.Name = "buttonИзменитьЗапчасть";
            this.buttonИзменитьЗапчасть.Size = new System.Drawing.Size(28, 23);
            this.buttonИзменитьЗапчасть.TabIndex = 6;
            this.buttonИзменитьЗапчасть.UseVisualStyleBackColor = true;
            // 
            // buttonДобавитьЗапчасть
            // 
            this.buttonДобавитьЗапчасть.Image = global::AutoSalon.Properties.Resources.Add_16x16;
            this.buttonДобавитьЗапчасть.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonДобавитьЗапчасть.Location = new System.Drawing.Point(5, 3);
            this.buttonДобавитьЗапчасть.Name = "buttonДобавитьЗапчасть";
            this.buttonДобавитьЗапчасть.Size = new System.Drawing.Size(28, 23);
            this.buttonДобавитьЗапчасть.TabIndex = 5;
            this.buttonДобавитьЗапчасть.UseVisualStyleBackColor = true;
            // 
            // frГрафикТО
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 564);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frГрафикТО";
            this.Text = "График ТО";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewТОфакт)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridПереченьРабот)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridЗапчасти)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Label label1НаименованиеТовара;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button buttonУдалитьЗапчасть;
    private System.Windows.Forms.Button buttonИзменитьЗапчасть;
    private System.Windows.Forms.Button buttonДобавитьЗапчасть;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button buttonУдалитьРаботу;
    private System.Windows.Forms.Button buttonИзменитьРаботу;
    private System.Windows.Forms.Button buttonДобавитьРаботу;
    private System.Windows.Forms.DataGridView dataGridЗапчасти;
    private System.Windows.Forms.Button buttonОбновить;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Button buttonЗадатьФакт;
    private System.Windows.Forms.DataGridView gridViewТОфакт;
    private System.Windows.Forms.DataGridView dataGridПереченьРабот;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.Button buttonУдалитьФакт;
}
