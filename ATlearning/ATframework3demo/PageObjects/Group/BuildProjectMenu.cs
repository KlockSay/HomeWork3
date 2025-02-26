
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Group
{
    public class BuildProjectMenu
    {
        public BuildProjectMenu ChooseType()
        {
            var createProjectFrame = new WebItem("//iframe[@class='side-panel-iframe']", "Фрейм создания проекта");
            createProjectFrame.SwitchToFrame();
            var projectType = new WebItem("//div[@data-bx-project-type='project']", "Выбор типа проекта");
            projectType.Click();
            var btnContinue = new WebItem("//button[@id='sonet_group_create_popup_form_button_submit']", "Кнопка 'Продолжить'");
            btnContinue.Click();
            WebDriverActions.SwitchToDefaultContent();
            return new BuildProjectMenu();
        }

        public BuildProjectMenu SetNameProject(Bitrix24Projects NameProject)
        {
            var createProjectFrame = new WebItem("//iframe[@class='side-panel-iframe']", "Фрейм создания проекта");
            createProjectFrame.SwitchToFrame();
            var inputProjectName = new WebItem("//input[@id='GROUP_NAME_input']", "Ввод названия проекта");
            inputProjectName.SendKeys(NameProject.NameProjects);
            var btnContinue = new WebItem("//button[@id='sonet_group_create_popup_form_button_submit']/span", "Кнопка Продолжить");
            btnContinue.Click();
            WebDriverActions.SwitchToDefaultContent();
            return new BuildProjectMenu();
            
        }

        public BuildProjectMenu ChooseLvlPrivacy()
        {
            var createProjectFrame = new WebItem("//iframe[@class='side-panel-iframe']", "Фрейм создания проекта");
            createProjectFrame.SwitchToFrame();
            var typePrivacy = new WebItem("//div[@data-bx-confidentiality-type='open']", "Тип конфиденциальности 'Открытый'");
            typePrivacy.Click();
            var btnContinue = new WebItem("//button[@id='sonet_group_create_popup_form_button_submit']/span", "Кнопка 'Продолжить'");
            btnContinue.Click();
            WebDriverActions.SwitchToDefaultContent();
            return new BuildProjectMenu();
        }

        public PageProjects SetNameMembers()
        {
            var createProjectFrame = new WebItem("//iframe[@class='side-panel-iframe']", "Фрейм создания проекта");
            createProjectFrame.SwitchToFrame();
            var btnContinue = new WebItem("//button[@id='sonet_group_create_popup_form_button_submit']/span", "Кнопка Продолжить");
            btnContinue.Click();
            WebDriverActions.SwitchToDefaultContent();
            return new PageProjects();
        }
    }
}
