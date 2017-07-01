using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace PeopleHrTestingAcademy.TestController
{
    public class TestRuner
    {
        private IWebDriver driver;
        private string baseURL;
        
        public EmployeeTestRuner employeeTestRuner { get; private set; }
        public LoginTestRuner loginTestRunner { get; set; }
        public void StartTestSuite()
        {
            driver = new FirefoxDriver();
            baseURL = "https://horatioconsultingltd.peoplehr.net/";
        }

        public void EndTestSuite()
        {
            driver.Quit();
        }

        public void LaunchTest()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Maximize();

            employeeTestRuner = new EmployeeTestRuner(driver);
            loginTestRunner = new LoginTestRuner(driver);
        }

    }
}
