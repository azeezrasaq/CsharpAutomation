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
    public class LoginTests : StartUp
    {
        [Category("Sanity"), Category("Regression")]
        [TestCase("demola.adesina@horatioconsult.com", "Theyellowchicken1234")]  //valid username, valid password
        public void ValidUserLoginTest(string username, string password)
        {
            try
            {
                runner.LaunchTest();
                runner.loginTestRunner.DriveLoginRelatedFields(username, password);

                string pageTitleText = runner.loginTestRunner.GetPageTitle();
                Assert.IsTrue(pageTitleText.Equals("People"));
                Console.WriteLine(pageTitleText);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Test with valid username and password is failed: " + ex.ToString());
                throw;
            }

        }


        [Category("Regression")]
        [TestCase("demola.adesina@horatioconsult.com", "Theyellowchicken12346666")] //valid username, invalid password
        [TestCase("demola.adesina@horatioconsult.comeeee", "Theyellowchicken1234")]  //invalid username, valid password
        //[TestCase("", "")] //null username, null password
        public void InvalidUserLoginTest(string username, string password)
        {
            try
            {
                runner.LaunchTest();
                runner.loginTestRunner.DriveLoginRelatedFields(username, password);
                try
                {
                    string invalidUsernameErrorText = runner.loginTestRunner.GetInvalidUsernameErrorText().Trim();
                    Assert.IsTrue(invalidUsernameErrorText.Equals("Email address is required"));
                    Console.WriteLine(invalidUsernameErrorText);
                    Thread.Sleep(4000);
                }
                catch (Exception)
                {

                    string invalidPasswordErrorText = runner.loginTestRunner.GetPasswordErrorText().Trim();
                    Assert.IsTrue(invalidPasswordErrorText.Contains("Email address / password combination is incorrect"));
                    Console.WriteLine(invalidPasswordErrorText);
                    Thread.Sleep(4000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Test with valid username and password is failed: " + ex.ToString());
                throw;
            }

        }
    }
}
