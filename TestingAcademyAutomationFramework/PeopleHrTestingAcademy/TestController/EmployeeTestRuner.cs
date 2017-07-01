using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PeopleHrTestingAcademy.Pages;

namespace PeopleHrTestingAcademy.TestController
{
    public class EmployeeTestRuner
    {
        private IWebDriver driver;
        private EmployeePage employee;

        public EmployeeTestRuner(IWebDriver driver)
        {
            this.driver = driver;
            employee = new EmployeePage(driver);
        }

        public bool IsLogoPresent()
        {
            bool yesOrNo = employee.LogoValidation();
            return yesOrNo;
        }
    }
}
