using System;
using DevExpress.XtraBars.Navigation;

public partial class frСправочники : DevExpress.XtraEditors.XtraForm
{
    public frСправочники()
    {
        InitializeComponent();
    }

    private void frСправочники_Load(object sender, EventArgs e)
    {
        using (var d = new DevExpress.Utils.WaitDialogForm("Идет загрузка ...", "Пожалуйста, подождите"))
        {
            navigationPane_SelectedPageChanged(navigationPane, new SelectedPageChangedEventArgs(navigationPane.SelectedPage, navigationPane.SelectedPage));
        }
    }

    private void navigationPane_StateChanged(object sender, DevExpress.XtraBars.Navigation.StateChangedEventArgs e)
    {
        if(navigationPane.State != DevExpress.XtraBars.Navigation.NavigationPaneState.Default)
        {
            navigationPane.State = e.OldState;
        }
    }

    private void navigationPane_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
    {
        var page = (NavigationPage) e.Page;
        switch (page.Name)
        {
            case "navigationPageТипыКПП": 
                using (var КПП = new clsDlgEditSimple(simpleButtonОбновить,
                                        simpleButtonДобавить,
                                        simpleButtonИзменить,
                                        simpleButtonУдалить,
                                        gridViewТипыКпп,
                                        "IdТипКПП",
                                        "dbo.АвтоТипКПП_SIUD",
                                        "dlgEditТипКПП", () => gridViewТипыКпп.ASНастроитьGridView(true, "IdТипКПП"))) 
{
                } ;
                break;
            case "navigationPageТипыКузова":
                using (var ТипКузова = new clsDlgEditSimple(simpleButtonОбновить,
                                        simpleButtonДобавить,
                                        simpleButtonИзменить,
                                        simpleButtonУдалить,
                                        gridViewТипКузова,
                                        "IdТипКузова",
                                        "dbo.АвтоТипКузова_SIUD",
                                        "dlgEditТипКузова", () => gridViewТипКузова.ASНастроитьGridView(true, "IdТипКузова")))
                {
                }; 
                break;
            case "navigationPageТипыПривода":
                using (var ТипПривода = new clsDlgEditSimple(simpleButtonОбновить,
                                        simpleButtonДобавить,
                                        simpleButtonИзменить,
                                        simpleButtonУдалить,
                                        gridViewТипыПривода,
                                        "IdТипПривода",
                                        "dbo.АвтоТипПривода_SIUD",
                                        "dlgEditТипПривода", () => gridViewТипыПривода.ASНастроитьGridView(true, "IdТипПривода")))
                {
                };
                break;
            case "navigationPageТипыТоплива":
                using (var ТипТоплива = new clsDlgEditSimple(simpleButtonОбновить,
                                        simpleButtonДобавить,
                                        simpleButtonИзменить,
                                        simpleButtonУдалить,
                                        gridViewТипыТоплива,
                                        "IdТипТоплива",
                                        "dbo.АвтоТипТоплива_SIUD",
                                        "dlgEditТипТоплива", () => gridViewТипыТоплива.ASНастроитьGridView(true, "IdТипТоплива")))
                break;
            case "navigationPageЗаказыСтатусы":
                using (var СтатусЗаказа = new clsDlgEditSimple(simpleButtonОбновить,
                                          simpleButtonДобавить,
                                          simpleButtonИзменить,
                                          simpleButtonУдалить,
                                          gridViewСтатусыЗаказа,
                                          "IdСтатусЗаказа",
                                          "dbo.ТипыСтатусовЗаказа_SIUD",
                                          "dlgEditТипыСтатусовЗаказа", () => gridViewСтатусыЗаказа.ASНастроитьGridView(true, "IdСтатусЗаказа")))
                break;
            case "navigationPageСтраны":
                using (var Страны = new clsDlgEditSimple(simpleButtonОбновить,
                                    simpleButtonДобавить,
                                    simpleButtonИзменить,
                                    simpleButtonУдалить,
                                    gridViewСтраны,
                                    "UIDСтраны",
                                    "dbo.Страны_SIUD",
                                    "dlgEditСтраны", () => gridViewСтраны.ASНастроитьGridView(true, "UIDСтраны")))
                break;

        }
    }
}





