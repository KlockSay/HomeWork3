using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects;
using ATframework3demo.PageObjects.roomfy.Adds;
using ATframework3demo.PageObjects.roomfy.AuthorizationAndRegistration;
using ATframework3demo.PageObjects.roomfy.MyAds;
using ATframework3demo.PageObjects.roomfy.MyProfileSettings;
using ATframework3demo.PageObjects.roomfy.Search;
using ATframework3demo.TestEntities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace atFrameWork2.PageObjects
{
    public class PortalHomePage
    {
        public IWebDriver Driver { get; }

        public PortalHomePage(IWebDriver driver = default)
        {
            Driver = driver;
        }

        public PortalLeftMenu LeftMenu => new PortalLeftMenu(Driver);

        WebItem NewMessageButton =>
            new WebItem("//div[@id='microoPostFormLHE_blogPostForm_inner']", 
                "Область в новостях 'Написать сообщение'");
        public NewsPostForm NewMessage()
        {
            NewMessageButton.Click();
            return new NewsPostForm(Driver);
        }
        WebItem NewCommentButton =>
            new WebItem("//div[contains(@id, 'record-BLOG')]/../div[@class='feed-com-footer']/div/a",
                "Область написание комментария");
        public PolComment AddComment()
        {
            NewCommentButton.Click();
            return new PolComment();
        }

        public bool AssertPostField(Bitrix24Comments newmessange)
        {
            return new WebItem($"//div[@class='feed-post-text'][text()= '{newmessange.NewMessage}']", "Текст поста").AssertTextContains(newmessange.NewMessage, "Поста нет");


        }

        public bool AssertCommentField(Bitrix24Comments comment)
        {
            return new WebItem($"//div[@class='feed-com-text-inner-inner']/div[text()= '{comment.Comment}']", "Текст комментария").AssertTextContains(comment.Comment, "Комментарий не корректный");

        }

        public MyProfilePage OpenMyProfile()
        {
            var btnHuman = new WebItem("//div[@class='navbar-item has-dropdown is-hoverable']", "Нажать на иконку Человечка");
            btnHuman.Click();
            var btnMyProfile = new WebItem("//a[@href='/profile']", "Кнопка Мой профиль");
            btnMyProfile.Click();
            return new MyProfilePage();
        }

        public MyPreferencesPage OpenMyPreferences()
        {
            var btnHuman = new WebItem("//div[@class='navbar-item has-dropdown is-hoverable']", "Нажать на иконку Человечка");
            btnHuman.Click();
            var btnMyProfile = new WebItem("//a[@href='/profile']", "Кнопка Мой профиль");
            btnMyProfile.Click();
            var btnMyPreferences = new WebItem("//a[@href='?tab=preferences']", "Кнопка Мой профиль");
            btnMyPreferences.Click();
            return new MyPreferencesPage();
        }

        public LoginPage ExitMyAccount()
        {
            var btnHuman = new WebItem("//div[@class='navbar-item has-dropdown is-hoverable']", "Нажать на иконку Человечка");
            btnHuman.Click();
            var btnExit = new WebItem("//a[contains(@href, '/?logout=yes&sessid=')]", "Кнопка Мой профиль");
            btnExit.Click();
            return new LoginPage();
        }

        public AddCreatePage CreateAd()
        {
            var btnCreateAdd = new WebItem("//a[@href='/add']", "Нажать кнопку '+Создать объявление'");
            btnCreateAdd.Click();
            return new AddCreatePage();
        }

        public PortalHomePage CityUpdate(RoomfyCreateAd city)
        {
            var btnCity = new WebItem("//input[@id='cityInput']", "Ввести город");
            btnCity.Click();
            btnCity.SendKeys(Keys.Control + "a");
            btnCity.SendKeys(Keys.Delete);
            btnCity.SendKeys(city.City);
            return new PortalHomePage();
        }

        public SearchPage OpenSearchAd()
        {
            var btnCity = new WebItem("//a[@href='/search']", "Кнопка 'Поиск'");
            btnCity.Click();
            return new SearchPage();
        }

        public ActiveAdsPage ActiveAds()
        {
            var btnHuman = new WebItem("//div[@class='navbar-item has-dropdown is-hoverable']", "Нажать на иконку Человечка");
            btnHuman.Click();
            var btnExit = new WebItem("//a[@href='/my-posts']", "Кнопка Мой объявления");
            btnExit.Click();
            return new ActiveAdsPage();
        }
    }
}
