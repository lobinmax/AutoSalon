using System.Data;
using System.Windows.Forms;

public static partial class clsExtensions
{
    /// <summary>
    /// Настройка выпадалки
    /// </summary>
    /// <param name="procedureName">Имя процедуры вызова данных</param>
    /// <param name="ValueMember">Поле с первичным ключом</param>
    /// <param name="DisplayMember">Поле для отображения в контроле</param>
    /// <param name="selectedIndex">Индекс значения по умолчанию</param>
    static public void ASНастроитьВыпадалку_SP(this ComboBox lookUpEdit,
                                            string procedureName,
                                            string ValueMember,
                                            string DisplayMember,
                                            int selectedIndex = 0)
    {
        var dt = clsSql.ExecuteSP(procedureName).dataTable;
        lookUpEdit.DataSource = dt;
        lookUpEdit.ValueMember = ValueMember;
        lookUpEdit.DisplayMember = DisplayMember;

        lookUpEdit.SelectedIndex = selectedIndex;
    }

    /// <summary>
    /// Настройка выпадалки
    /// </summary>
    /// <param name="procedureName">Имя процедуры вызова данных</param>
    /// <param name="ValueMember">Поле с первичным ключом</param>
    /// <param name="DisplayMember">Поле для отображения в контроле</param>
    /// <param name="selectedIndex">Индекс значения по умолчанию</param>
    /// <param name="parameters">Параметры для хранимой процедуры</param>
    static public void ASНастроитьВыпадалку_SP(this ComboBox lookUpEdit,
                                            string procedureName,
                                            string ValueMember,
                                            string DisplayMember,
                                            int selectedIndex = 0,
                                            params object[] parameters)
    {
        var dt = clsSql.ExecuteSP(procedureName, parameters).dataTable;
        lookUpEdit.DataSource = dt;
        lookUpEdit.ValueMember = ValueMember;
        lookUpEdit.DisplayMember = DisplayMember;

        lookUpEdit.SelectedIndex = selectedIndex;
    }

    /// <summary>
    /// Настройка выпадалки
    /// </summary>
    /// <param name="procedureName">Имя процедуры вызова данных</param>
    /// <param name="ValueMember">Поле с первичным ключом</param>
    /// <param name="DisplayMember">Поле для отображения в контроле</param>
    /// <param name="selectedIndex">Индекс значения по умолчанию</param>
    /// <param name="parameters">Параметры для хранимой процедуры</param>
    static public void ASНастроитьВыпадалку_SP(this ComboBox lookUpEdit,
                                            string procedureName,
                                            string ValueMember,
                                            string DisplayMember,
                                            int selectedIndex = 0,
                                            clsMisc.ASSqlFunction SqlFunction = clsMisc.ASSqlFunction.Null,
                                            params object[] parameters)
    {
        var dt = clsSql.ExecuteSP(procedureName, SqlFunction, parameters).dataTable;
        lookUpEdit.DataSource = dt;
        lookUpEdit.ValueMember = ValueMember;
        lookUpEdit.DisplayMember = DisplayMember;

        lookUpEdit.SelectedIndex = selectedIndex;
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
    static public void ASНастроитьВыпадалку_Query(this ComboBox lookUpEdit,
                                            string queryString,
                                            string ValueMember,
                                            string DisplayMember,
                                            int selectedIndex = 0)
    {
        var dt = clsSql.ExecuteQuery(queryString).dataTable;
        lookUpEdit.DataSource = dt;
        lookUpEdit.ValueMember = ValueMember;
        lookUpEdit.DisplayMember = DisplayMember;

        lookUpEdit.SelectedIndex = selectedIndex;
    }

    static public DataRow ASSelectedRow(this ComboBox comboBox)
    {
        return ((DataRowView)comboBox.SelectedItem)?.Row;
    }
}
