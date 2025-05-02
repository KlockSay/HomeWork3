using System.Reflection;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.BaseFramework;
using ATframework3demo.TestEntities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V130.IndexedDB;
using OpenQA.Selenium.Support.UI;

namespace ATframework3demo.PageObjects.roomfy.MyAds
{
    public class ActiveAdsPage
    {
        public ActiveAdsPage DeactivationAds(RoomfyDeactivationAd title)
        {
            
            // Используем значение title.Title, которое уже содержит соль
            string expectedTitle = title.Title;

            // XPath: ищем кнопку в карточке, где заголовок точно совпадает
            string xpathToButton = $"//div[contains(@class, 'post-card')][.//div[@class='card-header-title']/span[contains(., '{expectedTitle}')]]//button[@aria-label='deactivate']";

            var deactivateButton = new WebItem(xpathToButton, "Кнопка деактивации нужного объявления");
            deactivateButton.Click();
            WebDriverActions.BrowserAlert(true);
            return new ActiveAdsPage();
        }

        public NoActiveAdsPage NoActiveAds()
        {
            var btnNoActiveAds = new WebItem("//a[@href='?tab=inactive']", "Нажать на кнопку 'Неактивные'");
            btnNoActiveAds.Click();
            return new NoActiveAdsPage();
        }
    }
}
