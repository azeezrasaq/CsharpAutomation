using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PeopleHrTestingAcademy.Pages;

namespace PeopleHrTestingAcademy.TestController
{
    public class LoginTestRuner
    {

        private IWebDriver driver;
        private LoginPage loginPage;

        public LoginTestRuner(IWebDriver driver)
        {
            this.driver = driver;
            loginPage = new LoginPage(driver);
        }

        public void DriveLoginRelatedFields(string username, string password)
        {
            loginPage.EmailAddressField(username);
            loginPage.PasswordField(password);
            loginPage.LoginButton();
        }

        public string GetPageTitle()
        {
            return loginPage.PageTitle();
        }

        public string GetInvalidUsernameErrorText()
        {
            return loginPage.InvalidUserName();
        }

        public string GetPasswordErrorText()
        {
            return loginPage.InvalidPassword();
        }

    }
}
