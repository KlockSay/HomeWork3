using System.Reflection.Metadata;
using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.BaseFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.TestCases
{
    public class Case_Bitrix24_Business_Process_Outgoing_documents
    {
        public class Case_Bitrix24_Comment
        {
            public class Case_Bitrix24_Comments : CaseCollectionBuilder
            {
                protected override List<TestCase> GetCases()
                {
                    var caseCollection = new List<TestCase>();
                    caseCollection.Add(new TestCase("Запуск стандартного БП \"Исходящие документы\" через страницу Бизнес-процессы", homePage => StartOutgoingDocuments(homePage)));
                    return caseCollection;
                }
                //Запуск стандартного БП \"Исходящие документы\" через страницу Бизнес-процессы
                void StartOutgoingDocuments(PortalHomePage homePage)
                {
                    var newmessange = new Bitrix24BussnessProsess { NewMessage = "Message" + HelperMethods.GetDateTimeSaltString() };
                    var AutomatizationPage = homePage
                        .LeftMenu
                        //Перейти во вкладку "Автоматизация"
                        .AutomatizationOpen()
                        //Нажать кнопку запустить
                        .ButtonStart()
                        //Выбрать Бизнесс-процесс "Исходящие сообщения"
                        .ClickOutgoingDocuments()
                        //Заполнить форму Бизнесс-процесса "Исходящие сообщения"
                        .WriteInForm(newmessange); 
                    //Обновить страницу
                    WebDriverActions.Refresh();
                    var NewsPage = homePage
                        .LeftMenu
                        //Перейти в ленту новостей
                        .OpenNews()
                        //Перейти в созданный бизнесс процесс
                        .OpenBusnesProsess()
                        //Проверить, что текста текста сообщений совпадают, тем самым мы убедимся, что бизнесс процесс запущен
                        .AssertBussnesProsess(newmessange);
                    //Теперь необходимо очистить константу в шаблоне Бизнесс-процесса "Исходящие документы" 
                    //(кто фиксирует исходящий документ), чтобы автотест можно было заново выполнить
                    var AutomatizationPage_2 = homePage
                        .LeftMenu
                        //Перейти во вкладку "Автоматизация"
                        .AutomatizationOpen()
                        //Перейти в верхнюю вклдку Бизнесс-процессы
                        .BusinessProcessUpMenu()
                        //Перейти в меню "Процессы в ленте новостей"
                        .ProcessesInNewsFeed()
                        //Прейти в исодящие документы
                        .OutgoingDocuments()
                        //Перейти в меню настройки
                        .SettingsMenuBusinessProcess()
                        //Перейти в "Настроить Бизнесс-процессы"
                        .SettingBusinessProcess()
                        //Перейти в шаблон "Исходящие документы"
                        .SampleOutgoingDocuments()
                        //Перейти в параметры шаблона 
                        .TemplateParameters()
                        //Перейти в константы
                        .OutgoingDocumentConstants()
                        //Прейти в изменение константы "Кто фиксирует"
                        .WhoRecords()
                        //Очистить значение константы
                        .RemoveConstants()
                        //Сохранить значение новое константы
                        .SaveNewConstants()
                        //Сохранить параметры шаблона
                        .SaveSattingsTemplate()
                        //Применить изменения шаблона
                        .ApplyTemplateChanges()
                        //Все сохранить
                        .SaveTemplate();



                }

               
            }
        }
    }
}
