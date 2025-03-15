
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automatization
{
    public class ProcessesInNewsFeedGeneralMenu
    {
        public OutgoingDocumentsGeneralMenu OutgoingDocuments()
        {
            var btnOutgoingDocumentsGeneralMenu = new WebItem("//a[@href='/bizproc/processes/12/view/0/?list_section_id=']", "Кнопка исходящие документы");
            btnOutgoingDocumentsGeneralMenu.Click();
            return new OutgoingDocumentsGeneralMenu();
        }
    }
}
