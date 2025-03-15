

using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automatization
{
    public class AutomatizationPage
    {
        public BusinessProcessSelection ButtonStart()
        {
            var btnBusinessProcessSelection = new WebItem("//div[@class='ui-toolbar-after-title-buttons']", "Кнопка выбора запуска бизнес-процесса");
            btnBusinessProcessSelection.Click();
            return new BusinessProcessSelection();
        }

        public BusinessProcessMenu BusinessProcessUpMenu()
        {
            var btnBussnesProsess = new WebItem("//div[@id='top_menu_id_automation_menu_bizproc_sect']", "Верняя кнопка бизнесс процессы");
            btnBussnesProsess.Click();
            return new BusinessProcessMenu();
        }
    }
}
