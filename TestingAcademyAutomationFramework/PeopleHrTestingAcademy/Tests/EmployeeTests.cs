using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using PeopleHrTestingAcademy.SetUp;

namespace PeopleHrTestingAcademy.Tests
{
    [TestFixture]
    public class EmployeeTests : StartUp
    {
        [Category("Smoke"), Category("Regression")]
        [Test]
        public void LogoDisplayTest()
        {
            try
            {
                runner.LaunchTest();
                bool presentOrNot = runner.employeeTestRuner.IsLogoPresent();
                Assert.IsTrue(presentOrNot.Equals(true), "No logo present");
                Console.WriteLine("Logo is present");
                Thread.Sleep(4000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        
    }
}
