
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects
{
    public class PolComment
    {
        public PolComment SetComment(Bitrix24Comments comment)
        {
            var FrameComment = new WebItem("//iframe[@class='bx-editor-iframe']", "Фрейм сообщения");
            FrameComment.SwitchToFrame();
            var InputComment = new WebItem("//body[@contenteditable='true']", "Поле сообщения");
            InputComment.SendKeys(comment.Comment);
            WebDriverActions.SwitchToDefaultContent();
            return new PolComment(); 
        }
        WebItem ButtonSendComment =>
            new WebItem("//button[@class='ui-btn ui-btn-sm ui-btn-primary'][starts-with(@id, 'lhe_button_submit_blogCommentForm')]",
                "Кнопка отправить комментарий");
        public PortalHomePage SendComment()
        {
            ButtonSendComment.Click();
            return new PortalHomePage();
        }
    }
}
