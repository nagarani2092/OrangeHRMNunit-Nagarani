using EmployeeManagementAutomation.Base;
using EmployeeManagementAutomation.Pages;
using EmployeeManagementAutomation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.TestSuits
{
    [TestFixture]
    public class LoginTest : AutomationWrapper
    {
        [Test]
        public void ValidLoginTest()
        {
            
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUsername( "Admin");
            loginPage.EnterPassword("admin123");
            loginPage.ClickOnLogin();


            DashBoardPage dashboardPage = new DashBoardPage(driver);
            string actualValue = dashboardPage.GetTimeAtWorkHeader();
            Assert.That(actualValue, Is.EqualTo("Time at Work"));

           
        }
        
         [Test,TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginCredentials))]
        //[TestCase("naga", "naga123", "Invalid credentials")]
        //[TestCase("syed", "syed123", "Invalid credentials")]
        public void InValidLoginTest(string username, string password, string expectedMessage)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUsername( username);
            loginPage.EnterPassword( password);
            loginPage.ClickOnLogin();



            string actualValue = loginPage.GetInvalidErrorMessage();
            Assert.That(actualValue, Is.EqualTo("Assertion on Invalid credentials"));
        }
    }
}
