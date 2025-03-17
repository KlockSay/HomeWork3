
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Mobile
{
    public class InfoDeal
    {
        public bool AssertDeal(Bitrix24Deal name)
        {
            return new WebItem($"//android.widget.TextView[@content-desc='{name.Name}']", "Имя сделки").AssertTextContains(name.Name, "Имя сделки не корректное");
        }
    }
}
