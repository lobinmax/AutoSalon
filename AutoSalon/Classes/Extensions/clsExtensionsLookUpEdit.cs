using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static partial class clsExtensions
{
    /// <summary>
    /// Настройка выпадалки
    /// </summary>
    /// <param name="lookUpEdit"></param>
    /// <param name="ValueMember">Поле с первичным ключом</param>
    /// <param name="DisplayMember">Поле для отображения в контроле</param>
    /// <param name="datatable">Источник данных</param>
    /// <param name="ItemIndexDefault">Индекс значения по умолчанию</param>
    /// <param name="ColumnsVisible">Список видимых столбцов</param>
    static public void ASНастроитьВыпадалку(this LookUpEdit lookUpEdit,
                                            string ValueMember,
                                            string DisplayMember,
                                            DataTable datatable, 
                                            int? ItemIndexDefault = null, 
                                            params string[] ColumnsVisible)
    {
        lookUpEdit.Properties.DataSource = datatable;
        lookUpEdit.Properties.PopulateColumns();
        lookUpEdit.Properties.ValueMember = ValueMember;
        lookUpEdit.Properties.DisplayMember = DisplayMember;
        foreach (DevExpress.XtraEditors.Controls.LookUpColumnInfo Column in lookUpEdit.Properties.Columns)
        {
            foreach(string ColVisible in ColumnsVisible)
            {
                if (Column.FieldName != ColVisible)
                {
                    Column.Visible = false;
                }
                else { break; }
            }
        }
        if (ItemIndexDefault != null) { lookUpEdit.ItemIndex = (int)ItemIndexDefault; }
    }

    /// <summary>
    /// Настройка выпадалки
    /// </summary>
    /// <param name="lookUpEdit"></param>
    /// <param name="ValueMember">Поле с первичным ключом</param>
    /// <param name="DisplayMember">Поле для отображения в контроле</param>
    /// <param name="datatable">Источник данных</param>
    /// <param name="EditValueDefault">Индекс значения по умолчанию</param>
    /// <param name="ColumnsVisible">Список видимых столбцов</param>
    static public void ASНастроитьВыпадалку(this LookUpEdit lookUpEdit,
                                            string ValueMember,
                                            string DisplayMember,
                                            DataTable datatable,
                                            object EditValueDefault = null,
                                            params string[] ColumnsVisible)
    {
        lookUpEdit.Properties.DataSource = datatable;
        lookUpEdit.Properties.PopulateColumns();
        lookUpEdit.Properties.ValueMember = ValueMember;
        lookUpEdit.Properties.DisplayMember = DisplayMember;

        foreach (DevExpress.XtraEditors.Controls.LookUpColumnInfo Column in lookUpEdit.Properties.Columns)
        {
            foreach (string ColVisible in ColumnsVisible)
            {
                if (Column.FieldName != ColVisible)
                {
                    Column.Visible = false;
                }
                else { break; }
            }
        }
        if (EditValueDefault != null) { lookUpEdit.EditValue = EditValueDefault; }
    }
}
