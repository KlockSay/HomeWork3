using System.Security.Cryptography.Xml;
using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using ATframework3demo.TestEntities;

namespace ATframework3demo.TestCases
{
    public class Case_Roomfy_My_Profile_Personal_Preferences
    {
        public class Case_Roomfy_My_Profile_Personal_Preference : CaseCollectionBuilder
        {
            protected override List<TestCase> GetCases()
            {
                var caseCollection = new List<TestCase>();
                caseCollection.Add(new TestCase("Roomfy - Заполнение формы \"Мои предпочтения\" на странице \"Мой профиль\"", homePage => PortalHomePageRoomfy(homePage)));
                return caseCollection;

                void PortalHomePageRoomfy(PortalHomePage homePage)
                {
                    var agefrom = new RoomfyMyProfilePersonal { AgeFrom = "20" };
                    var ageto = new RoomfyMyProfilePersonal { AgeTo = "25" };
                    var pricefrom = new RoomfyMyProfilePersonal { PriceFrom = "10000" };
                    var priceto = new RoomfyMyProfilePersonal { PriceTo = "15000" };
                    var MyPreferences_1 = homePage
                    // прейти на страницу "Мои предпочтения"
                    .OpenMyPreferences()
                    // заполнить форму "Мои предпочтения"
                    .FillMyPreferences(agefrom, ageto, pricefrom, priceto)
                    // проверка заполненной формы
                    .AssertMyPreferences(agefrom, ageto, pricefrom, priceto);
                    //Очистить разрешенные поля
                    var MyPreferences_2 = homePage
                        .OpenMyPreferences()
                        .CleanMyPreferences();

                }

            }

        }
    }
}