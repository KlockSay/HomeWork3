using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;
using OpenQA.Selenium;

namespace ATframework3demo.PageObjects
{
    /// <summary>
    /// Форма добавления нового сообщения в новости
    /// </summary>
    public class NewsPostForm
    {
        public NewsPostForm(IWebDriver driver = default)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        public bool IsRecipientPresent(string recipientName)
        {
            //проверить наличие шильдика
            var recipientsArea = new WebItem("//div[@id='entity-selector-oPostFormLHE_blogPostForm']//div[@class='ui-tag-selector-items']",
                "Область получателей поста");
            bool isRecipientPresent = Waiters.WaitForCondition(() => recipientsArea.AssertTextContains(recipientName, default, Driver), 2, 6,
                $"Ожидание появления строки '{recipientName}' в '{recipientsArea.Description}'");
            return isRecipientPresent;
        }

        public NewsPostForm SetMessage(Bitrix24Comments newmessage)
        {
            var FrameMassage = new WebItem("//iframe[@class='bx-editor-iframe']", "Фрейм сообщения");
            FrameMassage.SwitchToFrame();
            var InputMassage = new WebItem("//body[@contenteditable='true']", "Поле сообщения");
            InputMassage.SendKeys(newmessage.NewMessage);
            WebDriverActions.SwitchToDefaultContent();
            return new NewsPostForm(Driver);
        }


        WebItem ButtonSendPost =>
            new WebItem("//div[@id='feed-add-buttons-blockblogPostForm']/span[@id='blog-submit-button-save']",
                "Кнопка отправить пост");
        public PortalHomePage SendMessage()
        {
            ButtonSendPost.Click();
            return new PortalHomePage(Driver);
        }
    }
}
