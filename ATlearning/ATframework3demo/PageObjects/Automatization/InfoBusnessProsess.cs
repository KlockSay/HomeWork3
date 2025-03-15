
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Automatization
{
    public class InfoBusnessProsess
    {
        public bool AssertBussnesProsess(Bitrix24BussnessProsess newmessange)
        {
            return new WebItem($"//textarea[@name='PREVIEW_TEXT'][text()= '{newmessange.NewMessage}']", "Бизнесспроцесс запущен").AssertTextContains(newmessange.NewMessage, "Не работает");
        }
    }
}
