
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    public class AddContactForm
    {
        public DealForm AddandSaveContact()
        {
            var ChooseContact = new MobileItem("//android.widget.ImageView[@content-desc=\"check_off\"]",
              "Выбор контакта");
            ChooseContact.Click();
            var SaveContact = new MobileItem("//android.widget.TextView[@text=\"Select\"]",
              "Сохранить крнтакт");
            return new DealForm();
        }
    }
}
