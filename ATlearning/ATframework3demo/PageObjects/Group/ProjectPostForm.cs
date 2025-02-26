
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Group
{
    public class ProjectPostForm
    {
        public ProjectPostForm AddPost(Bitrix24Projects NewsPost)
        {
            var ProjectFrame = new WebItem("//div[@class='side-panel-content-container bitrix24-group-slider-content']" +
                "/iframe[@class='side-panel-iframe']", "Фрейм страницы проекта");
            ProjectFrame.SwitchToFrame();
            var massageFrame = new WebItem("//iframe[@class='bx-editor-iframe']", "Фрейм ввода сообщения");
            massageFrame.SwitchToFrame();
            var InputMassage = new WebItem("//body[@contenteditable='true']", "Поле ввода сообщения");
            InputMassage.SendKeys(NewsPost.NewsPost);
            WebDriverActions.SwitchToDefaultContent();
            return new ProjectPostForm();
        }

        public PageProjects SendPost()
        {
            var ProjectFrame = new WebItem("//div[@class='side-panel-content-container bitrix24-group-slider-content']" + 
                "/iframe[@class='side-panel-iframe']", "Фрейм страницы проекта");
            ProjectFrame.SwitchToFrame();
            var btnSendPost = new WebItem("//span[@id='blog-submit-button-save']", "Кнопка 'Отправить'");
            btnSendPost.Click();
            WebDriverActions.SwitchToDefaultContent();
            return new PageProjects();
        }
    }
}
