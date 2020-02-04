partial class dlgEditАвтоМодели
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
            this.textEditМарка = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonОтменить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonСохранить = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEditНачалоПроизводства = new DevExpress.XtraEditors.TextEdit();
            this.textEditМодель = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textEditОкончаниеПроизводства = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditМарка.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditНачалоПроизводства.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditМодель.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditОкончаниеПроизводства.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditМарка
            // 
            this.textEditМарка.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditМарка.Location = new System.Drawing.Point(192, 18);
            this.textEditМарка.Name = "textEditМарка";
            this.textEditМарка.Properties.ReadOnly = true;
            this.textEditМарка.Size = new System.Drawing.Size(396, 20);
            this.textEditМарка.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(18, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(168, 20);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Марка автомобиля:";
            // 
            // simpleButtonОтменить
            // 
            this.simpleButtonОтменить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonОтменить.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonОтменить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Action_Cancel;
            this.simpleButtonОтменить.Location = new System.Drawing.Point(506, 158);
            this.simpleButtonОтменить.Name = "simpleButtonОтменить";
            this.simpleButtonОтменить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonОтменить.Size = new System.Drawing.Size(87, 23);
            this.simpleButtonОтменить.TabIndex = 19;
            this.simpleButtonОтменить.Text = "Отменить";
            // 
            // simpleButtonСохранить
            // 
            this.simpleButtonСохранить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonСохранить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Action_Inline_Save;
            this.simpleButtonСохранить.Location = new System.Drawing.Point(391, 158);
            this.simpleButtonСохранить.Name = "simpleButtonСохранить";
            this.simpleButtonСохранить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonСохранить.Size = new System.Drawing.Size(109, 23);
            this.simpleButtonСохранить.TabIndex = 18;
            this.simpleButtonСохранить.Text = "Сохранить";
            this.simpleButtonСохранить.Click += new System.EventHandler(this.simpleButtonСохранить_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl9.Location = new System.Drawing.Point(18, 70);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(168, 20);
            this.labelControl9.TabIndex = 28;
            this.labelControl9.Text = "Начало производства, год:";
            // 
            // labelControl5
            // 
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl5.Location = new System.Drawing.Point(18, 96);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(168, 20);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Окончание производства, год:";
            // 
            // textEditНачалоПроизводства
            // 
            this.textEditНачалоПроизводства.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditНачалоПроизводства.Location = new System.Drawing.Point(192, 70);
            this.textEditНачалоПроизводства.Name = "textEditНачалоПроизводства";
            this.textEditНачалоПроизводства.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.textEditНачалоПроизводства.Properties.Mask.EditMask = "[1-2][9-0]\\d\\d";
            this.textEditНачалоПроизводства.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditНачалоПроизводства.Properties.Mask.SaveLiteral = false;
            this.textEditНачалоПроизводства.Size = new System.Drawing.Size(396, 20);
            this.textEditНачалоПроизводства.TabIndex = 26;
            // 
            // textEditМодель
            // 
            this.textEditМодель.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditМодель.Location = new System.Drawing.Point(192, 44);
            this.textEditМодель.Name = "textEditМодель";
            this.textEditМодель.Size = new System.Drawing.Size(396, 20);
            this.textEditМодель.TabIndex = 25;
            // 
            // labelControl6
            // 
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl6.Location = new System.Drawing.Point(18, 44);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(168, 20);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "Модель автомобиля:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 402F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 488F));
            this.tableLayoutPanel1.Controls.Add(this.textEditОкончаниеПроизводства, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.textEditМарка, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textEditМодель, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textEditНачалоПроизводства, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(609, 138);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // textEditОкончаниеПроизводства
            // 
            this.textEditОкончаниеПроизводства.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditОкончаниеПроизводства.Location = new System.Drawing.Point(192, 96);
            this.textEditОкончаниеПроизводства.Name = "textEditОкончаниеПроизводства";
            this.textEditОкончаниеПроизводства.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.textEditОкончаниеПроизводства.Properties.Mask.EditMask = "[1-2][9-0]\\d\\d";
            this.textEditОкончаниеПроизводства.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditОкончаниеПроизводства.Properties.Mask.SaveLiteral = false;
            this.textEditОкончаниеПроизводства.Size = new System.Drawing.Size(396, 20);
            this.textEditОкончаниеПроизводства.TabIndex = 27;
            // 
            // dlgEditАвтоМодели
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 193);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.simpleButtonОтменить);
            this.Controls.Add(this.simpleButtonСохранить);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgEditАвтоМодели";
            this.ShowInTaskbar = false;
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.dlgEditАвтоМодели_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditМарка.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditНачалоПроизводства.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditМодель.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditОкончаниеПроизводства.Properties)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    private DevExpress.XtraEditors.TextEdit textEditМарка;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.SimpleButton simpleButtonОтменить;
    private DevExpress.XtraEditors.SimpleButton simpleButtonСохранить;
    private DevExpress.XtraEditors.TextEdit textEditМодель;
    private DevExpress.XtraEditors.LabelControl labelControl6;
    private DevExpress.XtraEditors.LabelControl labelControl5;
    private DevExpress.XtraEditors.LabelControl labelControl9;
    private DevExpress.XtraEditors.TextEdit textEditНачалоПроизводства;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private DevExpress.XtraEditors.TextEdit textEditОкончаниеПроизводства;
}
