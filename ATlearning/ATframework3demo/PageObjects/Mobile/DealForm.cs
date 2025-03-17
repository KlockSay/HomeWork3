
using System.Xml.Linq;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Mobile
{
    public class DealForm
    {
        public InputNameDealForm ClickName()
        {
            var nameTab = new MobileItem("//android.view.ViewGroup[@content-desc=\"deal_0_details_editor_TITLE_NAME_container\"]",
                "Таб 'NameDeal'");
            nameTab.Click();
            return new InputNameDealForm();
        }

        public DealForm InputAmmount(Bitrix24Deal ammount)
        {
            var InputAmmountTab = new MobileItem("//android.widget.EditText[@text=\"0\"]",
                "Поле ввода суммы сделки");
            InputAmmountTab.Click();
            InputAmmountTab.SendKeys(ammount.Ammount);
            return new DealForm();
        }

        public AddContactForm AddContact()
        {
            var AddContactClick = new MobileItem("//android.widget.TextView[@text=\"Add contact\"]",
               "Кнопка добавить контакт");
            AddContactClick.Click();
            return new AddContactForm();
        }

        public InfoDeal CreateDeal()
        {
            var CreateDealClick = new MobileItem("//android.widget.TextView[@text=\"Create\"]",
               "Кнопка создать сделку");
            CreateDealClick.Click();
            return new InfoDeal();
        }
    }
}