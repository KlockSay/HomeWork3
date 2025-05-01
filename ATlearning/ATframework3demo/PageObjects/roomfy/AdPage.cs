
using atFrameWork2.SeleniumFramework;
using ATframework3demo.BaseFramework;
using ATframework3demo.PageObjects.roomfy.MyAds;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.roomfy
{
    public class AdPage
    {
        public AdPage AssertAd(RoomfyCreateAd title)
        {
            var adTitleElement = new WebItem("//h1[@class='title is-2 mb-2']", "Заголовок объявления");
            bool isTitleCorrect = adTitleElement.GetAttribute("innerText").Trim().Equals(title.Title);
            if (!isTitleCorrect)
            {
                throw new Exception($"Объявление '{title.Title}' не найдено среди неактивных.");
            }
            return new AdPage();
        }
    }
}
