
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects.roomfy.MyProfileSettings;
using ATframework3demo.TestEntities;
using OpenQA.Selenium;

namespace ATframework3demo.PageObjects.roomfy.AuthorizationAndRegistration
{
    public class LoginPage
    {
        public PortalHomePage LoginToAccountNewPassword(RoomfyChangingPassword login, RoomfyChangingPassword newpassword)
        {
            var btnLogin = new WebItem("//input[@name='USER_LOGIN']", "Поле ввода логина");
            btnLogin.Click();
            btnLogin.SendKeys(Keys.Control + "a");
            btnLogin.SendKeys(Keys.Delete);
            btnLogin.SendKeys(login.Login);
            var btnNewPassword = new WebItem("//input[@name='USER_PASSWORD']", "Поле ввода измененного пароля");
            btnNewPassword.Click();
            btnNewPassword.SendKeys(newpassword.NewPassword);
            var btnGetAccount = new WebItem("//button[@class='button is-primary is-fullwidth']", "Кнопка Войти");
            btnGetAccount.Click();
            return new PortalHomePage();
        }

        public PortalHomePage LoginToAccountOldPassword(RoomfyChangingPassword login, RoomfyChangingPassword oldpassword)
        {
            var btnLogin = new WebItem("//input[@name='USER_LOGIN']", "Поле ввода логина");
            btnLogin.Click();
            btnLogin.SendKeys(Keys.Control + "a");
            btnLogin.SendKeys(Keys.Delete);
            btnLogin.SendKeys(login.Login);
            var btnOldPassword = new WebItem("//input[@name='USER_PASSWORD']", "Поле ввода измененного пароля");
            btnOldPassword.Click();
            btnOldPassword.SendKeys(oldpassword.OldPassword);
            var btnGetAccount = new WebItem("//button[@class='button is-primary is-fullwidth']", "Кнопка Войти");
            btnGetAccount.Click();
            return new PortalHomePage();
        }
    }
}
