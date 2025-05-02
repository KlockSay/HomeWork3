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
                    var title = new RoomfySearchAd { Title = "Срочно ищу квартиру" + HelperMethods.GetDateTimeSaltString() };
                    var description = new RoomfySearchAd { Description = "Я очень спокойный сосед" + HelperMethods.GetDateTimeSaltString() };
                    var city = new RoomfySearchAd { City = "Калининград" };
                    var street = new RoomfySearchAd { Street = "Юбилейная улица" };
                    var housenumber = new RoomfySearchAd { HouseNumber = "16к1" };
                    var agefrom = new RoomfySearchAd { AgeFrom = "20" };
                    var ageto = new RoomfySearchAd { AgeTo = "25" };
                    var pricefrom = new RoomfySearchAd { PriceFrom = "10000" };
                    var priceto = new RoomfySearchAd { PriceTo = "15000" };
                    //Необходимо в начале создать объявление, чтобы потом его найти
                    //Заполнить поле населенного пункта
                    var CityUpdate = homePage
                        .CityUpdate_2(city);
                    var SearchAd = homePage
                    //Нажать кнопку "+Создать объявление"
                        .CreateAd_2()
                    //Заполнить форму "Создать объявление" и нажать "Далее"
                        .FillFormAd_2(title, description, city, street, housenumber)
                    //Заполнить форму мои предпочтения и опубликовать объявление
                        .FillFormPreferences_2(agefrom, ageto, pricefrom, priceto);
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
