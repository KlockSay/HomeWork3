
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    public class MobileMoreListPage
    {
        public MobileCRMMenu SelectCRM()
        {
            var crmTab = new MobileItem("(//android.widget.LinearLayout[@content-desc=\"section_{Tools}\"])[3]",
                "Таб 'CRM'");
            crmTab.Click();
            return new MobileCRMMenu();
        }
    }
}
