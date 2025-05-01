using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using ATframework3demo.BaseFramework;
using ATframework3demo.PageObjects.Automatization;
using ATframework3demo.PageObjects.roomfy;
using ATframework3demo.TestEntities;

namespace ATframework3demo.TestCases
{
    public class Case_Roomfy_Filling_Personal_Profile
    {
        public class Case_Roomfy_Filling_Personal_Profiles : CaseCollectionBuilder
        {
            protected override List<TestCase> GetCases()
            {
                var caseCollection = new List<TestCase>();
                caseCollection.Add(new TestCase("Roomfy - Заполнение формы \"Личный профиль\" на странице \"Мой профиль\"", homePage => PortalHomePageRoomfy(homePage)));
                return caseCollection;

                void PortalHomePageRoomfy(PortalHomePage homePage)
                {
                    var datebd = new RoomfyFillingPersonalProfile { DateBD = "04112000"};
                    var phone = new RoomfyFillingPersonalProfile { Phone = "+79522563055" };
                    var city = new RoomfyFillingPersonalProfile { City = "Калининград" };
                    var MyProfile = homePage
                        //Перейти в мой профиль
                        .OpenMyProfile()
                        //Заполнить сведения о пользователе и сохранить
                        .FillProfileForm(datebd, phone, city)
                        //Проверка сохранения изменений
                        .AssertProfileInfo(datebd, phone, city);
                    //Очиститить разрешенные поля
                    var MyProfile_2 = homePage
                        .OpenMyProfile()
                        .CleanMyProfile();
                        
                }

            }

        }
    }
}

