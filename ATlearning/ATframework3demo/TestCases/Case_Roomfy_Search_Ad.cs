using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using ATframework3demo.BaseFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.TestCases
{
    public class Case_Roomfy_Search_Ad
    {
        public class Case_Roomfy_Search_Adds: CaseCollectionBuilder
        {
            protected override List<TestCase> GetCases()
            {
                var caseCollection = new List<TestCase>();
                caseCollection.Add(new TestCase("Roomfy - Поиск объявления через страницу \"Поиск\"", homePage => PortalHomePageRoomfy(homePage)));
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
                    //Необходимо в начале создать объявление, чтобы потом его найти
                    //Заполнить поле населенного пункта
                    var CityUpdate = homePage
                        .CityUpdate(city);
                    var SearchAd = homePage
                    //Нажать кнопку "+Создать объявление"
                        .CreateAd()
                    //Заполнить форму "Создать объявление" и нажать "Далее"
                        .FillFormAd(title, description, city, street, housenumber)
                    //Заполнить форму мои предпочтения и опубликовать объявление
                        .FillFormPreferences(agefrom, ageto, pricefrom, priceto);
                    var SearchAd_2 = homePage
                        //Перейти на страницу поиск
                        .OpenSearchAd()
                        //Заполнить фильт поиска и нажать кнопку "Поиск"
                        .SearchFillFormPreference(agefrom, ageto, pricefrom, priceto)
                        //Проверка, что объявление нашлось
                        .AlertSearchAd(title);
                }
            }
        }
    }
}
