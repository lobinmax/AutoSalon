partial class dlgEditОформитьЗаказ
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageТовар = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxМощностьДвигателя = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxОбъемДвигателя = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new System.Windows.Forms.Label();
            this.labelControl8 = new System.Windows.Forms.Label();
            this.labelControl10 = new System.Windows.Forms.Label();
            this.labelControl11 = new System.Windows.Forms.Label();
            this.labelControl13 = new System.Windows.Forms.Label();
            this.labelControl14 = new System.Windows.Forms.Label();
            this.comboBoxТипТоплива = new System.Windows.Forms.ComboBox();
            this.comboBoxТипПривода = new System.Windows.Forms.ComboBox();
            this.comboBoxТипРуля = new System.Windows.Forms.ComboBox();
            this.comboBoxТипКПП = new System.Windows.Forms.ComboBox();
            this.textEditГодВыпуска = new System.Windows.Forms.TextBox();
            this.textEditПробег = new System.Windows.Forms.TextBox();
            this.textBoxОплачено = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new System.Windows.Forms.Label();
            this.comboBoxПоколение = new System.Windows.Forms.ComboBox();
            this.comboBoxМодель = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new System.Windows.Forms.Label();
            this.labelControl3 = new System.Windows.Forms.Label();
            this.comboBoxМарка = new System.Windows.Forms.ComboBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.textEditСтоимость = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditVIN = new System.Windows.Forms.TextBox();
            this.textEditНомерКузова = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxСтатусЗаказа = new System.Windows.Forms.ComboBox();
            this.labelControl12 = new System.Windows.Forms.Label();
            this.labelControl6 = new System.Windows.Forms.Label();
            this.tabPageКлиент = new System.Windows.Forms.TabPage();
            this.buttonСоздатьКлиента = new System.Windows.Forms.Button();
            this.buttonНайтиКлиента = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new System.Windows.Forms.Label();
            this.textBoxАдресРегистрации = new System.Windows.Forms.TextBox();
            this.textEditФамилия = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBoxПД = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxПДКемВыдан = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxПДДатаВыдачи = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxПДНомер = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxПДСерия = new System.Windows.Forms.MaskedTextBox();
            this.dateEditДатаРождения = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.memoExEditПол = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TextBoxПДКодПодразделения = new System.Windows.Forms.MaskedTextBox();
            this.textEditИмя = new System.Windows.Forms.TextBox();
            this.textEditEmail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textEditОтчество = new System.Windows.Forms.TextBox();
            this.textEditТелефон = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.simpleButtonСохранить = new System.Windows.Forms.Button();
            this.simpleButtonОтменить = new System.Windows.Forms.Button();
            this.labelНомерЗаказа = new System.Windows.Forms.Label();
            this.checkBoxСформироватьГрафикТО = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPageТовар.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageКлиент.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxПД.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageТовар);
            this.tabControl1.Controls.Add(this.tabPageКлиент);
            this.tabControl1.Location = new System.Drawing.Point(2, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 317);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageТовар
            // 
            this.tabPageТовар.Controls.Add(this.checkBoxСформироватьГрафикТО);
            this.tabPageТовар.Controls.Add(this.groupBox1);
            this.tabPageТовар.Controls.Add(this.textBoxОплачено);
            this.tabPageТовар.Controls.Add(this.label4);
            this.tabPageТовар.Controls.Add(this.groupBox2);
            this.tabPageТовар.Controls.Add(this.labelColor);
            this.tabPageТовар.Controls.Add(this.textEditСтоимость);
            this.tabPageТовар.Controls.Add(this.label3);
            this.tabPageТовар.Controls.Add(this.textEditVIN);
            this.tabPageТовар.Controls.Add(this.textEditНомерКузова);
            this.tabPageТовар.Controls.Add(this.label2);
            this.tabPageТовар.Controls.Add(this.label1);
            this.tabPageТовар.Controls.Add(this.comboBoxСтатусЗаказа);
            this.tabPageТовар.Controls.Add(this.labelControl12);
            this.tabPageТовар.Controls.Add(this.labelControl6);
            this.tabPageТовар.Location = new System.Drawing.Point(4, 22);
            this.tabPageТовар.Name = "tabPageТовар";
            this.tabPageТовар.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageТовар.Size = new System.Drawing.Size(774, 291);
            this.tabPageТовар.TabIndex = 0;
            this.tabPageТовар.Text = "Данные товара";
            this.tabPageТовар.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxМощностьДвигателя);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxОбъемДвигателя);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.labelControl11);
            this.groupBox1.Controls.Add(this.labelControl13);
            this.groupBox1.Controls.Add(this.labelControl14);
            this.groupBox1.Controls.Add(this.comboBoxТипТоплива);
            this.groupBox1.Controls.Add(this.comboBoxТипПривода);
            this.groupBox1.Controls.Add(this.comboBoxТипРуля);
            this.groupBox1.Controls.Add(this.comboBoxТипКПП);
            this.groupBox1.Controls.Add(this.textEditГодВыпуска);
            this.groupBox1.Controls.Add(this.textEditПробег);
            this.groupBox1.Location = new System.Drawing.Point(427, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 246);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики автомобиля";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Мощность двигателя:";
            // 
            // comboBoxМощностьДвигателя
            // 
            this.comboBoxМощностьДвигателя.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxМощностьДвигателя.FormattingEnabled = true;
            this.comboBoxМощностьДвигателя.Location = new System.Drawing.Point(145, 212);
            this.comboBoxМощностьДвигателя.Name = "comboBoxМощностьДвигателя";
            this.comboBoxМощностьДвигателя.Size = new System.Drawing.Size(90, 21);
            this.comboBoxМощностьДвигателя.TabIndex = 53;
            this.comboBoxМощностьДвигателя.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Объем двигателя:";
            // 
            // comboBoxОбъемДвигателя
            // 
            this.comboBoxОбъемДвигателя.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxОбъемДвигателя.FormattingEnabled = true;
            this.comboBoxОбъемДвигателя.Location = new System.Drawing.Point(145, 185);
            this.comboBoxОбъемДвигателя.Name = "comboBoxОбъемДвигателя";
            this.comboBoxОбъемДвигателя.Size = new System.Drawing.Size(90, 21);
            this.comboBoxОбъемДвигателя.TabIndex = 51;
            this.comboBoxОбъемДвигателя.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // labelControl7
            // 
            this.labelControl7.AutoEllipsis = true;
            this.labelControl7.AutoSize = true;
            this.labelControl7.Location = new System.Drawing.Point(20, 30);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 13);
            this.labelControl7.TabIndex = 26;
            this.labelControl7.Text = "Тип топлива:";
            // 
            // labelControl8
            // 
            this.labelControl8.AutoEllipsis = true;
            this.labelControl8.AutoSize = true;
            this.labelControl8.Location = new System.Drawing.Point(21, 56);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(74, 13);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Тип привода:";
            // 
            // labelControl10
            // 
            this.labelControl10.AutoEllipsis = true;
            this.labelControl10.AutoSize = true;
            this.labelControl10.Location = new System.Drawing.Point(21, 84);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(55, 13);
            this.labelControl10.TabIndex = 29;
            this.labelControl10.Text = "Тип руля:";
            // 
            // labelControl11
            // 
            this.labelControl11.AutoEllipsis = true;
            this.labelControl11.AutoSize = true;
            this.labelControl11.Location = new System.Drawing.Point(20, 136);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(74, 13);
            this.labelControl11.TabIndex = 30;
            this.labelControl11.Text = "Год выпуска:";
            // 
            // labelControl13
            // 
            this.labelControl13.AutoEllipsis = true;
            this.labelControl13.AutoSize = true;
            this.labelControl13.Location = new System.Drawing.Point(20, 162);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(47, 13);
            this.labelControl13.TabIndex = 24;
            this.labelControl13.Text = "Пробег:";
            // 
            // labelControl14
            // 
            this.labelControl14.AutoEllipsis = true;
            this.labelControl14.AutoSize = true;
            this.labelControl14.Location = new System.Drawing.Point(20, 110);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(55, 13);
            this.labelControl14.TabIndex = 31;
            this.labelControl14.Text = "Тип КПП:";
            // 
            // comboBoxТипТоплива
            // 
            this.comboBoxТипТоплива.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxТипТоплива.Location = new System.Drawing.Point(145, 27);
            this.comboBoxТипТоплива.Name = "comboBoxТипТоплива";
            this.comboBoxТипТоплива.Size = new System.Drawing.Size(171, 21);
            this.comboBoxТипТоплива.TabIndex = 35;
            this.comboBoxТипТоплива.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // comboBoxТипПривода
            // 
            this.comboBoxТипПривода.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxТипПривода.Location = new System.Drawing.Point(145, 53);
            this.comboBoxТипПривода.Name = "comboBoxТипПривода";
            this.comboBoxТипПривода.Size = new System.Drawing.Size(171, 21);
            this.comboBoxТипПривода.TabIndex = 36;
            this.comboBoxТипПривода.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // comboBoxТипРуля
            // 
            this.comboBoxТипРуля.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxТипРуля.Location = new System.Drawing.Point(145, 81);
            this.comboBoxТипРуля.Name = "comboBoxТипРуля";
            this.comboBoxТипРуля.Size = new System.Drawing.Size(171, 21);
            this.comboBoxТипРуля.TabIndex = 38;
            this.comboBoxТипРуля.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // comboBoxТипКПП
            // 
            this.comboBoxТипКПП.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxТипКПП.Location = new System.Drawing.Point(145, 107);
            this.comboBoxТипКПП.Name = "comboBoxТипКПП";
            this.comboBoxТипКПП.Size = new System.Drawing.Size(171, 21);
            this.comboBoxТипКПП.TabIndex = 39;
            this.comboBoxТипКПП.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // textEditГодВыпуска
            // 
            this.textEditГодВыпуска.Location = new System.Drawing.Point(145, 133);
            this.textEditГодВыпуска.Name = "textEditГодВыпуска";
            this.textEditГодВыпуска.ReadOnly = true;
            this.textEditГодВыпуска.Size = new System.Drawing.Size(58, 20);
            this.textEditГодВыпуска.TabIndex = 27;
            // 
            // textEditПробег
            // 
            this.textEditПробег.Location = new System.Drawing.Point(145, 159);
            this.textEditПробег.Name = "textEditПробег";
            this.textEditПробег.ReadOnly = true;
            this.textEditПробег.Size = new System.Drawing.Size(90, 20);
            this.textEditПробег.TabIndex = 24;
            // 
            // textBoxОплачено
            // 
            this.textBoxОплачено.Location = new System.Drawing.Point(99, 258);
            this.textBoxОплачено.Name = "textBoxОплачено";
            this.textBoxОплачено.Size = new System.Drawing.Size(98, 20);
            this.textBoxОплачено.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Оплачено:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.comboBoxПоколение);
            this.groupBox2.Controls.Add(this.comboBoxМодель);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.comboBoxМарка);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 121);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Модель автомобиля";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoEllipsis = true;
            this.labelControl1.AutoSize = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Марка авто:";
            // 
            // comboBoxПоколение
            // 
            this.comboBoxПоколение.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxПоколение.Location = new System.Drawing.Point(130, 81);
            this.comboBoxПоколение.Name = "comboBoxПоколение";
            this.comboBoxПоколение.Size = new System.Drawing.Size(274, 21);
            this.comboBoxПоколение.TabIndex = 33;
            this.comboBoxПоколение.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // comboBoxМодель
            // 
            this.comboBoxМодель.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxМодель.Location = new System.Drawing.Point(130, 54);
            this.comboBoxМодель.Name = "comboBoxМодель";
            this.comboBoxМодель.Size = new System.Drawing.Size(274, 21);
            this.comboBoxМодель.TabIndex = 32;
            this.comboBoxМодель.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.AutoEllipsis = true;
            this.labelControl5.AutoSize = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 84);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(107, 13);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "Поколение модели:";
            // 
            // labelControl3
            // 
            this.labelControl3.AutoEllipsis = true;
            this.labelControl3.AutoSize = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 57);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Модель авто:";
            // 
            // comboBoxМарка
            // 
            this.comboBoxМарка.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxМарка.Location = new System.Drawing.Point(130, 27);
            this.comboBoxМарка.Name = "comboBoxМарка";
            this.comboBoxМарка.Size = new System.Drawing.Size(274, 21);
            this.comboBoxМарка.TabIndex = 24;
            this.comboBoxМарка.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // labelColor
            // 
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColor.Location = new System.Drawing.Point(99, 195);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(61, 17);
            this.labelColor.TabIndex = 65;
            // 
            // textEditСтоимость
            // 
            this.textEditСтоимость.Location = new System.Drawing.Point(321, 192);
            this.textEditСтоимость.Name = "textEditСтоимость";
            this.textEditСтоимость.ReadOnly = true;
            this.textEditСтоимость.Size = new System.Drawing.Size(98, 20);
            this.textEditСтоимость.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Стоимость:";
            // 
            // textEditVIN
            // 
            this.textEditVIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textEditVIN.Location = new System.Drawing.Point(99, 140);
            this.textEditVIN.Name = "textEditVIN";
            this.textEditVIN.ReadOnly = true;
            this.textEditVIN.Size = new System.Drawing.Size(320, 20);
            this.textEditVIN.TabIndex = 62;
            // 
            // textEditНомерКузова
            // 
            this.textEditНомерКузова.Location = new System.Drawing.Point(99, 166);
            this.textEditНомерКузова.Name = "textEditНомерКузова";
            this.textEditНомерКузова.ReadOnly = true;
            this.textEditНомерКузова.Size = new System.Drawing.Size(320, 20);
            this.textEditНомерКузова.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Номер кузова:";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "VIN номер:";
            // 
            // comboBoxСтатусЗаказа
            // 
            this.comboBoxСтатусЗаказа.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxСтатусЗаказа.Location = new System.Drawing.Point(99, 221);
            this.comboBoxСтатусЗаказа.Name = "comboBoxСтатусЗаказа";
            this.comboBoxСтатусЗаказа.Size = new System.Drawing.Size(146, 21);
            this.comboBoxСтатусЗаказа.TabIndex = 58;
            // 
            // labelControl12
            // 
            this.labelControl12.AutoEllipsis = true;
            this.labelControl12.AutoSize = true;
            this.labelControl12.Location = new System.Drawing.Point(12, 196);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(61, 13);
            this.labelControl12.TabIndex = 56;
            this.labelControl12.Text = "Цвет авто:";
            // 
            // labelControl6
            // 
            this.labelControl6.AutoEllipsis = true;
            this.labelControl6.AutoSize = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 224);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(83, 13);
            this.labelControl6.TabIndex = 57;
            this.labelControl6.Text = "Статус заказа:";
            this.labelControl6.Visible = false;
            // 
            // tabPageКлиент
            // 
            this.tabPageКлиент.Controls.Add(this.buttonСоздатьКлиента);
            this.tabPageКлиент.Controls.Add(this.buttonНайтиКлиента);
            this.tabPageКлиент.Controls.Add(this.panel1);
            this.tabPageКлиент.Location = new System.Drawing.Point(4, 22);
            this.tabPageКлиент.Name = "tabPageКлиент";
            this.tabPageКлиент.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageКлиент.Size = new System.Drawing.Size(774, 291);
            this.tabPageКлиент.TabIndex = 1;
            this.tabPageКлиент.Text = "Данные клиента";
            this.tabPageКлиент.UseVisualStyleBackColor = true;
            // 
            // buttonСоздатьКлиента
            // 
            this.buttonСоздатьКлиента.Location = new System.Drawing.Point(111, 6);
            this.buttonСоздатьКлиента.Name = "buttonСоздатьКлиента";
            this.buttonСоздатьКлиента.Size = new System.Drawing.Size(116, 23);
            this.buttonСоздатьКлиента.TabIndex = 54;
            this.buttonСоздатьКлиента.Text = "Создать клиента";
            this.buttonСоздатьКлиента.UseVisualStyleBackColor = true;
            this.buttonСоздатьКлиента.Click += new System.EventHandler(this.buttonСоздатьКлиента_Click);
            // 
            // buttonНайтиКлиента
            // 
            this.buttonНайтиКлиента.Location = new System.Drawing.Point(6, 6);
            this.buttonНайтиКлиента.Name = "buttonНайтиКлиента";
            this.buttonНайтиКлиента.Size = new System.Drawing.Size(100, 23);
            this.buttonНайтиКлиента.TabIndex = 53;
            this.buttonНайтиКлиента.Text = "Найти клиента";
            this.buttonНайтиКлиента.UseVisualStyleBackColor = true;
            this.buttonНайтиКлиента.Click += new System.EventHandler(this.buttonНайтиКлиента_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.textBoxАдресРегистрации);
            this.panel1.Controls.Add(this.textEditФамилия);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.groupBoxПД);
            this.panel1.Controls.Add(this.textEditИмя);
            this.panel1.Controls.Add(this.textEditEmail);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.textEditОтчество);
            this.panel1.Controls.Add(this.textEditТелефон);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(6, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 226);
            this.panel1.TabIndex = 51;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSize = true;
            this.labelControl2.Location = new System.Drawing.Point(22, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 38;
            this.labelControl2.Text = "Фамилия:";
            this.labelControl2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxАдресРегистрации
            // 
            this.textBoxАдресРегистрации.Location = new System.Drawing.Point(7, 164);
            this.textBoxАдресРегистрации.Multiline = true;
            this.textBoxАдресРегистрации.Name = "textBoxАдресРегистрации";
            this.textBoxАдресРегистрации.Size = new System.Drawing.Size(298, 44);
            this.textBoxАдресРегистрации.TabIndex = 50;
            this.textBoxАдресРегистрации.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditФамилия_KeyPress);
            // 
            // textEditФамилия
            // 
            this.textEditФамилия.Location = new System.Drawing.Point(87, 9);
            this.textEditФамилия.Name = "textEditФамилия";
            this.textEditФамилия.Size = new System.Drawing.Size(218, 20);
            this.textEditФамилия.TabIndex = 39;
            this.textEditФамилия.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditФамилия_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Адрес регистрации:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(49, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Имя:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBoxПД
            // 
            this.groupBoxПД.Controls.Add(this.label8);
            this.groupBoxПД.Controls.Add(this.textBoxПДКемВыдан);
            this.groupBoxПД.Controls.Add(this.label9);
            this.groupBoxПД.Controls.Add(this.TextBoxПДДатаВыдачи);
            this.groupBoxПД.Controls.Add(this.label10);
            this.groupBoxПД.Controls.Add(this.TextBoxПДНомер);
            this.groupBoxПД.Controls.Add(this.label11);
            this.groupBoxПД.Controls.Add(this.TextBoxПДСерия);
            this.groupBoxПД.Controls.Add(this.dateEditДатаРождения);
            this.groupBoxПД.Controls.Add(this.label12);
            this.groupBoxПД.Controls.Add(this.memoExEditПол);
            this.groupBoxПД.Controls.Add(this.label13);
            this.groupBoxПД.Controls.Add(this.label14);
            this.groupBoxПД.Controls.Add(this.TextBoxПДКодПодразделения);
            this.groupBoxПД.Location = new System.Drawing.Point(322, 9);
            this.groupBoxПД.Name = "groupBoxПД";
            this.groupBoxПД.Size = new System.Drawing.Size(428, 199);
            this.groupBoxПД.TabIndex = 48;
            this.groupBoxПД.TabStop = false;
            this.groupBoxПД.Text = "Паспортные данные";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Пол:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxПДКемВыдан
            // 
            this.textBoxПДКемВыдан.Location = new System.Drawing.Point(95, 137);
            this.textBoxПДКемВыдан.Multiline = true;
            this.textBoxПДКемВыдан.Name = "textBoxПДКемВыдан";
            this.textBoxПДКемВыдан.Size = new System.Drawing.Size(311, 45);
            this.textBoxПДКемВыдан.TabIndex = 36;
            this.textBoxПДКемВыдан.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditФамилия_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Дата выдачи:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxПДДатаВыдачи
            // 
            this.TextBoxПДДатаВыдачи.Enabled = false;
            this.TextBoxПДДатаВыдачи.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TextBoxПДДатаВыдачи.Location = new System.Drawing.Point(301, 61);
            this.TextBoxПДДатаВыдачи.Name = "TextBoxПДДатаВыдачи";
            this.TextBoxПДДатаВыдачи.Size = new System.Drawing.Size(105, 20);
            this.TextBoxПДДатаВыдачи.TabIndex = 31;
            this.TextBoxПДДатаВыдачи.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditФамилия_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Кем выдан:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxПДНомер
            // 
            this.TextBoxПДНомер.Location = new System.Drawing.Point(202, 22);
            this.TextBoxПДНомер.Mask = "000000";
            this.TextBoxПДНомер.Name = "TextBoxПДНомер";
            this.TextBoxПДНомер.Size = new System.Drawing.Size(74, 20);
            this.TextBoxПДНомер.TabIndex = 34;
            this.TextBoxПДНомер.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditФамилия_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Дата рождения:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxПДСерия
            // 
            this.TextBoxПДСерия.Location = new System.Drawing.Point(70, 22);
            this.TextBoxПДСерия.Mask = "0000";
            this.TextBoxПДСерия.Name = "TextBoxПДСерия";
            this.TextBoxПДСерия.Size = new System.Drawing.Size(74, 20);
            this.TextBoxПДСерия.TabIndex = 33;
            this.TextBoxПДСерия.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditФамилия_KeyPress);
            // 
            // dateEditДатаРождения
            // 
            this.dateEditДатаРождения.Enabled = false;
            this.dateEditДатаРождения.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEditДатаРождения.Location = new System.Drawing.Point(118, 100);
            this.dateEditДатаРождения.Name = "dateEditДатаРождения";
            this.dateEditДатаРождения.Size = new System.Drawing.Size(105, 20);
            this.dateEditДатаРождения.TabIndex = 27;
            this.dateEditДатаРождения.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditФамилия_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(152, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Номер:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // memoExEditПол
            // 
            this.memoExEditПол.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.memoExEditПол.Location = new System.Drawing.Point(277, 99);
            this.memoExEditПол.Name = "memoExEditПол";
            this.memoExEditПол.Size = new System.Drawing.Size(129, 21);
            this.memoExEditПол.TabIndex = 28;
            this.memoExEditПол.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditФамилия_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Серия:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Код подразделения:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxПДКодПодразделения
            // 
            this.TextBoxПДКодПодразделения.Location = new System.Drawing.Point(139, 61);
            this.TextBoxПДКодПодразделения.Mask = "000-000";
            this.TextBoxПДКодПодразделения.Name = "TextBoxПДКодПодразделения";
            this.TextBoxПДКодПодразделения.Size = new System.Drawing.Size(74, 20);
            this.TextBoxПДКодПодразделения.TabIndex = 0;
            this.TextBoxПДКодПодразделения.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditФамилия_KeyPress);
            // 
            // textEditИмя
            // 
            this.textEditИмя.Location = new System.Drawing.Point(87, 35);
            this.textEditИмя.Name = "textEditИмя";
            this.textEditИмя.Size = new System.Drawing.Size(218, 20);
            this.textEditИмя.TabIndex = 41;
            this.textEditИмя.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditФамилия_KeyPress);
            // 
            // textEditEmail
            // 
            this.textEditEmail.Location = new System.Drawing.Point(87, 119);
            this.textEditEmail.Name = "textEditEmail";
            this.textEditEmail.Size = new System.Drawing.Size(218, 20);
            this.textEditEmail.TabIndex = 47;
            this.textEditEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditФамилия_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Отчество:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Email:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textEditОтчество
            // 
            this.textEditОтчество.Location = new System.Drawing.Point(87, 61);
            this.textEditОтчество.Name = "textEditОтчество";
            this.textEditОтчество.Size = new System.Drawing.Size(218, 20);
            this.textEditОтчество.TabIndex = 43;
            this.textEditОтчество.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditФамилия_KeyPress);
            // 
            // textEditТелефон
            // 
            this.textEditТелефон.Location = new System.Drawing.Point(87, 93);
            this.textEditТелефон.Name = "textEditТелефон";
            this.textEditТелефон.Size = new System.Drawing.Size(218, 20);
            this.textEditТелефон.TabIndex = 45;
            this.textEditТелефон.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditФамилия_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoEllipsis = true;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Телефон:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // simpleButtonСохранить
            // 
            this.simpleButtonСохранить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonСохранить.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonСохранить.Image = global::AutoSalon.Properties.Resources.Action_Inline_Save;
            this.simpleButtonСохранить.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.simpleButtonСохранить.Location = new System.Drawing.Point(555, 343);
            this.simpleButtonСохранить.Name = "simpleButtonСохранить";
            this.simpleButtonСохранить.Size = new System.Drawing.Size(109, 23);
            this.simpleButtonСохранить.TabIndex = 32;
            this.simpleButtonСохранить.Text = "Сохранить";
            this.simpleButtonСохранить.Click += new System.EventHandler(this.simpleButtonСохранить_Click);
            // 
            // simpleButtonОтменить
            // 
            this.simpleButtonОтменить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonОтменить.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonОтменить.Image = global::AutoSalon.Properties.Resources.Action_Cancel;
            this.simpleButtonОтменить.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.simpleButtonОтменить.Location = new System.Drawing.Point(670, 343);
            this.simpleButtonОтменить.Name = "simpleButtonОтменить";
            this.simpleButtonОтменить.Size = new System.Drawing.Size(104, 23);
            this.simpleButtonОтменить.TabIndex = 33;
            this.simpleButtonОтменить.Text = "Отменить";
            // 
            // labelНомерЗаказа
            // 
            this.labelНомерЗаказа.AutoEllipsis = true;
            this.labelНомерЗаказа.AutoSize = true;
            this.labelНомерЗаказа.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelНомерЗаказа.Location = new System.Drawing.Point(9, 356);
            this.labelНомерЗаказа.Name = "labelНомерЗаказа";
            this.labelНомерЗаказа.Size = new System.Drawing.Size(0, 16);
            this.labelНомерЗаказа.TabIndex = 71;
            // 
            // checkBoxСформироватьГрафикТО
            // 
            this.checkBoxСформироватьГрафикТО.Location = new System.Drawing.Point(427, 260);
            this.checkBoxСформироватьГрафикТО.Name = "checkBoxСформироватьГрафикТО";
            this.checkBoxСформироватьГрафикТО.Size = new System.Drawing.Size(334, 24);
            this.checkBoxСформироватьГрафикТО.TabIndex = 71;
            this.checkBoxСформироватьГрафикТО.Text = "Сформировать график технического обслуживания";
            this.checkBoxСформироватьГрафикТО.UseVisualStyleBackColor = true;
            // 
            // dlgEditОформитьЗаказ
            // 
            this.AcceptButton = this.simpleButtonСохранить;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonОтменить;
            this.ClientSize = new System.Drawing.Size(786, 378);
            this.Controls.Add(this.labelНомерЗаказа);
            this.Controls.Add(this.simpleButtonОтменить);
            this.Controls.Add(this.simpleButtonСохранить);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "dlgEditОформитьЗаказ";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "dlgEditОформитьЗаказ";
            this.tabControl1.ResumeLayout(false);
            this.tabPageТовар.ResumeLayout(false);
            this.tabPageТовар.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageКлиент.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxПД.ResumeLayout(false);
            this.groupBoxПД.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPageТовар;
    private System.Windows.Forms.TabPage tabPageКлиент;
    private System.Windows.Forms.Button simpleButtonОтменить;
    private System.Windows.Forms.Button simpleButtonСохранить;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label labelControl1;
    private System.Windows.Forms.ComboBox comboBoxПоколение;
    private System.Windows.Forms.ComboBox comboBoxМодель;
    private System.Windows.Forms.Label labelControl5;
    private System.Windows.Forms.Label labelControl3;
    private System.Windows.Forms.ComboBox comboBoxМарка;
    private System.Windows.Forms.Label labelColor;
    private System.Windows.Forms.TextBox textEditСтоимость;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textEditVIN;
    private System.Windows.Forms.TextBox textEditНомерКузова;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labelControl12;
    private System.Windows.Forms.ComboBox comboBoxСтатусЗаказа;
    private System.Windows.Forms.Label labelControl6;
    private System.Windows.Forms.TextBox textBoxОплачено;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox comboBoxМощностьДвигателя;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox comboBoxОбъемДвигателя;
    private System.Windows.Forms.Label labelControl7;
    private System.Windows.Forms.Label labelControl8;
    private System.Windows.Forms.Label labelControl10;
    private System.Windows.Forms.Label labelControl11;
    private System.Windows.Forms.Label labelControl13;
    private System.Windows.Forms.Label labelControl14;
    private System.Windows.Forms.ComboBox comboBoxТипТоплива;
    private System.Windows.Forms.ComboBox comboBoxТипПривода;
    private System.Windows.Forms.ComboBox comboBoxТипРуля;
    private System.Windows.Forms.ComboBox comboBoxТипКПП;
    private System.Windows.Forms.TextBox textEditГодВыпуска;
    private System.Windows.Forms.TextBox textEditПробег;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label labelControl2;
    private System.Windows.Forms.TextBox textBoxАдресРегистрации;
    private System.Windows.Forms.TextBox textEditФамилия;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.GroupBox groupBoxПД;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBoxПДКемВыдан;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.DateTimePicker TextBoxПДДатаВыдачи;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.MaskedTextBox TextBoxПДНомер;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.MaskedTextBox TextBoxПДСерия;
    private System.Windows.Forms.DateTimePicker dateEditДатаРождения;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.ComboBox memoExEditПол;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.MaskedTextBox TextBoxПДКодПодразделения;
    private System.Windows.Forms.TextBox textEditИмя;
    private System.Windows.Forms.TextBox textEditEmail;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.TextBox textEditОтчество;
    private System.Windows.Forms.TextBox textEditТелефон;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Button buttonСоздатьКлиента;
    private System.Windows.Forms.Button buttonНайтиКлиента;
    private System.Windows.Forms.Label labelНомерЗаказа;
    private System.Windows.Forms.CheckBox checkBoxСформироватьГрафикТО;
}
