
using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;

namespace ATframework3demo.PageObjects.Automatization
{
    public class WhoRecordsSetting
    {
        public WhoRecordsSetting RemoveConstants()
        {
            var btnWhoRecordsSetting = new WebItem("//input[@id='id_WFSFormDefaultC']", "Клик в поле, где введена константа");
            btnWhoRecordsSetting.Click();
            btnWhoRecordsSetting.SendKeys(Keys.Control + "a");
            btnWhoRecordsSetting.SendKeys(Keys.Backspace); 
            return new WhoRecordsSetting();
        }

        public ConstantsList SaveNewConstants()
        {
            var btnConstantsList = new WebItem("//input[@id='dpsavebuttonformC']", "Сохранить изменение константы");
            btnConstantsList.Click();
            return new ConstantsList();
            throw new NotImplementedException();
        }
    }
}