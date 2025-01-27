using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects;
using ATframework3demo.TestEntities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
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

        public NewsPage NewMessage()
        {
            throw new NotImplementedException();
            return new NewsPage();
        }

        public GeneralUpMenu OpenUpMenu()
        {
            throw new NotImplementedException();
            return new GeneralUpMenu();
        }

        public PolComment AddComment()
        {
            throw new NotImplementedException();
            return new PolComment();
        }

        public PortalHomePage LoginAdmin()
        {
            throw new NotImplementedException();
            return new PortalHomePage();
        }

        public bool AssertCommentField(Bitrix24Comments comment)
        {
            new WebItem("//path", "Комментарий").AssertTextContains(comment.Comment, "Комментарий не корректный");
            throw new NotImplementedException();
        }
    }
}
