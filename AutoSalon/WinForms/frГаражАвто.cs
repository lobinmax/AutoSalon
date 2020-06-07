using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class frГаражАвто : Form
{
    public frГаражАвто()
    {
        InitializeComponent();

        ОбновитьГараж();
        ЗаполнитьФильтры();

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
        var dt = clsSql.ExecuteSP("dbo.ГаражАвто_SIUD", clsMisc.ASSqlFunction.ViewForm).dataTable;
        gridViewГараж.ASОбновитьСохранитьВыделение(dt, "UIDТовара", value);

        gridViewГараж.ASНастроитьGridView(true, "UIDТовара", "UIDСтоимости");
    }

    private void simpleButtonОбновить_Click(object sender, EventArgs e) { ОбновитьГараж(); }

    void ОбновитьИсториюЦен(object value = null)
    {
    //    var dr = gridViewГараж.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
    //    if (dr == null)
    //    {
    //        gridViewИсторияЦены.DataSource = null;
    //        return;
    //    }

    //    var dt = clsSql.ExecuteSP("dbo.ГаражСтоимостьАвто_SIUD", clsMisc.ASSqlFunction.ViewForm,
    //                              "@UIDТовара", dr.Cells["UIDТовара"]).dataTable;
    //    gridViewИсторияЦены.ASОбновитьСохранитьВыделение(dt, "UIDТовара", value);

    //    gridViewИсторияЦены.ASНастроитьGridView(true, "UIDСтоимости", 
    //                                                  "UIDТовара", 
    //                                                  "ДатаСоздания", 
    //                                                  "ДатаИзменения", 
    //                                                  "UIDАвтора", 
    //                                                  "Автор", 
    //                                                  "UIDИзменяющего");
    }

    private void gridViewГараж_MouseClick(object sender, MouseEventArgs e)
    {
        var menu = new ContextMenuStrip();
        e.МенюДляAddEditDelete(menu, (DataGridView)sender, ДобавитьТовар, РедактироватьТовар, УдалитьТовар);
    }
    
    //private void gridViewГараж_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    //{
    //    ОбновитьИсториюЦен();
    //}

    //private void gridViewГараж_ColumnFilterDataSourceChanged(object sender, EventArgs e)
    //{
    //    ОбновитьИсториюЦен();
    //}

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
            if (result == System.Windows.Forms.DialogResult.OK)
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

    private void simpleButtonColor_Click(object sender, EventArgs e)
    {
        if (colorDialog1.ShowDialog() == DialogResult.Cancel)
            return;
        labelColor.BackColor = colorDialog1.Color;
    }

    private void buttonОчистить_Click(object sender, EventArgs e)
    {
        var controlName = (string)((Button)sender).Tag; // имя контрола который нужно очистить
        var controlNameArr = controlName.Split(';');

        foreach(var c in controlNameArr)
        {
            var control = this.Controls.Find(c, true).SingleOrDefault();
            if (control == null) { return; }

            if(control.GetType() == typeof(ComboBox))
            {
                var comboBox = (ComboBox)control;
                if(comboBox.Items.Count != 0)
                {
                    comboBox.SelectedIndex = 0;
                }
                else
                {
                    comboBox.ResetText();
                }
            }

            if(control.GetType() == typeof(TextBox))
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
        labelColor.BackColor = System.Drawing.SystemColors.Control;
        checkBoxБезПробега.Checked = false;
    }

    private void buttonОчиститьФильтры_Click(object sender, EventArgs e)
    {
        ЗаполнитьФильтры();
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
}