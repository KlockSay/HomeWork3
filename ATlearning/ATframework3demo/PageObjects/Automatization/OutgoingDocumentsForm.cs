
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Automatization
{
    public class OutgoingDocumentsForm
    {
        public AutomatizationPage WriteInForm(Bitrix24BussnessProsess newmessange)
        {
            var createAutomatizationPageFrame = new WebItem("//iframe[@class='side-panel-iframe']", "Фрейм создания бизнес процесса");
            createAutomatizationPageFrame.SwitchToFrame();
            var btnСontinue = new WebItem("//button[@id='lists-element-creation-guide-next-button']", "Кнопка продолжить");
            btnСontinue.Click();
            var btnChoose = new WebItem("//span[@class='ui-tag-selector-item ui-tag-selector-add-button']", "Кнопка выбрать кто фкисирует");
            btnChoose.Click();
            var btnChooseFixes = new WebItem("//div[@class='ui-selector-item-box']", "Выбрать того, кто фиксирует");
            btnChooseFixes.Click();
            btnСontinue.Click();
            var btnCalendar = new WebItem("//div[@class='ui-ctl-ext-after ui-ctl-icon-calendar']", "Кнопка календаря");
            btnCalendar.Click();
            var btnDate = new WebItem("//div[@class='popup-window --open']", "Выбрать дату");
            btnDate.Click();
            var btnText = new WebItem("//textarea[@name='PREVIEW_TEXT']", "Кнопка для написания текста");
            btnText.Click();
            btnText.SendKeys(newmessange.NewMessage);
            var btnStart = new WebItem("//button[@id='lists-element-creation-guide-create-button']", "Кнопка запустить");
            btnStart.Click();
            WebDriverActions.SwitchToDefaultContent();
            return new AutomatizationPage();
        }
    }
}
