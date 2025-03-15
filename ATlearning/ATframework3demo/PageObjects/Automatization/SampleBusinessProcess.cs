
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automatization
{
    public class SampleBusinessProcess
    {
        public GeneralSampleOutgoingDocuments SampleOutgoingDocuments()
        {
            var btnGeneralSampleOutgoingDocuments = new WebItem("//a[@href='/bizproc/processes/12/bp_edit/14/']", "Кнопка исходящие документы");
            btnGeneralSampleOutgoingDocuments.Click();
            return new GeneralSampleOutgoingDocuments();
        }
    }
}
