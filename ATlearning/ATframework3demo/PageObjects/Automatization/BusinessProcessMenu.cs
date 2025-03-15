
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automatization
{
    public class BusinessProcessMenu
    {
        public ProcessesInNewsFeedGeneralMenu ProcessesInNewsFeed()
        {
            var btnBussnesProsessInNews = new WebItem("//a[@href='/bizproc/processes/']", "Перейти в меню процессы в ленте новстей");
            btnBussnesProsessInNews.Click();
            return new ProcessesInNewsFeedGeneralMenu();
        
        }
    }
}
