using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Core;
using NUnit.Framework;
using PeopleHrTestingAcademy.TestController;


namespace PeopleHrTestingAcademy.SetUp
{
    public class StartUp
    {
        public TestRuner runner = new TestRuner();

        [SetUp]
        public void SetUp()
        {
            runner.StartTestSuite();
        }

        [TearDown]
        public void TearDown()
        {
            runner.EndTestSuite();
        }
    }
}
