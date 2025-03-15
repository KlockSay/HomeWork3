
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automatization
{
    public class BusinessProcessSelection
    {
        public OutgoingDocumentsForm ClickOutgoingDocuments()
        {
            var btnOutgoingDocumentsForm = new WebItem("//span[@data-icon-url='/upload/iblock/9c0/dbaao48ihfztv4zyyoj1xbflwr9dt04j/df3e7ecfaf528feaa52912c042c48c5c.png']", "Выбор бизнес-процесса Исходящие документы");
            btnOutgoingDocumentsForm.Click();
            return new OutgoingDocumentsForm();
        }
    }
}
