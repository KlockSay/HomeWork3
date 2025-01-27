using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
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
            void CreateDeal(PortalHomePage homePage)
            {
                var comment = new Bitrix24Comments { Comment = "Comment" };
                //нажать на "Написать сообщение..."
                homePage
                    .NewMessage()
                //написать сообщение
                    .SetMessage()
                //отправить сообщение
                    .SendMessage()
                //переходим в верхнее меню
                    .OpenUpMenu()
                //нажимаем кнопку "Выйти"
                    .Exit()
                //очищаем поле Логин
                    .CleanLogin()
                //логинимся новым пользователем
                    .LoginNewUser()
                //под добавленной новостью нажимаем кнопку "Добавить комментарий"
                    .AddComment()
                //написать комментарий
                    .SetComment(comment)
                //отправить комментарий
                    .SendComment()
                //переходим в верхнее меню
                    .OpenUpMenu()
                //нажимаем кнопку "Выйти"
                    .Exit()
                //очищаем поле Логин
                    .CleanLogin()
                //логинимся админом
                    .LoginAdmin()
                //проверить, что комментарий создан
                    .AssertCommentField(comment);




            }
        }
    }
}
