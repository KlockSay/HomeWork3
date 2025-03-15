using atFrameWork2.BaseFramework;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects.Automatization;
using ATframework3demo.TestEntities;
using OpenQA.Selenium;

namespace ATframework3demo.PageObjects
{
    public class NewsPage
    {
        public NewsPage(IWebDriver driver = default)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        public NewsPostForm AddPost()
        {
            //Клик в Написать сообщение
            var btnPostCreate = new WebItem("//div[@id='microoPostFormLHE_blogPostForm_inner']", "Область в новостях 'Написать сообщение'");
            btnPostCreate.Click(Driver);
            return new NewsPostForm(Driver);
        }

        public InfoBusnessProsess OpenBusnesProsess()
        {
            var btnPostBusnessProsess = new WebItem("//div[@class='feed-add-post-destination-title']/a", "Область в новостях 'Написать сообщение'");
            btnPostBusnessProsess.Click();
            return new InfoBusnessProsess();
        }
    }
}
