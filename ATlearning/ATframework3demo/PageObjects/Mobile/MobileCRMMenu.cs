
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    public class MobileCRMMenu
    {
        public ChooseCRM CreateCRM()
        {
            var create_crmTab = new MobileItem("//android.widget.TextView[@resource-id=\"com.bitrix24.android:id/tag\"]",
               "Таб '+'");
            create_crmTab.Click();
            return new ChooseCRM();
        }
    }
}
