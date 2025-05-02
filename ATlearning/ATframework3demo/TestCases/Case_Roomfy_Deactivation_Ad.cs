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
                    var title = new RoomfyDeactivationAd { Title = "Срочно ищу квартиру" + salt };
                    var description = new RoomfyDeactivationAd { Description = "Я очень спокойный сосед" + HelperMethods.GetDateTimeSaltString() };
                    //Необходимо в начале создать объявление, чтобы в дальнейшем его деактивировать 
                    var DeactivationAd = homePage
                    //Нажать кнопку "+Создать объявление"
                        .CreateAd_1()
                    //Заполнить форму "Создать объявление" и нажать "Далее"
                        .FillFormAd_1(title, description)
                    //Отправить форму мои предпочтения
                        .FillFormPreferences_1();
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
