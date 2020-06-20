using System;
using System.Windows.Forms;

public partial class frСправочники : Form
{
    public frСправочники()
    {
        InitializeComponent();
    }

    private void frСправочники_Load(object sender, EventArgs e)
    {
        tabControl1_SelectedIndexChanged(sender, e);
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var page = tabControl.SelectedTab;
        switch (page.Name)
        {
            case "tabPageТипыКПП":
                using (var КПП = new clsDlgEditSimple(ButtonОбновить,
                                                      ButtonДобавить,
                                                      ButtonИзменить,
                                                      ButtonУдалить,
                                                      gridViewТипыКпп,
                                                      "IdТипКПП",
                                                      "dbo.АвтоТипКПП_SIUD",
                                                      "dlgEditТипКПП", () => gridViewТипыКпп.ASНастроитьGridView(true, "IdТипКПП")))
                {
                };
                break;
            case "tabPageТипыКузова":
                using (var ТипКузова = new clsDlgEditSimple(ButtonОбновить,
                                        ButtonДобавить,
                                        ButtonИзменить,
                                        ButtonУдалить,
                                        gridViewТипКузова,
                                        "IdТипКузова",
                                        "dbo.АвтоТипКузова_SIUD",
                                        "dlgEditТипКузова", () => gridViewТипКузова.ASНастроитьGridView(true, "IdТипКузова")))
                {
                };
                break;
            case "tabPageТипыПривода":
                using (var ТипПривода = new clsDlgEditSimple(ButtonОбновить,
                                        ButtonДобавить,
                                        ButtonИзменить,
                                        ButtonУдалить,
                                        gridViewТипыПривода,
                                        "IdТипПривода",
                                        "dbo.АвтоТипПривода_SIUD",
                                        "dlgEditТипПривода", () => gridViewТипыПривода.ASНастроитьGridView(true, "IdТипПривода")))
                {
                };
                break;
            case "tabPageТипыТоплива":
                using (var ТипТоплива = new clsDlgEditSimple(ButtonОбновить,
                                        ButtonДобавить,
                                        ButtonИзменить,
                                        ButtonУдалить,
                                        gridViewТипыТоплива,
                                        "IdТипТоплива",
                                        "dbo.АвтоТипТоплива_SIUD",
                                        "dlgEditТипТоплива", () => gridViewТипыТоплива.ASНастроитьGridView(true, "IdТипТоплива")))
                    break;
            case "tabPageЗаказыСтатусы":
                using (var СтатусЗаказа = new clsDlgEditSimple(ButtonОбновить,
                                          ButtonДобавить,
                                          ButtonИзменить,
                                          ButtonУдалить,
                                          gridViewСтатусыЗаказа,
                                          "IdСтатусЗаказа",
                                          "dbo.ТипыСтатусовЗаказа_SIUD",
                                          "dlgEditТипыСтатусовЗаказа", () => gridViewСтатусыЗаказа.ASНастроитьGridView(true, "IdСтатусЗаказа")))
                    break;
            case "tabPageСтраны":
                using (var Страны = new clsDlgEditSimple(ButtonОбновить,
                                    ButtonДобавить,
                                    ButtonИзменить,
                                    ButtonУдалить,
                                    gridViewСтраны,
                                    "UIDСтраны",
                                    "dbo.Страны_SIUD",
                                    "dlgEditСтраны", () => gridViewСтраны.ASНастроитьGridView(true, "UIDСтраны")))
                    break;

        }
    }
}





