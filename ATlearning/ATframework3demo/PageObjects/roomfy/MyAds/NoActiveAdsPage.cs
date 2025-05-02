using atFrameWork2.SeleniumFramework;
using ATframework3demo.BaseFramework;
using ATframework3demo.TestEntities;
using static OpenQA.Selenium.BiDi.Modules.BrowsingContext.Locator;

namespace ATframework3demo.PageObjects.roomfy.MyAds
{
    public class NoActiveAdsPage
    {
        public NoActiveAdsPage AelertDeactivationAd(RoomfyDeactivationAd title)
        {
            var adTitleElement = new WebItem("//div[@class='card-header-title']/span", "Заголовок объявления");

            bool isTitleCorrect = adTitleElement.GetAttribute("innerText").Trim().Equals(title.Title);

            if (!isTitleCorrect)
            {
                throw new Exception($"Объявление '{title.Title}' не найдено среди неактивных.");
            }

            return new NoActiveAdsPage();
        }
    }
}
