using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

public partial class frСправочники : DevExpress.XtraEditors.XtraForm
{
    public frСправочники()
    {
        InitializeComponent();
    }

    private void frСправочники_Load(object sender, EventArgs e)
    {
        var КПП = new NavPane(simpleButtonОбновить, gridViewТипыКпп, "UIDСотрудника", "dbo.ШтатСотрудники_SIUD");
        Console.WriteLine();
        
    }

    private void gridControlСотрудники_Click(object sender, EventArgs e)
    {

    }
}

public interface INavPane
{
    void Обновить(object Idvalue = null);
    //event EventHandler ОбновитьClick;
    void Добавить();
    void Изменить(object id);
    void Удалить(object id);
    
}

public class NavPane : INavPane
{
    public string procedureName { get; set; }
    public GridView gridView { get; set; }
    public string IdFieldName { get; set; }
    public SimpleButton btnОбновить { get; set; }

    public NavPane(SimpleButton btnОбновить, GridView gridView, string IdFieldName, string procedureName)
    {
        this.btnОбновить = btnОбновить;
        this.gridView = gridView;
        this.IdFieldName = IdFieldName;
        this.procedureName = procedureName;

        this.Обновить();
        this.gridView.BestFitColumns();
        btnОбновить.Click += ОбновитьClick;
    }

    public void Добавить()
    {
        throw new NotImplementedException();
    }

    public void Изменить(object id)
    {
        throw new NotImplementedException();
    }

    public void Обновить(object Idvalue = null)
    {
        var dt = clsSql.ExecuteSP(this.procedureName, clsMisc.ASSqlFunction.ViewForm).dataTable;
        gridView.ASОбновитьСохранитьВыделение(dt, this.IdFieldName, Idvalue);
    }

    public void ОбновитьClick(object sender, EventArgs e)
    {
        Обновить();
    }

    public void Удалить(object id)
    {
        throw new NotImplementedException();
    }
}