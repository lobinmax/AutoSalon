﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class dlgEditСтраны : Form
{
    private string ForeigenKey;
    private clsMisc.ASSqlFunction sqlFunction;

    public dlgEditСтраны() { InitializeComponent(); }

    private void dlgEditСтраны_Load(object sender, EventArgs e)
    {
        var dicTag = (Dictionary<string, clsMisc.ASSqlFunction>)this.Tag;
        var keyValue = dicTag.SingleOrDefault();
        ForeigenKey = keyValue.Key;
        sqlFunction = keyValue.Value;
        this.Text = "Добавить запись";

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            var dr = clsSql.ExecuteSP("dbo.Страны_SIUD", clsMisc.ASSqlFunction.ViewForm, "@UIDСтраны", ForeigenKey).dataTable.RowsDR().SingleOrDefault();
            textEditНаименование.Text = clsMisc.DBout((string)dr["Наименование"]);
            textEditНаименованиеСокр.Text = clsMisc.DBout((string)dr["Наименование сокр."]);
            this.Text = "Изменить запись";
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(textEditНаименование.Text, 
                                 textEditНаименованиеСокр.Text))
        {
            return;
        }

        var response = clsSql.ExecuteSP("Страны_SIUD", this.sqlFunction,
            "@UIDСтраны", clsMisc.DBin(this.ForeigenKey),
            "@Наименование", clsMisc.DBin(textEditНаименование.Text),
            "@НаименованиеСокр", clsMisc.DBin(textEditНаименованиеСокр.Text));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            this.Tag = dr[0];
            this.DialogResult = DialogResult.OK;
        }
    }
}
