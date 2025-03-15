
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automatization
{
    public class GeneralMenuSettingsBusinessProcess
    {
        public SampleBusinessProcess SettingBusinessProcess()
        {
            var btnSampleBusinessProcess = new WebItem("//a[@href='/bizproc/processes/12/bp_list/']", "Кнопка настроить бизнесс-процессы");
            btnSampleBusinessProcess.Click();
            return new SampleBusinessProcess();
        }
    }
}
