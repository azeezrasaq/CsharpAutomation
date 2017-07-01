using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PeopleHrTestingAcademy.Locators
{
    public class Elements
    {
        private static IWebDriver driver;
        static Elements()
        {
            getElement = GetLocator();
        }

        public static Dictionary<string, string> getElement;

        public static Dictionary<string, string> GetLocator()
        {
            var getElement = new Dictionary<string, string>();
            getElement.Add("ApplicationLogo", ".//*[@id='loginLogo']");
            getElement.Add("EmailField", ".//*[@id='txtEmailId']");
            getElement.Add("PasswordField", ".//*[@id='txtPassword']");
            getElement.Add("LoginBtn", ".//*[@id='btnLogin']");
            getElement.Add("InvalidPassword", ".//*[@id='pWarning']");
            getElement.Add("InvalidUserName", ".//*[@id='frmLogin']/div[3]/div/div[2]/div[1]/div[1]/span");
            //hhkhlflldffd
            //getElement.Add("", "");
            //getElement.Add("", "");
            //getElement.Add("", "");

            return getElement;
        }

    }
}
