using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.BaseFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.TestCases
{
    public class Case_Bitrix24_Comment
    {
        public class Case_Bitrix24_Comments : CaseCollectionBuilder
        {
            protected override List<TestCase> GetCases()
            {
                var caseCollection = new List<TestCase>();
                caseCollection.Add(new TestCase("Создание комментария от другого юзера под постом в ленте", homePage => CreateDeal(homePage)));
                return caseCollection;
            }
            //Создание комментария от другого юзера под постом в ленте
            void CreateDeal(PortalHomePage homePage)
            {
                var comment = new Bitrix24Comments { Comment = "Comment" + HelperMethods.GetDateTimeSaltString()};
                var newmessange = new Bitrix24Comments { NewMessage = "Message" + HelperMethods.GetDateTimeSaltString()};
                //создание нового пользователя 
                var newUser = TestCase.RunningTestCase.CreatePortalTestUser(false);
                //нажать на "Написать сообщение..."
                homePage
                    .NewMessage()
                //написать сообщение
                    .SetMessage(newmessange)
                //отправить сообщение
                    .SendMessage()
                //проверить, что пост создан
                    .AssertPostField(newmessange);
                //логинимся новым пользователем
                WebItem.DefaultDriver.Quit();
                WebItem.DefaultDriver = default;
                new PortalLoginPage(TestCase.RunningTestCase.TestPortal)
                    .Login(newUser)
                //под добавленной новостью нажимаем кнопку "Добавить комментарий"
                    .AddComment()
                //написать комментарий
                    .SetComment(comment)
                //отправить комментарий
                    .SendComment()
                //проверить, что комментарий создан
                    .AssertCommentField(comment);




            }
        }
    }
}
