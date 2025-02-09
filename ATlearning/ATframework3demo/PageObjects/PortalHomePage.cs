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
    }
}
