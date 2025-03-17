
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    public class ChooseCRM
    {
        public DealForm ChooseDeal()
        {
            var dealTab = new MobileItem("//android.view.ViewGroup[@content-desc=\"CRM_ENTITY_TAB_DEAL_CONTEXT_MENU_2\"]/android.view.ViewGroup[1]",
                "Таб 'CRM'");
            dealTab.Click();
            return new DealForm();
        }
    }
}
