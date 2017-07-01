using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PeopleHrTestingAcademy.Locators;

namespace PeopleHrTestingAcademy.Pages
{
    public class EmployeePage : Elements
    {
        private IWebDriver driver;
        
        public EmployeePage(IWebDriver driver):base()
        {
            //Congratulations guys and well done Kolade 
            //
            this.driver = driver;
        }

        public bool LogoValidation()
        {
            return driver.FindElement(By.XPath(getElement["ApplicationLogo"])).Displayed;
        }
    }
}
