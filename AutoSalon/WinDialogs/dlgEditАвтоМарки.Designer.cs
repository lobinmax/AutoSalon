partial class dlgEditАвтоМарки
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
            this.textEditНаименование = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonОтменить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonСохранить = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LookUpEditСтраны = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditНаименование.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditСтраны.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditНаименование
            // 
            this.textEditНаименование.Location = new System.Drawing.Point(12, 31);
            this.textEditНаименование.Name = "textEditНаименование";
            this.textEditНаименование.Size = new System.Drawing.Size(286, 20);
            this.textEditНаименование.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Наименование:";
            // 
            // simpleButtonОтменить
            // 
            this.simpleButtonОтменить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonОтменить.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonОтменить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Action_Cancel;
            this.simpleButtonОтменить.Location = new System.Drawing.Point(211, 135);
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
            this.simpleButtonСохранить.Location = new System.Drawing.Point(96, 135);
            this.simpleButtonСохранить.Name = "simpleButtonСохранить";
            this.simpleButtonСохранить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonСохранить.Size = new System.Drawing.Size(109, 23);
            this.simpleButtonСохранить.TabIndex = 18;
            this.simpleButtonСохранить.Text = "Сохранить";
            this.simpleButtonСохранить.Click += new System.EventHandler(this.simpleButtonСохранить_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Страна:";
            // 
            // LookUpEditСтраны
            // 
            this.LookUpEditСтраны.Location = new System.Drawing.Point(12, 87);
            this.LookUpEditСтраны.Name = "LookUpEditСтраны";
            this.LookUpEditСтраны.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditСтраны.Properties.DisplayMember = "Наименование";
            this.LookUpEditСтраны.Properties.NullText = "";
            this.LookUpEditСтраны.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.LookUpEditСтраны.Properties.ShowHeader = false;
            this.LookUpEditСтраны.Properties.ShowLines = false;
            this.LookUpEditСтраны.Properties.ValueMember = "UIDСтраны";
            this.LookUpEditСтраны.Size = new System.Drawing.Size(286, 20);
            this.LookUpEditСтраны.TabIndex = 20;
            // 
            // dlgEditАвтоМарки
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 170);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButtonОтменить);
            this.Controls.Add(this.simpleButtonСохранить);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditНаименование);
            this.Controls.Add(this.LookUpEditСтраны);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgEditАвтоМарки";
            this.ShowInTaskbar = false;
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.dlgEditАвтоМарки_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditНаименование.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditСтраны.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private DevExpress.XtraEditors.TextEdit textEditНаименование;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.SimpleButton simpleButtonОтменить;
    private DevExpress.XtraEditors.SimpleButton simpleButtonСохранить;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.LookUpEdit LookUpEditСтраны;
}
