
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automatization
{
    public class GeneralSampleOutgoingDocuments
    {
        public GeneralTemplateParameters TemplateParameters()
        {
            var btnTemplateParameters = new WebItem("//a[@href='javascript:BCPShowParams();']", "Параментры шаблона");
            btnTemplateParameters.Click();
            return new GeneralTemplateParameters();
        }

        public GeneralSampleOutgoingDocuments ApplyTemplateChanges()
        {
            var btnApplyTemplateChanges = new WebItem("//button[@id='bizprocdesigner-btn-apply']", "Применить изменения");
            btnApplyTemplateChanges.Click();
            return new GeneralSampleOutgoingDocuments();
        }

        public SampleBusinessProcess SaveTemplate()
        {
            var btnSaveTemplate = new WebItem("//button[@id='bizprocdesigner-btn-save']", "Сохранить все изменения");
            btnSaveTemplate.Click();
            return new SampleBusinessProcess();
        }
    }
}
