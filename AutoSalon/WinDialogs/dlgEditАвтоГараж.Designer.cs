partial class dlgEditАвтоГараж
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
            this.simpleButtonОтменить = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonСохранить = new DevExpress.XtraEditors.SimpleButton();
            this.textEditЦветАвто = new DevExpress.XtraEditors.ColorPickEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditСтатусТовара = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditТипТоплива = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditТипПривода = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditТипКузова = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditТипРуля = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditТипКПП = new DevExpress.XtraEditors.LookUpEdit();
            this.textEditГодВыпуска = new DevExpress.XtraEditors.TextEdit();
            this.textEditПробег = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditМарка = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditМодель = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditПоколение = new DevExpress.XtraEditors.LookUpEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.textEditЦветАвто.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditСтатусТовара.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditТипТоплива.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditТипПривода.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditТипКузова.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditТипРуля.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditТипКПП.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditГодВыпуска.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditПробег.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditМарка.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditМодель.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditПоколение.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButtonОтменить
            // 
            this.simpleButtonОтменить.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonОтменить.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonОтменить.ImageOptions.Image = global::AutoSalon.Properties.Resources.Action_Cancel;
            this.simpleButtonОтменить.Location = new System.Drawing.Point(580, 389);
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
            this.simpleButtonСохранить.Location = new System.Drawing.Point(465, 389);
            this.simpleButtonСохранить.Name = "simpleButtonСохранить";
            this.simpleButtonСохранить.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonСохранить.Size = new System.Drawing.Size(109, 23);
            this.simpleButtonСохранить.TabIndex = 18;
            this.simpleButtonСохранить.Text = "Сохранить";
            this.simpleButtonСохранить.Click += new System.EventHandler(this.simpleButtonСохранить_Click);
            // 
            // textEditЦветАвто
            // 
            this.tablePanel1.SetColumn(this.textEditЦветАвто, 2);
            this.textEditЦветАвто.EditValue = System.Drawing.Color.Empty;
            this.textEditЦветАвто.Location = new System.Drawing.Point(136, 311);
            this.textEditЦветАвто.Name = "textEditЦветАвто";
            this.textEditЦветАвто.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.textEditЦветАвто.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.textEditЦветАвто.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEditЦветАвто.Properties.NullValuePrompt = "Выберите цвет авто ...";
            this.tablePanel1.SetRow(this.textEditЦветАвто, 9);
            this.textEditЦветАвто.Size = new System.Drawing.Size(531, 20);
            this.textEditЦветАвто.TabIndex = 40;
            // 
            // labelControl6
            // 
            this.tablePanel1.SetColumn(this.labelControl6, 1);
            this.labelControl6.Location = new System.Drawing.Point(24, 129);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel1.SetRow(this.labelControl6, 2);
            this.labelControl6.Size = new System.Drawing.Size(79, 13);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Статус товара:";
            // 
            // labelControl7
            // 
            this.tablePanel1.SetColumn(this.labelControl7, 1);
            this.labelControl7.Location = new System.Drawing.Point(24, 155);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel1.SetRow(this.labelControl7, 3);
            this.labelControl7.Size = new System.Drawing.Size(67, 13);
            this.labelControl7.TabIndex = 26;
            this.labelControl7.Text = "Тип топлива:";
            // 
            // labelControl8
            // 
            this.tablePanel1.SetColumn(this.labelControl8, 1);
            this.labelControl8.Location = new System.Drawing.Point(24, 181);
            this.labelControl8.Name = "labelControl8";
            this.tablePanel1.SetRow(this.labelControl8, 4);
            this.labelControl8.Size = new System.Drawing.Size(68, 13);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Тип привода:";
            // 
            // labelControl9
            // 
            this.tablePanel1.SetColumn(this.labelControl9, 1);
            this.labelControl9.Location = new System.Drawing.Point(24, 207);
            this.labelControl9.Name = "labelControl9";
            this.tablePanel1.SetRow(this.labelControl9, 5);
            this.labelControl9.Size = new System.Drawing.Size(60, 13);
            this.labelControl9.TabIndex = 28;
            this.labelControl9.Text = "Тип кузова:";
            // 
            // labelControl10
            // 
            this.tablePanel1.SetColumn(this.labelControl10, 1);
            this.labelControl10.Location = new System.Drawing.Point(24, 233);
            this.labelControl10.Name = "labelControl10";
            this.tablePanel1.SetRow(this.labelControl10, 6);
            this.labelControl10.Size = new System.Drawing.Size(49, 13);
            this.labelControl10.TabIndex = 29;
            this.labelControl10.Text = "Тип руля:";
            // 
            // labelControl11
            // 
            this.tablePanel1.SetColumn(this.labelControl11, 1);
            this.labelControl11.Location = new System.Drawing.Point(24, 285);
            this.labelControl11.Name = "labelControl11";
            this.tablePanel1.SetRow(this.labelControl11, 8);
            this.labelControl11.Size = new System.Drawing.Size(69, 13);
            this.labelControl11.TabIndex = 30;
            this.labelControl11.Text = "Год выпуска:";
            // 
            // labelControl12
            // 
            this.tablePanel1.SetColumn(this.labelControl12, 1);
            this.labelControl12.Location = new System.Drawing.Point(24, 311);
            this.labelControl12.Name = "labelControl12";
            this.tablePanel1.SetRow(this.labelControl12, 9);
            this.labelControl12.Size = new System.Drawing.Size(57, 13);
            this.labelControl12.TabIndex = 24;
            this.labelControl12.Text = "Цвет авто:";
            // 
            // labelControl13
            // 
            this.tablePanel1.SetColumn(this.labelControl13, 1);
            this.labelControl13.Location = new System.Drawing.Point(24, 337);
            this.labelControl13.Name = "labelControl13";
            this.tablePanel1.SetRow(this.labelControl13, 10);
            this.labelControl13.Size = new System.Drawing.Size(40, 13);
            this.labelControl13.TabIndex = 24;
            this.labelControl13.Text = "Пробег:";
            // 
            // labelControl14
            // 
            this.tablePanel1.SetColumn(this.labelControl14, 1);
            this.labelControl14.Location = new System.Drawing.Point(24, 259);
            this.labelControl14.Name = "labelControl14";
            this.tablePanel1.SetRow(this.labelControl14, 7);
            this.labelControl14.Size = new System.Drawing.Size(46, 13);
            this.labelControl14.TabIndex = 31;
            this.labelControl14.Text = "Тип КПП:";
            // 
            // lookUpEditСтатусТовара
            // 
            this.tablePanel1.SetColumn(this.lookUpEditСтатусТовара, 2);
            this.lookUpEditСтатусТовара.Location = new System.Drawing.Point(136, 129);
            this.lookUpEditСтатусТовара.Name = "lookUpEditСтатусТовара";
            this.lookUpEditСтатусТовара.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditСтатусТовара.Properties.NullText = "";
            this.lookUpEditСтатусТовара.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEditСтатусТовара.Properties.ShowHeader = false;
            this.lookUpEditСтатусТовара.Properties.ShowLines = false;
            this.tablePanel1.SetRow(this.lookUpEditСтатусТовара, 2);
            this.lookUpEditСтатусТовара.Size = new System.Drawing.Size(531, 20);
            this.lookUpEditСтатусТовара.TabIndex = 34;
            // 
            // lookUpEditТипТоплива
            // 
            this.tablePanel1.SetColumn(this.lookUpEditТипТоплива, 2);
            this.lookUpEditТипТоплива.Location = new System.Drawing.Point(136, 155);
            this.lookUpEditТипТоплива.Name = "lookUpEditТипТоплива";
            this.lookUpEditТипТоплива.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditТипТоплива.Properties.NullText = "";
            this.lookUpEditТипТоплива.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEditТипТоплива.Properties.ShowHeader = false;
            this.lookUpEditТипТоплива.Properties.ShowLines = false;
            this.tablePanel1.SetRow(this.lookUpEditТипТоплива, 3);
            this.lookUpEditТипТоплива.Size = new System.Drawing.Size(531, 20);
            this.lookUpEditТипТоплива.TabIndex = 35;
            // 
            // lookUpEditТипПривода
            // 
            this.tablePanel1.SetColumn(this.lookUpEditТипПривода, 2);
            this.lookUpEditТипПривода.Location = new System.Drawing.Point(136, 181);
            this.lookUpEditТипПривода.Name = "lookUpEditТипПривода";
            this.lookUpEditТипПривода.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditТипПривода.Properties.NullText = "";
            this.lookUpEditТипПривода.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEditТипПривода.Properties.ShowHeader = false;
            this.lookUpEditТипПривода.Properties.ShowLines = false;
            this.tablePanel1.SetRow(this.lookUpEditТипПривода, 4);
            this.lookUpEditТипПривода.Size = new System.Drawing.Size(531, 20);
            this.lookUpEditТипПривода.TabIndex = 36;
            // 
            // lookUpEditТипКузова
            // 
            this.tablePanel1.SetColumn(this.lookUpEditТипКузова, 2);
            this.lookUpEditТипКузова.Location = new System.Drawing.Point(136, 207);
            this.lookUpEditТипКузова.Name = "lookUpEditТипКузова";
            this.lookUpEditТипКузова.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditТипКузова.Properties.NullText = "";
            this.lookUpEditТипКузова.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEditТипКузова.Properties.ShowHeader = false;
            this.lookUpEditТипКузова.Properties.ShowLines = false;
            this.tablePanel1.SetRow(this.lookUpEditТипКузова, 5);
            this.lookUpEditТипКузова.Size = new System.Drawing.Size(531, 20);
            this.lookUpEditТипКузова.TabIndex = 37;
            // 
            // lookUpEditТипРуля
            // 
            this.tablePanel1.SetColumn(this.lookUpEditТипРуля, 2);
            this.lookUpEditТипРуля.Location = new System.Drawing.Point(136, 233);
            this.lookUpEditТипРуля.Name = "lookUpEditТипРуля";
            this.lookUpEditТипРуля.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditТипРуля.Properties.NullText = "";
            this.lookUpEditТипРуля.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEditТипРуля.Properties.ShowHeader = false;
            this.lookUpEditТипРуля.Properties.ShowLines = false;
            this.tablePanel1.SetRow(this.lookUpEditТипРуля, 6);
            this.lookUpEditТипРуля.Size = new System.Drawing.Size(531, 20);
            this.lookUpEditТипРуля.TabIndex = 38;
            // 
            // lookUpEditТипКПП
            // 
            this.tablePanel1.SetColumn(this.lookUpEditТипКПП, 2);
            this.lookUpEditТипКПП.Location = new System.Drawing.Point(136, 259);
            this.lookUpEditТипКПП.Name = "lookUpEditТипКПП";
            this.lookUpEditТипКПП.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditТипКПП.Properties.NullText = "";
            this.lookUpEditТипКПП.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEditТипКПП.Properties.ShowHeader = false;
            this.lookUpEditТипКПП.Properties.ShowLines = false;
            this.tablePanel1.SetRow(this.lookUpEditТипКПП, 7);
            this.lookUpEditТипКПП.Size = new System.Drawing.Size(531, 20);
            this.lookUpEditТипКПП.TabIndex = 39;
            // 
            // textEditГодВыпуска
            // 
            this.tablePanel1.SetColumn(this.textEditГодВыпуска, 2);
            this.textEditГодВыпуска.Location = new System.Drawing.Point(136, 285);
            this.textEditГодВыпуска.Name = "textEditГодВыпуска";
            this.textEditГодВыпуска.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.textEditГодВыпуска.Properties.Mask.EditMask = "[1-2][9-0]\\d\\d";
            this.textEditГодВыпуска.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditГодВыпуска.Properties.Mask.SaveLiteral = false;
            this.tablePanel1.SetRow(this.textEditГодВыпуска, 8);
            this.textEditГодВыпуска.Size = new System.Drawing.Size(531, 20);
            this.textEditГодВыпуска.TabIndex = 27;
            // 
            // textEditПробег
            // 
            this.tablePanel1.SetColumn(this.textEditПробег, 2);
            this.textEditПробег.Location = new System.Drawing.Point(136, 337);
            this.textEditПробег.Name = "textEditПробег";
            this.textEditПробег.Properties.Mask.EditMask = "n0";
            this.textEditПробег.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.textEditПробег, 10);
            this.textEditПробег.Size = new System.Drawing.Size(531, 20);
            this.textEditПробег.TabIndex = 24;
            // 
            // groupControl1
            // 
            this.tablePanel1.SetColumn(this.groupControl1, 1);
            this.tablePanel1.SetColumnSpan(this.groupControl1, 2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lookUpEditМарка);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lookUpEditМодель);
            this.groupControl1.Controls.Add(this.lookUpEditПоколение);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(24, 23);
            this.groupControl1.Name = "groupControl1";
            this.tablePanel1.SetRow(this.groupControl1, 1);
            this.groupControl1.Size = new System.Drawing.Size(643, 100);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Автомобиль";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Марка авто:";
            // 
            // lookUpEditМарка
            // 
            this.lookUpEditМарка.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditМарка.Location = new System.Drawing.Point(112, 25);
            this.lookUpEditМарка.Name = "lookUpEditМарка";
            this.lookUpEditМарка.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditМарка.Properties.NullText = "";
            this.lookUpEditМарка.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEditМарка.Properties.ShowHeader = false;
            this.lookUpEditМарка.Properties.ShowLines = false;
            this.lookUpEditМарка.Size = new System.Drawing.Size(526, 20);
            this.lookUpEditМарка.TabIndex = 24;
            this.lookUpEditМарка.EditValueChanged += new System.EventHandler(this.lookUpEditМарка_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Модель авто:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 78);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(99, 13);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "Поколение модели:";
            // 
            // lookUpEditМодель
            // 
            this.lookUpEditМодель.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditМодель.Location = new System.Drawing.Point(112, 50);
            this.lookUpEditМодель.Name = "lookUpEditМодель";
            this.lookUpEditМодель.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditМодель.Properties.NullText = "";
            this.lookUpEditМодель.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEditМодель.Properties.ShowHeader = false;
            this.lookUpEditМодель.Properties.ShowLines = false;
            this.lookUpEditМодель.Size = new System.Drawing.Size(526, 20);
            this.lookUpEditМодель.TabIndex = 32;
            this.lookUpEditМодель.EditValueChanged += new System.EventHandler(this.lookUpEditМодель_EditValueChanged);
            // 
            // lookUpEditПоколение
            // 
            this.lookUpEditПоколение.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditПоколение.Location = new System.Drawing.Point(112, 75);
            this.lookUpEditПоколение.Name = "lookUpEditПоколение";
            this.lookUpEditПоколение.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditПоколение.Properties.NullText = "";
            this.lookUpEditПоколение.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEditПоколение.Properties.ShowHeader = false;
            this.lookUpEditПоколение.Properties.ShowLines = false;
            this.lookUpEditПоколение.Size = new System.Drawing.Size(526, 20);
            this.lookUpEditПоколение.TabIndex = 33;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 21F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 112.49F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 49.51F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 20F)});
            this.tablePanel1.Controls.Add(this.groupControl1);
            this.tablePanel1.Controls.Add(this.textEditПробег);
            this.tablePanel1.Controls.Add(this.textEditГодВыпуска);
            this.tablePanel1.Controls.Add(this.lookUpEditТипКПП);
            this.tablePanel1.Controls.Add(this.lookUpEditТипРуля);
            this.tablePanel1.Controls.Add(this.lookUpEditТипКузова);
            this.tablePanel1.Controls.Add(this.lookUpEditТипПривода);
            this.tablePanel1.Controls.Add(this.lookUpEditТипТоплива);
            this.tablePanel1.Controls.Add(this.lookUpEditСтатусТовара);
            this.tablePanel1.Controls.Add(this.labelControl14);
            this.tablePanel1.Controls.Add(this.labelControl13);
            this.tablePanel1.Controls.Add(this.labelControl12);
            this.tablePanel1.Controls.Add(this.labelControl11);
            this.tablePanel1.Controls.Add(this.labelControl10);
            this.tablePanel1.Controls.Add(this.labelControl9);
            this.tablePanel1.Controls.Add(this.labelControl8);
            this.tablePanel1.Controls.Add(this.labelControl7);
            this.tablePanel1.Controls.Add(this.labelControl6);
            this.tablePanel1.Controls.Add(this.textEditЦветАвто);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 27F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 20F)});
            this.tablePanel1.Size = new System.Drawing.Size(690, 374);
            this.tablePanel1.TabIndex = 22;
            // 
            // dlgEditАвтГараж
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 424);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.simpleButtonОтменить);
            this.Controls.Add(this.simpleButtonСохранить);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgEditАвтГараж";
            this.ShowInTaskbar = false;
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.dlgEditАвтоМарки_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditЦветАвто.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditСтатусТовара.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditТипТоплива.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditТипПривода.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditТипКузова.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditТипРуля.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditТипКПП.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditГодВыпуска.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditПробег.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditМарка.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditМодель.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditПоколение.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion
    private DevExpress.XtraEditors.SimpleButton simpleButtonОтменить;
    private DevExpress.XtraEditors.SimpleButton simpleButtonСохранить;
    private DevExpress.XtraEditors.ColorPickEdit textEditЦветАвто;
    private DevExpress.Utils.Layout.TablePanel tablePanel1;
    private DevExpress.XtraEditors.GroupControl groupControl1;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.LookUpEdit lookUpEditМарка;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.LabelControl labelControl5;
    private DevExpress.XtraEditors.LookUpEdit lookUpEditМодель;
    private DevExpress.XtraEditors.LookUpEdit lookUpEditПоколение;
    private DevExpress.XtraEditors.TextEdit textEditПробег;
    private DevExpress.XtraEditors.TextEdit textEditГодВыпуска;
    private DevExpress.XtraEditors.LookUpEdit lookUpEditТипКПП;
    private DevExpress.XtraEditors.LookUpEdit lookUpEditТипРуля;
    private DevExpress.XtraEditors.LookUpEdit lookUpEditТипКузова;
    private DevExpress.XtraEditors.LookUpEdit lookUpEditТипПривода;
    private DevExpress.XtraEditors.LookUpEdit lookUpEditТипТоплива;
    private DevExpress.XtraEditors.LookUpEdit lookUpEditСтатусТовара;
    private DevExpress.XtraEditors.LabelControl labelControl14;
    private DevExpress.XtraEditors.LabelControl labelControl13;
    private DevExpress.XtraEditors.LabelControl labelControl12;
    private DevExpress.XtraEditors.LabelControl labelControl11;
    private DevExpress.XtraEditors.LabelControl labelControl10;
    private DevExpress.XtraEditors.LabelControl labelControl9;
    private DevExpress.XtraEditors.LabelControl labelControl8;
    private DevExpress.XtraEditors.LabelControl labelControl7;
    private DevExpress.XtraEditors.LabelControl labelControl6;
}
