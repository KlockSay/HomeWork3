
using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects.roomfy.MyProfileSettings;
using ATframework3demo.TestEntities;
using OpenQA.Selenium;

namespace ATframework3demo.PageObjects.roomfy.Adds
{
    public class PreferencesFormCreateAd
    {
        public PreferencesFormCreateAd FillFormPreferences(RoomfyCreateAd agefrom, RoomfyCreateAd ageto, RoomfyCreateAd pricefrom, RoomfyCreateAd priceto)
        {
            string imagePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "TestEntities", "room.jpg"); // переменная для загрузки изображения 
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
            var fileInput = new WebItem("//input[@type='file']", "Поле загрузки файла");
            fileInput.SendKeys(imagePath);
            var btnSaveMyPreferences = new WebItem("//button[@class='button is-primary is-medium']", "Кнопка Опубликовать");
            btnSaveMyPreferences.Click();
            return new PreferencesFormCreateAd();
        }

        public AdPage OpenAd()
        {
            var btnAdPage = new WebItem("//a[@class='link is-small ml-2']", "Перейти в созданное объявление");
            btnAdPage.Click();
            return new AdPage();
        }

        public PreferencesFormCreateAd FillFormPreferences_1()
        {
            var btnSaveMyPreferences = new WebItem("//button[@class='button is-primary is-medium']", "Кнопка Опубликовать");
            btnSaveMyPreferences.Click();
            return new PreferencesFormCreateAd();
        }

        public PreferencesFormCreateAd FillFormPreferences_2(RoomfySearchAd agefrom, RoomfySearchAd ageto, RoomfySearchAd pricefrom, RoomfySearchAd priceto)
        {
            string imagePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "TestEntities", "room.jpg"); // переменная для загрузки изображения 
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
            var fileInput = new WebItem("//input[@type='file']", "Поле загрузки файла");
            fileInput.SendKeys(imagePath);
            var btnSaveMyPreferences = new WebItem("//button[@class='button is-primary is-medium']", "Кнопка Опубликовать");
            btnSaveMyPreferences.Click();
            return new PreferencesFormCreateAd();
        }
    }
}
