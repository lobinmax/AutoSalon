﻿partial class dlgEditАвтоМодели
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
            this.textEditМарка = new System.Windows.Forms.TextBox();
            this.labelControl1 = new System.Windows.Forms.Label();
            this.labelControl9 = new System.Windows.Forms.Label();
            this.labelControl5 = new System.Windows.Forms.Label();
            this.textEditНачалоПроизводства = new System.Windows.Forms.MaskedTextBox();
            this.textEditМодель = new System.Windows.Forms.TextBox();
            this.labelControl6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textEditОкончаниеПроизводства = new System.Windows.Forms.MaskedTextBox();
            this.simpleButtonОтменить = new System.Windows.Forms.Button();
            this.simpleButtonСохранить = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEditМарка
            // 
            this.textEditМарка.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditМарка.Location = new System.Drawing.Point(192, 18);
            this.textEditМарка.Name = "textEditМарка";
            this.textEditМарка.ReadOnly = true;
            this.textEditМарка.Size = new System.Drawing.Size(396, 20);
            this.textEditМарка.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(168, 26);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Марка автомобиля:";
            this.labelControl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(18, 67);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(168, 26);
            this.labelControl9.TabIndex = 28;
            this.labelControl9.Text = "Начало производства, год:";
            this.labelControl9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 93);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(168, 26);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Окончание производства, год:";
            this.labelControl5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textEditНачалоПроизводства
            // 
            this.textEditНачалоПроизводства.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditНачалоПроизводства.Location = new System.Drawing.Point(192, 70);
            this.textEditНачалоПроизводства.Mask = "0000";
            this.textEditНачалоПроизводства.Name = "textEditНачалоПроизводства";
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
            this.labelControl6.Location = new System.Drawing.Point(18, 41);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(168, 26);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "Модель автомобиля:";
            this.labelControl6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.textEditОкончаниеПроизводства.Mask = "0000";
            this.textEditОкончаниеПроизводства.Name = "textEditОкончаниеПроизводства";
            this.textEditОкончаниеПроизводства.Size = new System.Drawing.Size(396, 20);
            this.textEditОкончаниеПроизводства.TabIndex = 27;
            // 
            // simpleButtonОтменить
            // 
            this.simpleButtonОтменить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonОтменить.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonОтменить.Image = global::AutoSalon.Properties.Resources.Action_Cancel;
            this.simpleButtonОтменить.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.simpleButtonОтменить.Location = new System.Drawing.Point(484, 158);
            this.simpleButtonОтменить.Name = "simpleButtonОтменить";
            this.simpleButtonОтменить.Size = new System.Drawing.Size(104, 23);
            this.simpleButtonОтменить.TabIndex = 25;
            this.simpleButtonОтменить.Text = "Отменить";
            this.simpleButtonОтменить.Click += new System.EventHandler(this.simpleButtonОтменить_Click);
            // 
            // simpleButtonСохранить
            // 
            this.simpleButtonСохранить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonСохранить.Image = global::AutoSalon.Properties.Resources.Action_Inline_Save;
            this.simpleButtonСохранить.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.simpleButtonСохранить.Location = new System.Drawing.Point(369, 158);
            this.simpleButtonСохранить.Name = "simpleButtonСохранить";
            this.simpleButtonСохранить.Size = new System.Drawing.Size(109, 23);
            this.simpleButtonСохранить.TabIndex = 24;
            this.simpleButtonСохранить.Text = "Сохранить";
            this.simpleButtonСохранить.Click += new System.EventHandler(this.simpleButtonСохранить_Click);
            // 
            // dlgEditАвтоМодели
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 193);
            this.Controls.Add(this.simpleButtonОтменить);
            this.Controls.Add(this.simpleButtonСохранить);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgEditАвтоМодели";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.dlgEditАвтоМодели_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.TextBox textEditМарка;
    private System.Windows.Forms.Label labelControl1;
    private System.Windows.Forms.TextBox textEditМодель;
    private System.Windows.Forms.Label labelControl6;
    private System.Windows.Forms.Label labelControl5;
    private System.Windows.Forms.Label labelControl9;
    private System.Windows.Forms.MaskedTextBox textEditНачалоПроизводства;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.MaskedTextBox textEditОкончаниеПроизводства;
    private System.Windows.Forms.Button simpleButtonОтменить;
    private System.Windows.Forms.Button simpleButtonСохранить;
}
