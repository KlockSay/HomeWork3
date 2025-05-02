
using atFrameWork2.SeleniumFramework;
using ATframework3demo.BaseFramework;
using ATframework3demo.PageObjects.roomfy.Adds;
using ATframework3demo.TestEntities;
using OpenQA.Selenium;

namespace ATframework3demo.PageObjects.roomfy.Search
{
    public class SearchPage
    {
        public SearchPage SearchFillFormPreference(RoomfySearchAd agefrom, RoomfySearchAd ageto, RoomfySearchAd pricefrom, RoomfySearchAd priceto)
        {   
            var btnAdType = new WebItem("//select[@name='post_type']", "Выбор типа объявления - Ищу квартиру");
            btnAdType.Click();
            btnAdType.SendKeys(Keys.ArrowDown);
            var btnGenderNeighbour = new WebItem("//select[@name='preferences[gender][value]']", "Выбор пола соседа - Мужчина");
            btnGenderNeighbour.Click();
            btnGenderNeighbour.SendKeys(Keys.ArrowDown);
            var btnAgeFromNeighbour = new WebItem("//input[@name='preferences[age_range][min]']", "Ввод минимального возраста соседа");
            btnAgeFromNeighbour.Click();
            btnAgeFromNeighbour.SendKeys(agefrom.AgeFrom);
            var btnAgeToNeighbour = new WebItem("//input[@name='preferences[age_range][max]']", "Ввод максимального возраста соседа");
            btnAgeToNeighbour.Click();
            btnAgeToNeighbour.SendKeys(ageto.AgeTo);
            var btnHousingType = new WebItem("//select[@name='preferences[housing_type][value]']", "Выбор типа жилья - Квартира");
            btnHousingType.Click();
            btnHousingType.SendKeys(Keys.ArrowDown);
            var btnPriceFrom = new WebItem("//input[@name='preferences[budget][min]']", "Ввод минимального бюджета");
            btnPriceFrom.Click();
            btnPriceFrom.SendKeys(pricefrom.PriceFrom);
            var btnPriceTo = new WebItem("//input[@name='preferences[budget][max]']", "Ввод максимального бюджета");
            btnPriceTo.Click();
            btnPriceTo.SendKeys(priceto.PriceTo);
            var btnRentalPeriod = new WebItem("//select[@name='preferences[lease_term][value]']", "Выбор срока аренды - Долгосрочно");
            btnRentalPeriod.Click();
            btnRentalPeriod.SendKeys(Keys.ArrowDown);
            var btnSmoking = new WebItem("//select[@name='preferences[smoking][value]']", "Выбор  Курение - Нет");
            btnSmoking.Click();
            btnSmoking.SendKeys(Keys.ArrowDown);
            var btnAlcohol = new WebItem("//select[@name='preferences[alcohol][value]']", "Выбор  Алкоголь - Нет");
            btnAlcohol.Click();
            btnAlcohol.SendKeys(Keys.ArrowDown);
            var btnPets = new WebItem("//select[@name='preferences[pets][value]']", "Выбор  Домашние животные - Нет");
            btnPets.Click();
            btnPets.SendKeys(Keys.ArrowDown);
            var btnPurity = new WebItem("//select[@name='preferences[cleanliness][value]']", "Выбор  Чистота - Чистоплотный");
            btnPurity.Click();
            btnPurity.SendKeys(Keys.ArrowDown);
            var btnSaveMyPreferences = new WebItem("//button[@type='submit']", "Кнопка Поиск");
            btnSaveMyPreferences.Click();
            return new SearchPage();
        }

        public bool AlertSearchAd(RoomfySearchAd title)
        {
            bool isTitleCorrect = new WebItem("//div[@class='card-header-title']/span", "Поле Названия").GetAttribute("innerText").Trim().Equals(title.Title + HelperMethods.GetDateTimeSaltString());
            return isTitleCorrect;
        }
    }
}
