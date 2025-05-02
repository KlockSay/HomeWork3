

using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using ATframework3demo.TestEntities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace ATframework3demo.PageObjects.roomfy.MyProfileSettings
{
    public class MyProfilePage
    {

        public MyProfilePage FillProfileForm(RoomfyFillingPersonalProfile datebd, RoomfyFillingPersonalProfile phone, RoomfyFillingPersonalProfile city)
        {
            string imagePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName,"TestEntities", "photoprofile.jpg");
            var btnGender = new WebItem("//select[@name='PERSONAL_GENDER']", "Кнопка окна выбора пола"); 
            btnGender.Click();
            btnGender.SendKeys(Keys.ArrowDown);
            var btnBirth = new WebItem("//input[@id='birthday-datepicker']", "Поле ввода даты рождения");
            btnBirth.Click();
            btnBirth.SendKeys(datebd.DateBD);
            var btnPhone = new WebItem("//input[@name='PERSONAL_PHONE']", "Поле ввода номера телефона");
            btnPhone.Click();
            btnPhone.SendKeys(Keys.Control + "a");
            btnPhone.SendKeys(Keys.Delete);
            btnPhone.SendKeys(phone.Phone);
            var btnCity = new WebItem("//input[@name='PERSONAL_CITY']", "Поле ввода города");
            btnCity.Click();
            btnCity.SendKeys(city.City);
            var fileInput = new WebItem("//input[@type='file']", "Поле загрузки файла");
            fileInput.SendKeys(imagePath);
            var btnSavePersonalProfile = new WebItem("//button[@type='submit']", "Кнопка сохранения изменений");
            btnSavePersonalProfile.Click();

            return new MyProfilePage();
        }

        public bool AssertProfileInfo(RoomfyFillingPersonalProfile databd, RoomfyFillingPersonalProfile phone, RoomfyFillingPersonalProfile city)
        {
            
            bool isGenderCorrect = new WebItem("//select[@name='PERSONAL_GENDER']/option[@value='M']", "Выбранный пол")
                .GetAttribute("value").Equals("Мужской", StringComparison.OrdinalIgnoreCase);

            bool isBirthDateCorrect = new WebItem("//input[@id='birthday-datepicker']", "Поле даты рождения")
                .GetAttribute("value").Equals(databd.DateBD);

            bool isPhoneCorrect = new WebItem("//input[@name='PERSONAL_PHONE']", "Поле номера телефона")
                .GetAttribute("value").Equals(phone.Phone);

            bool isCityCorrect = new WebItem("//input[@name='PERSONAL_CITY']", "Поле города")
                .GetAttribute("value").Equals(city.City);

            var uploadedPhoto = new WebItem("//img[@class='is-rounded']", "Превью фото");
            bool isPhotoUploaded = !string.IsNullOrEmpty(uploadedPhoto.GetAttribute("src"));

            return isGenderCorrect && isBirthDateCorrect && isPhoneCorrect && isCityCorrect && isPhotoUploaded;
        }

        public MyProfilePage CleanMyProfile()
        {
            var btnGender = new WebItem("//select[@name='PERSONAL_GENDER']", "Кнопка окна выбора пола");
            btnGender.Click();
            btnGender.SendKeys(Keys.ArrowUp);
            var btnCity = new WebItem("//input[@name='PERSONAL_CITY']", "Поле ввода города");
            btnCity.Click();
            btnCity.SendKeys(Keys.Control + "a");
            btnCity.SendKeys(Keys.Delete);
            var btnPhotoDel = new WebItem("//input[@name='PERSONAL_PHOTO_del']", "Поле очистки фото профиля");
            btnPhotoDel.Click();
            var btnSavePersonalProfile = new WebItem("//button[@type='submit']", "Кнопка сохранения изменений");
            btnSavePersonalProfile.Click();
            return new MyProfilePage();
           
        }

        public MyProfilePage NewChangePassword(RoomfyChangingPassword newpassword, RoomfyChangingPassword datebd)
        {
            var btnBirth = new WebItem("//input[@id='birthday-datepicker']", "Поле ввода даты рождения");
            btnBirth.Click();
            btnBirth.SendKeys(datebd.DateBD);
            var btnChangePassword = new WebItem("//input[@name='NEW_PASSWORD']", "Поле ввода нового пароля");
            btnChangePassword.Click();
            btnChangePassword.SendKeys(newpassword.NewPassword);
            var btnChangePasswordRepeat = new WebItem("//input[@name='NEW_PASSWORD_CONFIRM']", "Поле повторного ввода нового пароля");
            btnChangePasswordRepeat.Click();
            btnChangePasswordRepeat.SendKeys(newpassword.NewPassword);
            var btnSavePersonalProfile = new WebItem("//button[@type='submit']", "Кнопка сохранения изменений");
            btnSavePersonalProfile.Click();
            return new MyProfilePage();
        }

        public MyProfilePage OldChangePassword(RoomfyChangingPassword oldpassword)
        {
            var btnChangePassword = new WebItem("//input[@name='NEW_PASSWORD']", "Поле ввода нового пароля");
            btnChangePassword.Click();
            btnChangePassword.SendKeys(oldpassword.OldPassword);
            var btnChangePasswordRepeat = new WebItem("//input[@name='NEW_PASSWORD_CONFIRM']", "Поле повторного ввода нового пароля");
            btnChangePasswordRepeat.Click();
            btnChangePasswordRepeat.SendKeys(oldpassword.OldPassword);
            var btnSavePersonalProfile = new WebItem("//button[@name='save']", "Кнопка сохранения изменений");
            btnSavePersonalProfile.Click();
            return new MyProfilePage();
        }
    }
}
