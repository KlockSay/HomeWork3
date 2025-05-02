
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;
using OpenQA.Selenium;

namespace ATframework3demo.PageObjects.roomfy.MyProfileSettings
{
    public class MyPreferencesPage
    {
        public MyPreferencesPage FillMyPreferences(RoomfyMyProfilePersonal agefrom,RoomfyMyProfilePersonal ageto, RoomfyMyProfilePersonal pricefrom, RoomfyMyProfilePersonal priceto)
        {
            var btnGenderNeighbour = new WebItem("//select[@name='preferences[gender]']", "Выбор пола соседа - Мужчина");
            btnGenderNeighbour.Click();
            btnGenderNeighbour.SendKeys(Keys.ArrowDown);
            var btnAgeFromNeighbour = new WebItem("//input[@name='preferences[age_range][min]']", "Ввод минимального возраста соседа");
            btnAgeFromNeighbour.Click();
            btnAgeFromNeighbour.SendKeys(agefrom.AgeFrom);
            var btnAgeToNeighbour = new WebItem("//input[@name='preferences[age_range][max]']", "Ввод максимального возраста соседа");
            btnAgeToNeighbour.Click();
            btnAgeToNeighbour.SendKeys(ageto.AgeTo);
            var btnHousingType = new WebItem("//select[@name='preferences[housing_type]']", "Выбор типа жилья - Квартира");
            btnHousingType.Click();
            btnHousingType.SendKeys(Keys.ArrowDown);
            var btnPriceFrom = new WebItem("//input[@name='preferences[budget][min]']", "Ввод минимального бюджета");
            btnPriceFrom.Click();
            btnPriceFrom.SendKeys(pricefrom.PriceFrom);
            var btnPriceTo = new WebItem("//input[@name='preferences[budget][max]']", "Ввод максимального бюджета");
            btnPriceTo.Click();
            btnPriceTo.SendKeys(priceto.PriceTo);
            var btnRentalPeriod = new WebItem("//select[@name='preferences[lease_term]']", "Выбор срока аренды - Долгосрочно");
            btnRentalPeriod.Click();
            btnRentalPeriod.SendKeys(Keys.ArrowDown);
            var btnSmoking = new WebItem("//select[@name='preferences[smoking]']", "Выбор  Курение - Нет");
            btnSmoking.Click();
            btnSmoking.SendKeys(Keys.ArrowDown);
            var btnAlcohol = new WebItem("//select[@name='preferences[alcohol]']", "Выбор  Алкоголь - Нет");
            btnAlcohol.Click();
            btnAlcohol.SendKeys(Keys.ArrowDown);
            var btnPets = new WebItem("//select[@name='preferences[pets]']", "Выбор  Домашние животные - Нет");
            btnPets.Click();
            btnPets.SendKeys(Keys.ArrowDown);
            var btnPurity = new WebItem("//select[@name='preferences[cleanliness]']", "Выбор  Чистота - Чистоплотный");
            btnPurity.Click();
            btnPurity.SendKeys(Keys.ArrowDown);
            var btnSaveMyPreferences = new WebItem("//button[@name='save_preferences']", "Кнопка сохранения предпочтений");
            btnSaveMyPreferences.Click();
            return new MyPreferencesPage();
        }

