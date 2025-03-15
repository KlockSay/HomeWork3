
using atFrameWork2.SeleniumFramework;
using Microsoft.VisualBasic;

namespace ATframework3demo.PageObjects.Automatization
{
    public class GeneralTemplateParameters
    {
        public ConstantsList OutgoingDocumentConstants()
        {
            var btnConstantsList = new WebItem("//span[@id='tab_cont_edit5']", "Кнопка константы");
            btnConstantsList.Click();
            return new ConstantsList();
        }
    }
}
