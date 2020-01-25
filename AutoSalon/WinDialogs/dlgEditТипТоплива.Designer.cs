partial class dlgEditТипТоплива
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditНаименование = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonОтменить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonСохранить = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditНаименование.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Наименование:";
            // 
            // textEditНаименование
            // 
            this.textEditНаименование.Location = new System.Drawing.Point(12, 31);
            this.textEditНаименование.Name = "textEditНаименование";
            this.textEditНаименование.Size = new System.Drawing.Size(286, 20);
            this.textEditНаименование.TabIndex = 4;
            // 
            // simpleButtonОтменить
            // 
            this.simpleButtonОтменить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonОтменить.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonОтменить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Action_Cancel;
            this.simpleButtonОтменить.Location = new System.Drawing.Point(211, 78);
            this.simpleButtonОтменить.Name = "simpleButtonОтменить";
            this.simpleButtonОтменить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonОтменить.Size = new System.Drawing.Size(87, 23);
            this.simpleButtonОтменить.TabIndex = 21;
            this.simpleButtonОтменить.Text = "Отменить";
            this.simpleButtonОтменить.Click += new System.EventHandler(this.simpleButtonОтменить_Click);
            // 
            // simpleButtonСохранить
            // 
            this.simpleButtonСохранить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonСохранить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Action_Inline_Save;
            this.simpleButtonСохранить.Location = new System.Drawing.Point(96, 78);
            this.simpleButtonСохранить.Name = "simpleButtonСохранить";
            this.simpleButtonСохранить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonСохранить.Size = new System.Drawing.Size(109, 23);
            this.simpleButtonСохранить.TabIndex = 20;
            this.simpleButtonСохранить.Text = "Сохранить";
            this.simpleButtonСохранить.Click += new System.EventHandler(this.simpleButtonСохранить_Click);
            // 
            // dlgEditТипКузова
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 113);
            this.Controls.Add(this.simpleButtonОтменить);
            this.Controls.Add(this.simpleButtonСохранить);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditНаименование);
            this.Name = "dlgEditТипКузова";
            this.Text = "XtraForm2";
            this.Load += new System.EventHandler(this.dlgEditТипКПП_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditНаименование.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.TextEdit textEditНаименование;
    private DevExpress.XtraEditors.SimpleButton simpleButtonОтменить;
    private DevExpress.XtraEditors.SimpleButton simpleButtonСохранить;
}