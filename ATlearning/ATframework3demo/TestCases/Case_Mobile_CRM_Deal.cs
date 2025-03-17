using atFrameWork2.BaseFramework;
using atFrameWork2.TestEntities;
using ATframework3demo.PageObjects.Mobile;
using atFrameWork2.BaseFramework.LogTools;
using ATframework3demo.BaseFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.TestCases
{
    public class Case_Mobile_CRM_Deal : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(
                new TestCase("Создание сделки в CRM", mobileHomePage => CreateCRMCreateDeal(mobileHomePage)));
            return caseCollection;
        }

        void CreateCRMCreateDeal(MobileHomePage homePage)
        {
            var name = new Bitrix24Deal { Name = "Name" + HelperMethods.GetDateTimeSaltString() };
            var ammount = new Bitrix24Deal { Ammount = "1" + HelperMethods.GetDateTimeSaltString() };
            var isTaskPresent = homePage.TabsPanel
                //Нажать на More
                .SelectMore()
                //перейти в раздел CRM
                .SelectCRM()
                //Нажать создать CRM
                .CreateCRM()
                //Выбрать Deal в открывшимся окне
                .ChooseDeal()
                //Кликнуть на имя сделки
                .ClickName()
                //Ввести имя и сохранить
                .InputName(name)
                //Ввести сумму
                .InputAmmount(ammount)
                //Нажать добавить контакт
                .AddContact()
                //Выбрать контакт и сохранить
                .AddandSaveContact()
                //Нажать кнопку Create
                .CreateDeal()
                //Проверка созданной сделки
                .AssertDeal(name);
        }
    }
}