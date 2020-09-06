partial class dlgEditГрафикТО
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
            this.numericСрокГод = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new System.Windows.Forms.Label();
            this.simpleButtonОтменить = new System.Windows.Forms.Button();
            this.simpleButtonСохранить = new System.Windows.Forms.Button();
            this.labelControl1 = new System.Windows.Forms.Label();
            this.textEditНаименование = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericСрокМесяц = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericСрокГод)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericСрокМесяц)).BeginInit();
            this.SuspendLayout();
            // 
            // numericСрокГод
            // 
            this.numericСрокГод.Location = new System.Drawing.Point(15, 19);
            this.numericСрокГод.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericСрокГод.Name = "numericСрокГод";
            this.numericСрокГод.Size = new System.Drawing.Size(69, 20);
            this.numericСрокГод.TabIndex = 35;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSize = true;
            this.labelControl2.Location = new System.Drawing.Point(91, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "год";
            // 
            // simpleButtonОтменить
            // 
            this.simpleButtonОтменить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonОтменить.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonОтменить.Image = global::AutoSalon.Properties.Resources.Action_Cancel;
            this.simpleButtonОтменить.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.simpleButtonОтменить.Location = new System.Drawing.Point(284, 160);
            this.simpleButtonОтменить.Name = "simpleButtonОтменить";
            this.simpleButtonОтменить.Size = new System.Drawing.Size(104, 23);
            this.simpleButtonОтменить.TabIndex = 33;
            this.simpleButtonОтменить.Text = "Отменить";
            this.simpleButtonОтменить.Click += new System.EventHandler(this.simpleButtonОтменить_Click);
            // 
            // simpleButtonСохранить
            // 
            this.simpleButtonСохранить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonСохранить.Image = global::AutoSalon.Properties.Resources.Action_Inline_Save;
            this.simpleButtonСохранить.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.simpleButtonСохранить.Location = new System.Drawing.Point(169, 160);
            this.simpleButtonСохранить.Name = "simpleButtonСохранить";
            this.simpleButtonСохранить.Size = new System.Drawing.Size(109, 23);
            this.simpleButtonСохранить.TabIndex = 32;
            this.simpleButtonСохранить.Text = "Сохранить";
            this.simpleButtonСохранить.Click += new System.EventHandler(this.simpleButtonСохранить_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSize = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Наименование:";
            // 
            // textEditНаименование
            // 
            this.textEditНаименование.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditНаименование.Location = new System.Drawing.Point(12, 31);
            this.textEditНаименование.Name = "textEditНаименование";
            this.textEditНаименование.Size = new System.Drawing.Size(372, 20);
            this.textEditНаименование.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericСрокМесяц);
            this.groupBox1.Controls.Add(this.numericСрокГод);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 68);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начнется через ...";
            // 
            // numericСрокМесяц
            // 
            this.numericСрокМесяц.Location = new System.Drawing.Point(133, 19);
            this.numericСрокМесяц.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericСрокМесяц.Name = "numericСрокМесяц";
            this.numericСрокМесяц.Size = new System.Drawing.Size(69, 20);
            this.numericСрокМесяц.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "месяц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(74, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Отсчет каждого ТО производить с момента продажи авто";
            // 
            // dlgEditГрафикТО
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 195);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButtonОтменить);
            this.Controls.Add(this.simpleButtonСохранить);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditНаименование);
            this.Name = "dlgEditГрафикТО";
            this.Text = "dlgEditГрафикТО";
            this.Load += new System.EventHandler(this.dlgEditГрафикТО_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericСрокГод)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericСрокМесяц)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown numericСрокГод;
    private System.Windows.Forms.Label labelControl2;
    private System.Windows.Forms.Button simpleButtonОтменить;
    private System.Windows.Forms.Button simpleButtonСохранить;
    private System.Windows.Forms.Label labelControl1;
    private System.Windows.Forms.TextBox textEditНаименование;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.NumericUpDown numericСрокМесяц;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
}
