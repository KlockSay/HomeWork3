using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using ATframework3demo.BaseFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.TestCases
{
    public class Case_Roomfy_Create_Ad
    {
        public class Case_Roomfy_Create_Adds: CaseCollectionBuilder
        {
            protected override List<TestCase> GetCases()
            {
                var caseCollection = new List<TestCase>();
                caseCollection.Add(new TestCase("Roomfy - Создание объявления через кнопку \"+Создать объявление\"", homePage => PortalHomePageRoomfy(homePage)));
                return caseCollection;

                void PortalHomePageRoomfy(PortalHomePage homePage)
                {
                    var title = new RoomfyCreateAd { Title = "Срочно ищу квартиру" + HelperMethods.GetDateTimeSaltString() };
                    var description = new RoomfyCreateAd { Description = "Я очень спокойный сосед" + HelperMethods.GetDateTimeSaltString() };
                    var city = new RoomfyCreateAd { City = "Калининград" };
                    var street = new RoomfyCreateAd { Street = "Юбилейная улица" };
                    var housenumber = new RoomfyCreateAd { HouseNumber = "16к1" };
                    var agefrom = new RoomfyCreateAd { AgeFrom = "20" };
                    var ageto = new RoomfyCreateAd { AgeTo = "25" };
                    var pricefrom = new RoomfyCreateAd { PriceFrom = "10000" };
                    var priceto = new RoomfyCreateAd { PriceTo = "15000" };
                    //Заполнить поле населенного пункта
                    var CityUpdate = homePage
                        .CityUpdate(city);
                    var NewAd = homePage
                    //Нажать кнопку "+Создать объявление"
                        .CreateAd()
                    //Заполнить форму "Создать объявление" и нажать "Далее"
                        .FillFormAd(title, description, city, street, housenumber)
                    //Заполнить форму мои предпочтения и опубликовать объявление
                        .FillFormPreferences(agefrom, ageto, pricefrom, priceto)
                    //Перейти в созданное объявление
                        .OpenAd()
                    //Проверка того, что название 
                        .AssertAd(title);
                }
            }
        }
    }
}
