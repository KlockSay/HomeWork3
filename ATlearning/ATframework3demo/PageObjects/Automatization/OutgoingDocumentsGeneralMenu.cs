
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automatization
{
    public class OutgoingDocumentsGeneralMenu
    {
        public GeneralMenuSettingsBusinessProcess SettingsMenuBusinessProcess()
        {

            var btnGeneralMenuSettingsBusinessProcess = new WebItem("//div[@class='ui-toolbar-right-buttons']", "Кнопка настроек исходящих документов");
            btnGeneralMenuSettingsBusinessProcess.Click();
            return new GeneralMenuSettingsBusinessProcess();
            
        }
    }
}
