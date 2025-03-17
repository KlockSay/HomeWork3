
using System.Threading.Tasks;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Mobile
{
    public class InputNameDealForm
    {
        public DealForm InputName(Bitrix24Deal name)
        {
            var InputNameTab = new MobileItem("//android.widget.EditText[@text=\"Deal #\"]",
                "Поле ввода имени сделки");
            var InputNameSave = new MobileItem("//android.widget.TextView[@text=\"Save\"]",
                "Сохранить имя сделки");
            InputNameTab.Click();
            InputNameTab.SendKeys(name.Name);
            InputNameSave.Click();
            return new DealForm();
        }
    }
}
