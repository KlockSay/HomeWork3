
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;
using OpenQA.Selenium;

namespace ATframework3demo.PageObjects.roomfy.Adds
{
    public class AddCreatePage
    {
        public PreferencesFormCreateAd FillFormAd(RoomfyCreateAd title, RoomfyCreateAd description, RoomfyCreateAd city, RoomfyCreateAd street, RoomfyCreateAd housenumber)
        {
            var btnTypeAd = new WebItem("//select[@name='post_type_id']", "Выбрать тип объявления - Ищу квартиру");
            btnTypeAd.Click();
            btnTypeAd.SendKeys(Keys.ArrowDown);
            var btnTitleAd = new WebItem("//input[@id='title-input']", "Ввести название объявления");
            btnTitleAd.Click();
            btnTitleAd.SendKeys(title.Title);
            var btnDescriptionAd = new WebItem("//textarea[@name='description']", "Ввести описание объявления");
            btnDescriptionAd.Click();
            btnDescriptionAd.SendKeys(description.Description);
            var btnStreet = new WebItem("//input[@id='street-input']", "Ввести улицу");
            btnStreet.Click();
            btnStreet.SendKeys(Keys.Control + "a");
            btnStreet.SendKeys(Keys.Delete);
            btnStreet.SendKeys(street.Street);
            var btnHouseNumber = new WebItem("//input[@id='house-input']", "Ввести номер дома");
            btnHouseNumber.Click();
            btnHouseNumber.SendKeys(housenumber.HouseNumber);
            var btnNext = new WebItem("//button[@id='submit-post']", "Ввести номер дома");
            btnNext.Click();
            return new PreferencesFormCreateAd();
        }
    }
}
