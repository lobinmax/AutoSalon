using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public partial class frГаражАвто : Form
{
    private string colorAuto = null;

    public frГаражАвто()
    {
        InitializeComponent();

        ЗаполнитьФильтры();
        ОбновитьГараж();

        colorDialog1.Color = this.BackColor;
    }

    private void frГаражАвто_Load(object sender, EventArgs e)
    {
        ASTimer timer = new ASTimer(gridViewГараж,
                                    new List<Button> { this.buttonИзменитьАвто, this.buttonУдалитьАвто }
                                    ) { Enabled = true };
    }

    void ОбновитьГараж(object value = null)
    {
        bool? СтранаИзготовитель = null;
        if (radioButtonОтечественные.Checked)
        {
            СтранаИзготовитель = false;
        }
        if (radioButtonИномарки.Checked)
        {
            СтранаИзготовитель = true;
        }

        var dt = clsSql.ExecuteSP("dbo.ГаражАвто_SIUD", clsMisc.ASSqlFunction.ViewForm,
            "@UIDМарки", clsMisc.DBin(comboBoxМарка.ASSelectedRow()["UID"]),
            "@UIDМодели", clsMisc.DBin(comboBoxМодель.ASSelectedRow()["UID"]),
            "@UIDПоколения", clsMisc.DBin(comboBoxПоколение.ASSelectedRow()["UID"]),
            "@Стоимость", clsMisc.DBin(textBoxЦенаОт.Text),
            "@СтоимостьДо", clsMisc.DBin(textBoxЦенаДо.Text),
            "@Пробег", clsMisc.DBin(textBoxПробегОт.Text),
            "@ПробегДо", clsMisc.DBin(textBoxПробегДо.Text),
            "@ГодВыпуска", clsMisc.DBin(textBoxВыпускОт.Text),
            "@ГодВыпускаДо", clsMisc.DBin(textBoxВыпускДо.Text),
            "@ОбъемДвигателя", clsMisc.DBin(textBoxОбъемОт.Text),
            "@ОбъемДвигателяДо", clsMisc.DBin(textBoxОбъемДо.Text),
            "@МощностьДвигателя", clsMisc.DBin(textBoxМощностьОт.Text),
            "@МощностьДвигателяДо", clsMisc.DBin(textBoxМощностьДо.Text),
            "@IdТипПривода", clsMisc.DBin(comboBoxТипПривода.ASSelectedRow()["Id"]),
            "@IdТипКузова", clsMisc.DBin(comboBoxТипКузова.ASSelectedRow()["Id"]),
            "@IdТипРуля", clsMisc.DBin(comboBoxТипРуля.ASSelectedRow()["Id"]),
            "@IdТипКПП", clsMisc.DBin(comboBoxТипКПП.ASSelectedRow()["Id"]),
            "@ЦветRGB", clsMisc.DBin(colorAuto),
            "@СтранаИзготовитель", clsMisc.DBin(СтранаИзготовитель),
            "@БезПробега", clsMisc.DBin((object)checkBoxБезПробега.Checked)).dataTable;
        gridViewГараж.ASОбновитьСохранитьВыделение(dt, "UIDТовара", value);

        gridViewГараж.ASНастроитьGridView(true, "UIDТовара", "UIDСтоимости");
        gridViewГараж.Columns["Цвет авто"].ValueType = typeof(Color);

    }

    private void simpleButtonОбновить_Click(object sender, EventArgs e) { ОбновитьГараж(); }

    void ОбновитьИсториюЦен()
    {
        var dr = gridViewГараж.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (dr == null)
        {
            gridViewИсторияЦены.DataSource = null;
            return;
        }

        var dt = clsSql.ExecuteSP("dbo.ГаражСтоимостьАвтоИстория",
                                  "@UIDТовара", dr.Cells["UIDТовара"].Value).dataTable;
        gridViewИсторияЦены.ASОбновитьСохранитьВыделение(dt, "UIDСтоимостиАвто", dr.Cells["UIDТовара"].Value);

        gridViewИсторияЦены.ASНастроитьGridView(true, "UIDСтоимостиАвто", "UIDТовара");
    }

    private void gridViewГараж_DataSourceChanged(object sender, EventArgs e) { ОбновитьИсториюЦен(); }

    private void gridViewГараж_SelectionChanged(object sender, EventArgs e) { ОбновитьИсториюЦен(); }

    private void gridViewИсторияЦены_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex == -1) return;
        var cell = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
        if (e.ColumnIndex == (sender as DataGridView).Columns["Цена"].Index)
        {
            cell.Style.Format = "C";
        }
    }

    #region Контекстное меню

    private void gridViewГараж_MouseClick(object sender, MouseEventArgs e)
    {
        var FocusDR = gridViewГараж.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        var menu = new ContextMenuStrip();

        if (FocusDR != null && e.Button == MouseButtons.Right)
        {
            menu.Items.Add("Оформить заказ", AutoSalon.Properties.Resources.Contact_16x16, ОформитьЗаказ);
            menu.Items.Add(new ToolStripSeparator());
        } 
        
        e.МенюДляAddEditDelete(menu, (DataGridView)sender, ДобавитьТовар, РедактироватьТовар, УдалитьТовар);

    }
    
    void ДобавитьТовар(object sender, EventArgs e)
    {
        using (var dlgEditАвтГараж = new dlgEditАвтоГараж(null, clsMisc.ASSqlFunction.Insert))
        {
            var result = dlgEditАвтГараж.ShowDialog();
            if (result == DialogResult.OK)
            {
                ОбновитьГараж(dlgEditАвтГараж.NewRecord);
            }
        }
    }
    private void simpleButtonДобавить_Click(object sender, EventArgs e) { ДобавитьТовар(sender, e); }

    void РедактироватьТовар(object sender, EventArgs e)
    {
        using (var dlgEditАвтГараж = new dlgEditАвтоГараж((Guid) gridViewГараж["UIDТовара", gridViewГараж.CurrentRow.Index].Value,
                                                         clsMisc.ASSqlFunction.Update))
        {
            var result = dlgEditАвтГараж.ShowDialog();
            if (result == DialogResult.OK)
            {
                ОбновитьГараж(dlgEditАвтГараж.NewRecord);
            }
        }
    }
    private void simpleButtonИзменить_Click(object sender, EventArgs e) { РедактироватьТовар(sender, e); }
    
    void УдалитьТовар(object sender, EventArgs e)
    {
        if (MessageBox.Show("Вы уверены что хотите удалить запись?",
                                                        Program.ProductName,
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question) == DialogResult.Yes)
        {
            clsSql.ExecuteSPNonQuery("dbo.ГаражАвто_SIUD",
                                      clsMisc.ASSqlFunction.Delete, "@UIDТовара",
                                      clsMisc.DBin(gridViewГараж["UIDТовара", gridViewГараж.CurrentRow.Index].Value));
            ОбновитьГараж();
        }
    }
    private void simpleButtonУдалить_Click(object sender, EventArgs e) { УдалитьТовар(sender, e); }

    void ОформитьЗаказ(object sender, EventArgs e)
    {
        var FocusDR = gridViewГараж.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        using (var dlgEditЗаказ = new dlgEditОформитьЗаказ((Guid)FocusDR.Cells["UIDТовара"].Value))
        {
            if(dlgEditЗаказ.ShowDialog() == DialogResult.OK)
            {
                ОбновитьГараж();
            }
        }
    }

    #endregion

    #region Фильтры

    private void ЗаполнитьФильтры()
    {
        comboBoxМарка.ASНастроитьВыпадалку_SP("СписокФильтров_МаркиАвто", "UID", "Name");

        textBoxЦенаОт.Text = "0";
        textBoxЦенаДо.Text = "10000000";
        textBoxПробегОт.Text = "0";
        textBoxПробегДо.Text = "1000000";
        textBoxВыпускОт.Text = "1950";
        textBoxВыпускДо.Text = DateTime.Now.Year.ToString();
        textBoxОбъемОт.Text = "0.0";
        textBoxОбъемДо.Text = "10.0";
        textBoxМощностьОт.Text = "30";
        textBoxМощностьДо.Text = "600";

        comboBoxТипТоплива.ASНастроитьВыпадалку_SP("СписокФильтров_ТипТоплива", "Id", "Name");
        comboBoxТипПривода.ASНастроитьВыпадалку_SP("СписокФильтров_ТипПривода", "Id", "Name");
        comboBoxТипКузова.ASНастроитьВыпадалку_SP("СписокФильтров_ТипКузова", "Id", "Name");
        comboBoxТипРуля.ASНастроитьВыпадалку_SP("СписокФильтров_ТипРуля", "Id", "Name");
        comboBoxТипКПП.ASНастроитьВыпадалку_SP("СписокФильтров_ТипКПП", "Id", "Name");

        radioButtonЛюбая.Checked = true;
        labelColor.BackColor = SystemColors.Control;
        colorAuto = null;
        checkBoxБезПробега.Checked = false;
    }

    private void buttonОчиститьФильтры_Click(object sender, EventArgs e)
    {
        ЗаполнитьФильтры();
        buttonПрименитьФильтр.PerformClick();
    }

    private void comboBoxМарка_SelectedValueChanged(object sender, EventArgs e)
    {
        comboBoxМодель.ASНастроитьВыпадалку_SP
        (
            "СписокФильтров_МоделиАвто",
            "UID",
            "Name",
            0,
            "@Все",
            0,
            "@UIDМарки",
            clsMisc.DBin(comboBoxМарка.ASSelectedRow()["UID"])
        );
    }

    private void comboBoxМодель_SelectedIndexChanged(object sender, EventArgs e)
    {
        comboBoxПоколение.ASНастроитьВыпадалку_SP
        (
            "СписокФильтров_ПоколенияАвто",
            "UID",
            "Name",
            0,
            "@Все",
            0,
            "@UIDМарки",
            clsMisc.DBin(comboBoxМарка.ASSelectedRow()["UID"]),
            "@UIDМодели",
            clsMisc.DBin(comboBoxМодель.ASSelectedRow()["UID"])
        );
    }

    private void buttonПрименитьФильтр_Click(object sender, EventArgs e)
    {
        ОбновитьГараж();
    }

    // обозначить цвет авто
    private void gridViewГараж_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex == -1) return;
        var cell = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
        var colNameЦвет = (sender as DataGridView).Columns["Цвет авто"].Index;
        var colNameЦена = (sender as DataGridView).Columns["Цена"].Index;
        if (e.ColumnIndex == colNameЦвет)
        {
            var cellColor = Color.FromArgb(Convert.ToInt32(cell.Value.ToString()));
            cell.Style.BackColor = cellColor;
            cell.Style.SelectionBackColor = cellColor;
            cell.Style.ForeColor = cellColor;
            cell.Style.SelectionForeColor = cellColor;

            return;
        }
        if (e.ColumnIndex == colNameЦена)
        {
            cell.Style.Format = "C";
        }
    }

    private void labelColor_BackColorChanged(object sender, EventArgs e)
    {
        colorAuto = labelColor.BackColor.ToArgb().ToString();
    }

    private void buttonСброситьЦвет_Click(object sender, EventArgs e)
    {
        colorAuto = null;
        labelColor.BackColor = SystemColors.Control;
    }

    private void buttonОчистить_Click(object sender, EventArgs e)
    {
        var controlName = (string)((Button)sender).Tag; // имя контрола который нужно очистить
        var controlNameArr = controlName.Split(';');

        foreach (var c in controlNameArr)
        {
            var control = this.Controls.Find(c, true).SingleOrDefault();
            if (control == null) { return; }

            if (control.GetType() == typeof(ComboBox))
            {
                var comboBox = (ComboBox)control;
                if (comboBox.Items.Count != 0)
                {
                    comboBox.SelectedIndex = 0;
                }
                else
                {
                    comboBox.ResetText();
                }
            }

            if (control.GetType() == typeof(TextBox))
            {
                if (control.Name.StartsWith("textBoxЦена"))
                {
                    if (control.Name.EndsWith("До"))
                    {
                        control.Text = "10000000";
                    }
                    else
                    {
                        control.Text = "0";
                    }
                }
                if (control.Name.StartsWith("textBoxПробег"))
                {
                    if (control.Name.EndsWith("До"))
                    {
                        control.Text = "1000000";
                    }
                    else
                    {
                        control.Text = "0";
                    }
                }
                if (control.Name.StartsWith("textBoxВыпуск"))
                {
                    if (control.Name.EndsWith("До"))
                    {
                        control.Text = DateTime.Now.Year.ToString();
                    }
                    else
                    {
                        control.Text = "1950";
                    }
                }
                if (control.Name.StartsWith("textBoxОбъем"))
                {
                    if (control.Name.EndsWith("До"))
                    {
                        control.Text = "10.0";
                    }
                    else
                    {
                        control.Text = "0.0";
                    }
                }
                if (control.Name.StartsWith("textBoxМощность"))
                {
                    if (control.Name.EndsWith("До"))
                    {
                        control.Text = "600";
                    }
                    else
                    {
                        control.Text = "30";
                    }
                }
            }
        }
    }

    private void simpleButtonColor_Click(object sender, EventArgs e)
    {
        if (colorDialog1.ShowDialog() == DialogResult.Cancel)
            return;
        labelColor.BackColor = colorDialog1.Color;
    }

    #endregion

}