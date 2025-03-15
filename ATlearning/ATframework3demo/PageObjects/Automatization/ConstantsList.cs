
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automatization
{
    public class ConstantsList
    {
        public WhoRecordsSetting WhoRecords()
        {
            var btnWhoRecordsSetting = new WebItem("//table[@id='WFSListC']/tbody/tr[2]/td[1]/a", "Изменить константы");
            btnWhoRecordsSetting.Click();
            return new WhoRecordsSetting();
        }

        public GeneralSampleOutgoingDocuments SaveSattingsTemplate()
        {
            var btnGeneralSampleOutgoingDocuments = new WebItem("//input[@onclick='WFSFSave();']", "Сохранить изменения шаблона");
            btnGeneralSampleOutgoingDocuments.Click();
            return new GeneralSampleOutgoingDocuments();
        }
    }
}
