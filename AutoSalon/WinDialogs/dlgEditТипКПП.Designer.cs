partial class dlgEditТипКПП
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
            this.textEditНаименование = new System.Windows.Forms.TextBox();
            this.labelControl1 = new System.Windows.Forms.Label();
            this.simpleButtonОтменить = new System.Windows.Forms.Button();
            this.simpleButtonСохранить = new System.Windows.Forms.Button();
            this.labelControl2 = new System.Windows.Forms.Label();
            this.textEditНаименованиеСокр = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textEditНаименование
            // 
            this.textEditНаименование.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditНаименование.Location = new System.Drawing.Point(12, 31);
            this.textEditНаименование.Name = "textEditНаименование";
            this.textEditНаименование.Size = new System.Drawing.Size(372, 20);
            this.textEditНаименование.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSize = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Наименование:";
            // 
            // simpleButtonОтменить
            // 
            this.simpleButtonОтменить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonОтменить.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonОтменить.Image = global::AutoSalon.Properties.Resources.Action_Cancel;
            this.simpleButtonОтменить.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.simpleButtonОтменить.Location = new System.Drawing.Point(280, 122);
            this.simpleButtonОтменить.Name = "simpleButtonОтменить";
            this.simpleButtonОтменить.Size = new System.Drawing.Size(104, 23);
            this.simpleButtonОтменить.TabIndex = 19;
            this.simpleButtonОтменить.Text = "Отменить";
            this.simpleButtonОтменить.Click += new System.EventHandler(this.simpleButtonОтменить_Click);
            // 
            // simpleButtonСохранить
            // 
            this.simpleButtonСохранить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonСохранить.Image = global::AutoSalon.Properties.Resources.Action_Inline_Save;
            this.simpleButtonСохранить.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.simpleButtonСохранить.Location = new System.Drawing.Point(165, 122);
            this.simpleButtonСохранить.Name = "simpleButtonСохранить";
            this.simpleButtonСохранить.Size = new System.Drawing.Size(109, 23);
            this.simpleButtonСохранить.TabIndex = 18;
            this.simpleButtonСохранить.Text = "Сохранить";
            this.simpleButtonСохранить.Click += new System.EventHandler(this.simpleButtonСохранить_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSize = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(116, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Наименование сокр.:";
            // 
            // textEditНаименованиеСокр
            // 
            this.textEditНаименованиеСокр.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditНаименованиеСокр.Location = new System.Drawing.Point(12, 79);
            this.textEditНаименованиеСокр.Name = "textEditНаименованиеСокр";
            this.textEditНаименованиеСокр.Size = new System.Drawing.Size(372, 20);
            this.textEditНаименованиеСокр.TabIndex = 20;
            // 
            // dlgEditТипКПП
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 157);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEditНаименованиеСокр);
            this.Controls.Add(this.simpleButtonОтменить);
            this.Controls.Add(this.simpleButtonСохранить);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditНаименование);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgEditТипКПП";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.dlgEditТипКПП_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox textEditНаименование;
    private System.Windows.Forms.Label labelControl1;
    private System.Windows.Forms.Button simpleButtonОтменить;
    private System.Windows.Forms.Button simpleButtonСохранить;
    private System.Windows.Forms.Label labelControl2;
    private System.Windows.Forms.TextBox textEditНаименованиеСокр;
}
