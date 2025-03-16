
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automatization
{
    public class BusinessProcessSelection
    {
        public OutgoingDocumentsForm ClickOutgoingDocuments()
        {
            var btnOutgoingDocumentsForm = new WebItem("//div[@id[contains(., 'menu-popup-')]]/div/div/span[4]", "Выбор бизнес-процесса Исходящие документы");
            btnOutgoingDocumentsForm.Click();
            return new OutgoingDocumentsForm();
        }
    }
}
