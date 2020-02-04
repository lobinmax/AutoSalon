using DevExpress.XtraGrid.Columns;
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
    static public void ASНастроитьGridView(this DevExpress.XtraGrid.Views.Grid.GridView gridView,
                                           bool IsHide = true,
                                           params string[] gridColumnVisible)
    {
        if (gridColumnVisible.Length == 0) { return; }

        foreach(string colVisible in gridColumnVisible)
        {
            foreach(GridColumn colGrid in gridView.Columns)
            {
                if(string.Equals(colGrid.Name.Replace("col", ""), colVisible.ToString()))
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
    static public void ASВыделитьСтрокуПоID(this DevExpress.XtraGrid.Views.Grid.GridView gridView,
                                            string fieldName, object value)
    {

        gridView.FocusedRowHandle = gridView.LocateByValue(fieldName, value);
    }

    /// <summary>
    /// Обновление грида с сохраниением выделенной строки
    /// </summary>
    /// <param name="datatable">Истосник данных</param>
    /// <param name="fieldName">Имя ключевого поля</param>
    /// <param name="value">Значений  ключевого поля</param>
    static public void ASОбновитьСохранитьВыделение(this DevExpress.XtraGrid.Views.Grid.GridView gridView,
                                                    DataTable datatable,
                                                    string fieldName = null, 
                                                    object value = null)
    {
        object ivalue = value;
        if (gridView.DataSource != null && fieldName != null)
        {
            if (gridView.RowCount != 0)
            {
                if(value == null)
                {
                    var dr = gridView.GetFocusedDataRow();
                    ivalue = dr[fieldName];
                }
            }
        }

        gridView.GridControl.DataSource = datatable;
        if ((String)gridView.Tag != "DSЗаполнен")
        {
            gridView.BestFitColumns();
            gridView.Tag = "DSЗаполнен";
        }

        if (ivalue != null && ivalue != System.DBNull.Value)
        {
            Type colType = gridView.Columns.ColumnByFieldName(fieldName).ColumnType;
            var memObject = Convert.ChangeType(ivalue, colType);
            gridView.ASВыделитьСтрокуПоID(fieldName, memObject);
        }
    }

    public static IEnumerable<DataRow> RowsDR(this DataTable DataTable)
    {
        return DataTable.Rows.Cast<DataRow>();
    }
     
}
