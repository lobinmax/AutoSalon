partial class dlgEditТО_Запчасти
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
            this.labelControl1 = new System.Windows.Forms.Label();
            this.labelControl2 = new System.Windows.Forms.Label();
            this.comboBoxНаименование = new System.Windows.Forms.ComboBox();
            this.simpleButtonОтменить = new System.Windows.Forms.Button();
            this.simpleButtonСохранить = new System.Windows.Forms.Button();
            this.numericUpDownСтоимость = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownКоличество = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownСтоимость)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownКоличество)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSize = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Наименование запчасти:";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSize = true;
            this.labelControl2.Location = new System.Drawing.Point(117, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Стоимость, руб:";
            // 
            // comboBoxНаименование
            // 
            this.comboBoxНаименование.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxНаименование.FormattingEnabled = true;
            this.comboBoxНаименование.Location = new System.Drawing.Point(15, 31);
            this.comboBoxНаименование.Name = "comboBoxНаименование";
            this.comboBoxНаименование.Size = new System.Drawing.Size(369, 21);
            this.comboBoxНаименование.TabIndex = 24;
            this.comboBoxНаименование.SelectedIndexChanged += new System.EventHandler(this.comboBoxНаименование_SelectedIndexChanged);
            // 
            // simpleButtonОтменить
            // 
            this.simpleButtonОтменить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonОтменить.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonОтменить.Image = global::AutoSalon.Properties.Resources.Action_Cancel;
            this.simpleButtonОтменить.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.simpleButtonОтменить.Location = new System.Drawing.Point(280, 133);
            this.simpleButtonОтменить.Name = "simpleButtonОтменить";
            this.simpleButtonОтменить.Size = new System.Drawing.Size(104, 23);
            this.simpleButtonОтменить.TabIndex = 23;
            this.simpleButtonОтменить.Text = "Отменить";
            this.simpleButtonОтменить.Click += new System.EventHandler(this.simpleButtonОтменить_Click);
            // 
            // simpleButtonСохранить
            // 
            this.simpleButtonСохранить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonСохранить.Image = global::AutoSalon.Properties.Resources.Action_Inline_Save;
            this.simpleButtonСохранить.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.simpleButtonСохранить.Location = new System.Drawing.Point(165, 133);
            this.simpleButtonСохранить.Name = "simpleButtonСохранить";
            this.simpleButtonСохранить.Size = new System.Drawing.Size(109, 23);
            this.simpleButtonСохранить.TabIndex = 22;
            this.simpleButtonСохранить.Text = "Сохранить";
            this.simpleButtonСохранить.Click += new System.EventHandler(this.simpleButtonСохранить_Click);
            // 
            // numericUpDownСтоимость
            // 
            this.numericUpDownСтоимость.DecimalPlaces = 2;
            this.numericUpDownСтоимость.Location = new System.Drawing.Point(120, 87);
            this.numericUpDownСтоимость.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownСтоимость.Name = "numericUpDownСтоимость";
            this.numericUpDownСтоимость.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownСтоимость.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Количество, шт:";
            // 
            // numericUpDownКоличество
            // 
            this.numericUpDownКоличество.Location = new System.Drawing.Point(15, 87);
            this.numericUpDownКоличество.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownКоличество.Name = "numericUpDownКоличество";
            this.numericUpDownКоличество.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownКоличество.TabIndex = 27;
            // 
            // dlgEditТО_Запчасти
            // 
            this.AcceptButton = this.simpleButtonСохранить;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.simpleButtonОтменить;
            this.ClientSize = new System.Drawing.Size(400, 168);
            this.Controls.Add(this.numericUpDownКоличество);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownСтоимость);
            this.Controls.Add(this.comboBoxНаименование);
            this.Controls.Add(this.simpleButtonОтменить);
            this.Controls.Add(this.simpleButtonСохранить);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgEditТО_Запчасти";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.dlgEditТО_ВидРаботы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownСтоимость)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownКоличество)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label labelControl1;
    private System.Windows.Forms.Label labelControl2;
    private System.Windows.Forms.Button simpleButtonОтменить;
    private System.Windows.Forms.Button simpleButtonСохранить;
    private System.Windows.Forms.ComboBox comboBoxНаименование;
    private System.Windows.Forms.NumericUpDown numericUpDownСтоимость;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numericUpDownКоличество;
}
