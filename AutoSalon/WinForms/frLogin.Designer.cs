partial class frLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frLogin));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton_Connect = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TextEdit_server = new DevExpress.XtraEditors.MRUEdit();
            this.TextEdit_db = new DevExpress.XtraEditors.MRUEdit();
            this.TextEdit_Login = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TextEdit_Pass = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_server.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_db.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_Login.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_Pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ReadOnly = true;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(272, 163);
            this.pictureEdit1.TabIndex = 0;
            // 
            // simpleButton_Connect
            // 
            this.simpleButton_Connect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_Connect.ImageOptions.Image")));
            this.simpleButton_Connect.Location = new System.Drawing.Point(421, 253);
            this.simpleButton_Connect.Name = "simpleButton_Connect";
            this.simpleButton_Connect.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton_Connect.Size = new System.Drawing.Size(129, 29);
            this.simpleButton_Connect.TabIndex = 1;
            this.simpleButton_Connect.Text = "Подключение";
            this.simpleButton_Connect.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 187);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Сервер базы данных:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(287, 187);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Имя базы данных:";
            // 
            // TextEdit_server
            // 
            this.TextEdit_server.EditValue = "Netbook";
            this.TextEdit_server.Location = new System.Drawing.Point(12, 206);
            this.TextEdit_server.Name = "TextEdit_server";
            this.TextEdit_server.Properties.AllowRemoveMRUItems = false;
            this.TextEdit_server.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TextEdit_server.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TextEdit_server.Properties.ContextImageOptions.Image")));
            this.TextEdit_server.Properties.ImmediatePopup = false;
            this.TextEdit_server.Properties.PopupSizeable = true;
            this.TextEdit_server.Properties.ValidateOnEnterKey = false;
            this.TextEdit_server.Size = new System.Drawing.Size(263, 20);
            this.TextEdit_server.TabIndex = 2;
            // 
            // TextEdit_db
            // 
            this.TextEdit_db.EditValue = "AutoSalon";
            this.TextEdit_db.Location = new System.Drawing.Point(287, 206);
            this.TextEdit_db.Name = "TextEdit_db";
            this.TextEdit_db.Properties.AllowRemoveMRUItems = false;
            this.TextEdit_db.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TextEdit_db.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TextEdit_db.Properties.ContextImageOptions.Image")));
            this.TextEdit_db.Properties.ImmediatePopup = false;
            this.TextEdit_db.Properties.PopupSizeable = true;
            this.TextEdit_db.Properties.ValidateOnEnterKey = false;
            this.TextEdit_db.Size = new System.Drawing.Size(263, 20);
            this.TextEdit_db.TabIndex = 4;
            // 
            // TextEdit_Login
            // 
            this.TextEdit_Login.EditValue = "Compic\\IamUser";
            this.TextEdit_Login.Location = new System.Drawing.Point(319, 31);
            this.TextEdit_Login.Name = "TextEdit_Login";
            this.TextEdit_Login.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TextEdit_Login.Properties.ContextImageOptions.Image")));
            this.TextEdit_Login.Size = new System.Drawing.Size(231, 20);
            this.TextEdit_Login.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(319, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Имя пользователя:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(319, 75);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Пароль:";
            // 
            // TextEdit_Pass
            // 
            this.TextEdit_Pass.EditValue = "123";
            this.TextEdit_Pass.Location = new System.Drawing.Point(319, 94);
            this.TextEdit_Pass.Name = "TextEdit_Pass";
            this.TextEdit_Pass.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TextEdit_Pass.Properties.ContextImageOptions.Image")));
            this.TextEdit_Pass.Properties.PasswordChar = '•';
            this.TextEdit_Pass.Size = new System.Drawing.Size(231, 20);
            this.TextEdit_Pass.TabIndex = 8;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(319, 120);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Показать пароль";
            this.checkEdit1.Size = new System.Drawing.Size(231, 19);
            this.checkEdit1.TabIndex = 10;
            // 
            // frLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 298);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TextEdit_Pass);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TextEdit_Login);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton_Connect);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.TextEdit_server);
            this.Controls.Add(this.TextEdit_db);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frLogin.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать ...";
            this.Load += new System.EventHandler(this.frLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_server.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_db.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_Login.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_Pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    private DevExpress.XtraEditors.SimpleButton simpleButton_Connect;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.MRUEdit TextEdit_server;
    private DevExpress.XtraEditors.MRUEdit TextEdit_db;
    private DevExpress.XtraEditors.TextEdit TextEdit_Login;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.TextEdit TextEdit_Pass;
    private DevExpress.XtraEditors.CheckEdit checkEdit1;
}
