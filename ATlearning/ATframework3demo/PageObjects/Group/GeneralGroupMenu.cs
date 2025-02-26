
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Group
{
    public class GeneralGroupMenu
    {
        public BuildProjectMenu BuildProject()
        {
            var btnCreate = new WebItem("//a[@id='projectAddButton']", "Кнопка создать на странице групп");
            btnCreate.Click();
            return new BuildProjectMenu();
        }

      
        public PageProjects OpenProjects(Bitrix24Projects NameProject)
        {
            var btnProjectOpen = new WebItem($"//a[@class='sonet-group-grid-name-text'][text()='{NameProject.NameProjects}']",
                $"Открыть страницу проекта '{NameProject.NameProjects}'");
            btnProjectOpen.Click();
            return new PageProjects();
        }
    }
}
