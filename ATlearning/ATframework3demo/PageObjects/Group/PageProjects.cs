
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Group
{
    public class PageProjects
    {
        public ProjectPostForm CreateProjectPost()
        {
            var pageProjectFrame = new WebItem("//div[@class='side-panel-content-container bitrix24-group-slider-content']" +
                "/iframe[@class='side-panel-iframe']", "Фрейм страницы проекта");
            pageProjectFrame.SwitchToFrame();
            var btnCreateProjectPost = new WebItem("//div[@id='microoPostFormLHE_blogPostForm_inner']", "Область 'Написать сообщение'");
            btnCreateProjectPost.Click();
            WebDriverActions.SwitchToDefaultContent();
            return new ProjectPostForm();
        }

        internal object AssertPost(Bitrix24Projects NewsPost)
        {
            var pageProjectFrame = new WebItem("//div[@class='side-panel-content-container bitrix24-group-slider-content']" +
                "/iframe[@class='side-panel-iframe']", "Фрейм страницы проекта");
            pageProjectFrame.SwitchToFrame();
            var assertText = new WebItem($"//div[@class='feed-post-text'][text()='{NewsPost.NewsPost}']", "Текст поста")
                .AssertTextContains(NewsPost.NewsPost, "Поста в ленте нет");
            WebDriverActions.SwitchToDefaultContent();
            return assertText;
        }
    }
}
