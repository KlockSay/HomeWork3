using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using ATframework3demo.TestEntities;

namespace ATframework3demo.TestCases
{
    public class Case_Roomfy_Changing_User_Password
    {
        public class Case_Roomfy_Changing_User_Passwords : CaseCollectionBuilder
        {
            protected override List<TestCase> GetCases()
            {
                var caseCollection = new List<TestCase>();
                caseCollection.Add(new TestCase("Roomfy - Смена пароля пользователя через раздел \"Личный профиль\" на странице \"Мой профиль\"", homePage => PortalHomePageRoomfy(homePage)));
                return caseCollection;

                void PortalHomePageRoomfy(PortalHomePage homePage)
                {
                    var newpassword = new RoomfyChangingPassword { NewPassword = "/Password228/" };
                    var oldpassword = new RoomfyChangingPassword { OldPassword = "/Semibratova228/" };
                    var login = new RoomfyChangingPassword { Login = "Klokovskih@yandex.ru" };
                    var datebd = new RoomfyChangingPassword { DateBD = "04112000" };
                    var ChangingPassword_1 = homePage
                    // прейти на страницу "Мои профиль"
                        .OpenMyProfile()
                    //сменить пароль и сохранить изменения
                        .NewChangePassword(newpassword, datebd);
                    var ChangingPassword_2 = homePage 
                    //выйти из аккаунта
                        .ExitMyAccount()
                    //войти в аккаунт с новым паролем (проверка, что пароль изменен)
                        .LoginToAccountNewPassword(login, newpassword)
                    //перейти на страницу "Мой профиль"
                        .OpenMyProfile()
                    //вернуть старый пароль
                        .OldChangePassword(oldpassword);
                    var ChangingPassword_3 = homePage
                    //выйти из аккаунта
                        .ExitMyAccount()
                    //войти в аккаунт со старым паролем
                        .LoginToAccountOldPassword(login, oldpassword);
                }
            }
        }
    }
}
