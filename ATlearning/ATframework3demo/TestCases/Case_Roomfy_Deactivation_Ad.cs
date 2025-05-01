using System;
using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using ATframework3demo.BaseFramework;
using ATframework3demo.TestEntities;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ATframework3demo.TestCases
{
    public class Case_Roomfy_Deactivation_Ad
    {
        public class Case_Roomfy_Deactivation_Ads : CaseCollectionBuilder
        {
            protected override List<TestCase> GetCases()
            {
                var caseCollection = new List<TestCase>();
                caseCollection.Add(new TestCase("Roomfy - Деактивация объявления пользователя", homePage => PortalHomePageRoomfy(homePage)));
                return caseCollection;

                void PortalHomePageRoomfy(PortalHomePage homePage)
                {
                    
                    string salt = HelperMethods.GetDateTimeSaltString();
                    var title = new RoomfyCreateAd { Title = "Срочно ищу квартиру" + salt };
                    var description = new RoomfyCreateAd { Description = "Я очень спокойный сосед" + HelperMethods.GetDateTimeSaltString() };
                    var city = new RoomfyCreateAd { City = "Калининград" };
                    var street = new RoomfyCreateAd { Street = "Юбилейная улица" };
                    var housenumber = new RoomfyCreateAd { HouseNumber = "16к1" };
                    var agefrom = new RoomfyCreateAd { AgeFrom = "20" };
                    var ageto = new RoomfyCreateAd { AgeTo = "25" };
                    var pricefrom = new RoomfyCreateAd { PriceFrom = "10000" };
                    var priceto = new RoomfyCreateAd { PriceTo = "15000" };
                    //Необходимо в начале создать объявление, чтобы в дальнейшем его деактивировать 
                    //Заполнить поле населенного пункта
                    var CityUpdate = homePage
                        .CityUpdate(city);
                    var DeactivationAd = homePage
                    //Нажать кнопку "+Создать объявление"
                        .CreateAd()
                    //Заполнить форму "Создать объявление" и нажать "Далее"
                        .FillFormAd(title, description, city, street, housenumber)
                    //Заполнить форму мои предпочтения и опубликовать объявление
                        .FillFormPreferences(agefrom, ageto, pricefrom, priceto);
                    //Перейти на страницу "Мои объявления"
                    var DeactivationAd_2 = homePage
                        .ActiveAds()
                    //Найти созданное объявление и деактивировать его
                        .DeactivationAds(title)
                    //Перейти в раздел раздел "Неактивные" 
                        .NoActiveAds()
                    //Найти деактивированное объявление
                        .AelertDeactivationAd(title);
                }
            }
        }
    }
}
