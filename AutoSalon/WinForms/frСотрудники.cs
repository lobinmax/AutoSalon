using System;
using System.Collections.Generic;
using System.Windows.Forms;


public partial class frСотрудники : Form
{
    public frСотрудники()
    {
        InitializeComponent();
    }

    private void frСотрудники_Load(object sender, EventArgs e)
    {
        Обновить();
        gridViewСотрудники.ASНастроитьGridView(gridColumnVisible: "UIDСотрудника");
        ASTimer timer = new ASTimer(gridViewСотрудники, 
                                    new List<Button> { buttonИзменить, buttonУдалить }
                                    ) { Enabled = true };
    }

    void Обновить(object value = null)
    {
        var dt = clsSql.ExecuteSP("dbo.ШтатСотрудники_SIUD", clsMisc.ASSqlFunction.ViewForm).dataTable;
        gridViewСотрудники.DataSource = dt;
        gridViewСотрудники.ASОбновитьСохранитьВыделение(dt, "UIDСотрудника", value);       
    }

    private void simpleButtonОбновить_Click(object sender, EventArgs e) { Обновить(); }


    #region Кнопки управления и контекстное меню  

    void ДобавитьСотрудника(object sender, EventArgs e) 
    {
        using (var editСотрудник = new dlgEditСотрудник(null, clsMisc.ASSqlFunction.Insert))
        {
            var result = editСотрудник.ShowDialog();
            if (result == DialogResult.OK)
            {
                Обновить(editСотрудник.NewRecord);
            }
        }
    }

    private void simpleButtonДобавить_Click(object sender, EventArgs e) { ДобавитьСотрудника(sender, e); }

    void РедактироватьСотрудника(object sender, EventArgs e)
    {
        using (var editСотрудник = new dlgEditСотрудник((Guid)gridViewСотрудники["UIDСотрудника", gridViewСотрудники.CurrentRow.Index].Value, clsMisc.ASSqlFunction.Update))
        {
            var result = editСотрудник.ShowDialog();
            if (result == DialogResult.OK)
            {
                Обновить(editСотрудник.NewRecord);
            }
        }
    }
    private void simpleButtonИзменить_Click(object sender, EventArgs e) { РедактироватьСотрудника(sender, e); }

    void УдалитьСотрудника(object sender, EventArgs e)
    {
        if (MessageBox.Show("Вы уверены что хотите удалить сотрудника?", 
                                Program.ProductName, 
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question) == DialogResult.Yes)
        {
            clsSql.ExecuteSPNonQuery("dbo.ШтатСотрудники_SIUD",
                clsMisc.ASSqlFunction.Delete, "@UIDСотрудника",
                gridViewСотрудники["UIDСотрудника", gridViewСотрудники.CurrentRow.Index].Value.ToString());
                Обновить();
        }
    }
    private void simpleButtonУдалить_Click(object sender, EventArgs e) { УдалитьСотрудника(sender, e); }
    #endregion

    private void gridViewСотрудники_MouseClick(object sender, MouseEventArgs e)
    {
        var h = gridViewСотрудники.HitTest(e.X, e.Y);
        var menu = new ContextMenuStrip();
        e.МенюДляAddEditDelete(menu, (DataGridView)sender, ДобавитьСотрудника, РедактироватьСотрудника, УдалитьСотрудника);
    }
    
}

