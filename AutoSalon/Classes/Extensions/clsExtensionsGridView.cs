using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

public static partial class clsExtensions 
{
    /// <summary>
    /// Метод скрывает указанные столбцы
    /// </summary>
    /// <param name="IsHide">True - скрыть указанные, False - указанные оставить видимыми</param>
    /// <param name="gridColumnVisible"></param>
    static public void ASНастроитьGridView(this System.Windows.Forms.DataGridView gridView,
                                           bool IsHide,
                                           params string[] gridColumnVisible)
    {
        if (gridColumnVisible.Length == 0) { return; }

        foreach(string colVisible in gridColumnVisible)
        {
            foreach(System.Windows.Forms.DataGridViewColumn colGrid in gridView.Columns)
            {
                if(string.Equals(colGrid.HeaderText, colVisible.ToString()))
                {
                    colGrid.Visible = (IsHide ?  false: true );
                    break;
                }
            }
        }
    }

    /// <summary>
    /// Выделяет строку по значению и ключевому полю
    /// </summary>
    /// <param name="fieldName">Имя ключевого поля</param>
    /// <param name="value">Значений  ключевого поля</param>
    static public void ASВыделитьСтрокуПоID(this System.Windows.Forms.DataGridView gridView,
                                            string fieldName, object value)
    {
        //gridView.FocusedRowHandle = gridView.LocateByValue(fieldName, value);
        for(var row = 0; row < gridView.Rows.Count; row++)
        {
            if (gridView[fieldName, row].Value.ToString().Equals(value.ToString()))
            {
                gridView[gridView.FirstDisplayedScrollingColumnIndex, row].Selected = true;
                break;
            }
        }


    }

    /// <summary>
    /// Обновление грида с сохраниением выделенной строки
    /// </summary>
    /// <param name="datatable">Истосник данных</param>
    /// <param name="fieldName">Имя ключевого поля</param>
    /// <param name="value">Значений  ключевого поля</param>
    static public void ASОбновитьСохранитьВыделение(this System.Windows.Forms.DataGridView gridView,
                                                    DataTable datatable,
                                                    string fieldName = null,
                                                    object value = null)
    {
        object ivalue = value;
        if (gridView.DataSource != null && fieldName != null)
        {
            if (gridView.RowCount != 0)
            {
                if (value == null && gridView.CurrentRow != null)
                {
                    ivalue = gridView[fieldName, gridView.CurrentRow.Index].Value.ToString();
                }
            }
        }

        gridView.DataSource = datatable;
        if ((String)gridView.Tag != "DSЗаполнен")
        {
            gridView.Tag = "DSЗаполнен";
        }

        if (ivalue != null && ivalue != System.DBNull.Value)
        {
            //Type colType = gridView.Columns[fieldName].ValueType;
            //var memObject = Convert.ChangeType(ivalue.ToString(), Type.GetType(gridView.Columns[fieldName].ValueType.ToString()));
            gridView.ASВыделитьСтрокуПоID(fieldName, ivalue);
        }
    }

    public static IEnumerable<DataRow> RowsDR(this DataTable DataTable)
    {
        return DataTable.Rows.Cast<DataRow>();
    }
     
}