        public bool AssertMyPreferences(RoomfyMyProfilePersonal agefrom, RoomfyMyProfilePersonal ageto, RoomfyMyProfilePersonal pricefrom, RoomfyMyProfilePersonal priceto)
        {
            bool isGenderNeighbourCorrect = new WebItem("//select[@name='preferences[gender]']/option[@value='Мужчина']", "Выбранный пол соседа")
                .GetAttribute("value").Equals("Мужчина", StringComparison.OrdinalIgnoreCase);

            bool isAgeFromNeighbourCorrect = new WebItem("//input[@name='preferences[age_range][min]']", "Поле минимального возраста соседа")
                .GetAttribute("value").Equals(agefrom.AgeFrom);
            
            bool isAgeToNeighbourCorrect = new WebItem("//input[@name='preferences[age_range][max]']", "Поле максимального возраста соседа")
                .GetAttribute("value").Equals(ageto.AgeTo);

            bool isHousingTypeCorrect = new WebItem("//select[@name='preferences[housing_type]']/option[@value='Квартира']", "Выбранный тип жилья")
                .GetAttribute("value").Equals("Квартира", StringComparison.OrdinalIgnoreCase);

            bool isPriceFromCorrect = new WebItem("//input[@name='preferences[budget][min]']", "Поле минимального бюджета")
                .GetAttribute("value").Equals(pricefrom.PriceFrom);

            bool isPriceToCorrect = new WebItem("//input[@name='preferences[budget][max]']", "Поле максимального бюджета")
                .GetAttribute("value").Equals(priceto.PriceTo);

            bool isRentalPeriodCorrect = new WebItem("//select[@name='preferences[lease_term]']/option[@value='Долгосрочно']", "Выбранный тип срок аренды")
                .GetAttribute("value").Equals("Долгосрочно", StringComparison.OrdinalIgnoreCase);

            bool isSmokingCorrect = new WebItem("//select[@name='preferences[smoking]']/option[@value='Нет']", "Курение")
                .GetAttribute("value").Equals("Нет", StringComparison.OrdinalIgnoreCase);

            bool isAlcoholCorrect = new WebItem("//select[@name='preferences[alcohol]']/option[@value='Нет']", "Алкоголь")
                .GetAttribute("value").Equals("Нет", StringComparison.OrdinalIgnoreCase);

            bool isPetsCorrect = new WebItem("//select[@name='preferences[pets]']/option[@value='Нет']", "Домашние животные")
                .GetAttribute("value").Equals("Нет", StringComparison.OrdinalIgnoreCase);

            bool isPurityCorrect = new WebItem("//select[@name='preferences[cleanliness]']/option[@value='Чистоплотный']", "Чистота")
                .GetAttribute("value").Equals("Чистоплотный", StringComparison.OrdinalIgnoreCase);


            return isGenderNeighbourCorrect && isAgeFromNeighbourCorrect && isAgeToNeighbourCorrect && isHousingTypeCorrect && isPriceFromCorrect && isPriceToCorrect
                && isRentalPeriodCorrect && isSmokingCorrect && isAlcoholCorrect && isPetsCorrect && isPurityCorrect;
        }

        public MyPreferencesPage CleanMyPreferences()
        {
            var btnGenderNeighbour = new WebItem("//select[@name='preferences[gender]']", "Выбор пола соседа - Не важно");
            btnGenderNeighbour.Click();
            btnGenderNeighbour.SendKeys(Keys.ArrowUp);
            var btnAgeFromNeighbour = new WebItem("//input[@name='preferences[age_range][min]']", "Ввод минимального возраста соседа");
            btnAgeFromNeighbour.Click();
            btnAgeFromNeighbour.SendKeys(Keys.Control + "a");
            btnAgeFromNeighbour.SendKeys(Keys.Delete);
            var btnAgeToNeighbour = new WebItem("//input[@name='preferences[age_range][max]']", "Очиста поля максимального возраста соседа");
            btnAgeToNeighbour.Click();
            btnAgeToNeighbour.SendKeys(Keys.Control + "a");
            btnAgeToNeighbour.SendKeys(Keys.Delete);
            var btnHousingType = new WebItem("//select[@name='preferences[housing_type]']", "Выбор типа жилья - Не важно");
            btnHousingType.Click();
            btnHousingType.SendKeys(Keys.ArrowUp);
            var btnPriceFrom = new WebItem("//input[@name='preferences[budget][min]']", "Очиста поля минимального бюджета");
            btnPriceFrom.Click();
            btnPriceFrom.SendKeys(Keys.Control + "a");
            btnPriceFrom.SendKeys(Keys.Delete);
            var btnPriceTo = new WebItem("//input[@name='preferences[budget][max]']", "Очиста поля максимального бюджета");
            btnPriceTo.Click();
            btnPriceTo.SendKeys(Keys.Control + "a");
            btnPriceTo.SendKeys(Keys.Delete);
            var btnRentalPeriod = new WebItem("//select[@name='preferences[lease_term]']", "Выбор срока аренды - Не важно");
            btnRentalPeriod.Click();
            btnRentalPeriod.SendKeys(Keys.ArrowUp);
            var btnSmoking = new WebItem("//select[@name='preferences[smoking]']", "Выбор  Курение - Не Важно");
            btnSmoking.Click();
            btnSmoking.SendKeys(Keys.ArrowUp);
            var btnAlcohol = new WebItem("//select[@name='preferences[alcohol]']", "Выбор  Алкоголь - Не Важно");
            btnAlcohol.Click();
            btnAlcohol.SendKeys(Keys.ArrowUp);
            var btnPets = new WebItem("//select[@name='preferences[pets]']", "Выбор  Домашние животные - Не Важно");
            btnPets.Click();
            btnPets.SendKeys(Keys.ArrowUp);
            var btnPurity = new WebItem("//select[@name='preferences[cleanliness]']", "Выбор  Чистота - Не важно");
            btnPurity.Click();
            btnPurity.SendKeys(Keys.ArrowUp);
            var btnSaveMyPreferences = new WebItem("//button[@name='save_preferences']", "Кнопка сохранения предпочтений");
            btnSaveMyPreferences.Click();
            return new MyPreferencesPage();
        }
    }
}
