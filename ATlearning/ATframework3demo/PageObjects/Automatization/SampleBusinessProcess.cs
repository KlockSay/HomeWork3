
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automatization
{
    public class SampleBusinessProcess
    {
        public GeneralSampleOutgoingDocuments SampleOutgoingDocuments()
        {
            var btnGeneralSampleOutgoingDocuments = new WebItem("//table[@id='bizproc_wflist_lists']/tbody/tr[3]/td[2]/a", "Кнопка исходящие документы");
            btnGeneralSampleOutgoingDocuments.Click();
            return new GeneralSampleOutgoingDocuments();
        }
    }
}
