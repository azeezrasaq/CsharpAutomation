using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PeopleHrTestingAcademy.Locators;

namespace PeopleHrTestingAcademy.Pages
{
    public class LoginPage : Elements
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver) : base()
        {
            this.driver = driver;
        }

        public void EmailAddressField(string username)
        {
            try
            {
                IWebElement emailField = driver.FindElement(By.XPath(getElement["EmailField"]));
                emailField.Clear();
                emailField.SendKeys(username);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Email field could not take user input " + ex.ToString());
            }
        }

        public void PasswordField(string password)
        {
            try
            {
                IWebElement passwordField = driver.FindElement(By.XPath(getElement["PasswordField"]));
                passwordField.Clear();
                passwordField.SendKeys(password);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Password field could not take user input " + ex.ToString());
            }
        }

        public void LoginButton()
        {
            try
            {
                driver.FindElement(By.XPath(getElement["LoginBtn"])).Click();  //click login button
            }
            catch (Exception ex)
            {
                Console.WriteLine("Login button is not clickable " + ex.ToString());
            }
        }

        public string PageTitle()
        {
            return driver.Title;
        }

        public string InvalidUserName()
        {
            return driver.FindElement(By.XPath(getElement["InvalidUserName"])).Text;
        }

        public string InvalidPassword()
        {
            return driver.FindElement(By.XPath(getElement["InvalidPassword"])).Text;
        }
    }
}
