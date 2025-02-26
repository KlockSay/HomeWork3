using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.BaseFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.TestCases
{
    public class Case_Bitrix24_Project
    {
        public class Case_Bitrix24_Projects : CaseCollectionBuilder
        {
            protected override List<TestCase> GetCases()
            {
                var caseCollection = new List<TestCase>();
                caseCollection.Add(new TestCase("Создание проекта и добовление поста в ленту проекта", homePage => CreateProjectPost(homePage)));
                return caseCollection;

                void CreateProjectPost(PortalHomePage homePage)
                {
                    var NameProject = new Bitrix24Projects { NameProjects = "Projects" + HelperMethods.GetDateTimeSaltString() };
                    var NewsPost = new Bitrix24Projects { NewsPost = "Message" + HelperMethods.GetDateTimeSaltString() };

                    var groupPage = homePage
                        .LeftMenu
                        // перейти на главную страницу "Группы"
                        .GroupOpen()
                        //нажать кнопку "Создать", чтобы создать проект
                        .BuildProject()
                        //выбрать тип проекта
                        .ChooseType()
                        //ввод и отправка названия проекта 
                        .SetNameProject(NameProject)
                        //выбор уровня конфеденциальности
                        .ChooseLvlPrivacy()
                        //добавление участников
                        .SetNameMembers()
                        //перейти на странице проекта в создание поста
                        .CreateProjectPost()
                        //написать пост в проекте
                        .AddPost(NewsPost)
                        //отправить пост
                        .SendPost();
                    //обновить страницу
                    WebDriverActions.Refresh();
                    //проверка наличия проекта и поста в нем
                    var projectPage = homePage
                        .LeftMenu
                        //перейти на главную страницу групп
                        .GroupOpen()
                        //открытие проекта, который был создан
                        .OpenProjects(NameProject)
                        //проверка наличия поста в ленте 
                        .AssertPost(NewsPost);

                }
            }
        }
    }
}