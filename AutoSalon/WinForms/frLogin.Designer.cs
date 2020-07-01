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
            this.pictureEdit1 = new System.Windows.Forms.PictureBox();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.labelControl1 = new System.Windows.Forms.Label();
            this.labelControl2 = new System.Windows.Forms.Label();
            this.TextEdit_server = new System.Windows.Forms.ComboBox();
            this.TextEdit_db = new System.Windows.Forms.ComboBox();
            this.TextEdit_Login = new System.Windows.Forms.TextBox();
            this.labelControl3 = new System.Windows.Forms.Label();
            this.labelControl4 = new System.Windows.Forms.Label();
            this.TextEdit_Pass = new System.Windows.Forms.TextBox();
            this.checkEdit1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Image = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Image")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(272, 163);
            this.pictureEdit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEdit1.TabIndex = 0;
            this.pictureEdit1.TabStop = false;
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(421, 253);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(129, 29);
            this.Button_Connect.TabIndex = 1;
            this.Button_Connect.Text = "Подключение";
            this.Button_Connect.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 187);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(263, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Сервер базы данных:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(287, 187);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(263, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Имя базы данных:";
            // 
            // TextEdit_server
            // 
            this.TextEdit_server.Location = new System.Drawing.Point(12, 206);
            this.TextEdit_server.Name = "TextEdit_server";
            this.TextEdit_server.Size = new System.Drawing.Size(263, 21);
            this.TextEdit_server.TabIndex = 2;
            this.TextEdit_server.Text = "DESKTOP-0N5E68P";
            // 
            // TextEdit_db
            // 
            this.TextEdit_db.Location = new System.Drawing.Point(287, 206);
            this.TextEdit_db.Name = "TextEdit_db";
            this.TextEdit_db.Size = new System.Drawing.Size(263, 21);
            this.TextEdit_db.TabIndex = 4;
            this.TextEdit_db.Text = "AutoSalon";
            // 
            // TextEdit_Login
            // 
            this.TextEdit_Login.Location = new System.Drawing.Point(319, 44);
            this.TextEdit_Login.Name = "TextEdit_Login";
            this.TextEdit_Login.Size = new System.Drawing.Size(231, 20);
            this.TextEdit_Login.TabIndex = 6;
            this.TextEdit_Login.Text = "sa";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(319, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(231, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Имя пользователя:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(319, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(231, 16);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Пароль:";
            // 
            // TextEdit_Pass
            // 
            this.TextEdit_Pass.Location = new System.Drawing.Point(319, 107);
            this.TextEdit_Pass.Name = "TextEdit_Pass";
            this.TextEdit_Pass.PasswordChar = '•';
            this.TextEdit_Pass.Size = new System.Drawing.Size(231, 20);
            this.TextEdit_Pass.TabIndex = 8;
            this.TextEdit_Pass.Text = "123";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(319, 133);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Size = new System.Drawing.Size(231, 19);
            this.checkEdit1.TabIndex = 10;
            this.checkEdit1.Text = "Показать пароль";
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
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
            this.Controls.Add(this.Button_Connect);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.TextEdit_server);
            this.Controls.Add(this.TextEdit_db);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать ...";
            this.Load += new System.EventHandler(this.frLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureEdit1;
    private System.Windows.Forms.Button Button_Connect;
    private System.Windows.Forms.Label labelControl1;
    private System.Windows.Forms.Label labelControl2;
    private System.Windows.Forms.ComboBox TextEdit_server;
    private System.Windows.Forms.ComboBox TextEdit_db;
    private System.Windows.Forms.TextBox TextEdit_Login;
    private System.Windows.Forms.Label labelControl3;
    private System.Windows.Forms.Label labelControl4;
    private System.Windows.Forms.TextBox TextEdit_Pass;
    private System.Windows.Forms.CheckBox checkEdit1;
}
