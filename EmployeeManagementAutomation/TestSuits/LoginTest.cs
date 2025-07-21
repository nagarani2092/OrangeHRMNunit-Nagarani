using EmployeeManagementAutomation.Base;
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
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[text()=' Login ']")).Click();
            string actualValue = driver.FindElement(By.XPath("//p[text()='Time at Work']")).Text;
            Assert.That(actualValue, Is.EqualTo("Time at Work"));
        }
        
         [Test,TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginCredentials))]
        //[TestCase("naga", "naga123", "Invalid credentials")]
        //[TestCase("syed", "syed123", "Invalid credentials")]
        public void InValidLoginTest(string username, string password, string expectedMessage)
        {
            driver.FindElement(By.Name("username")).SendKeys("Naga");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[text()=' Login ']")).Click();
            Thread.Sleep(5000);

            string actualValue = driver.FindElement(By.XPath("//p[text()='Invalid credentials']")).Text;

            Assert.That(actualValue.Contains("Invalid credentials"),"Assertion on Invalid credentials");
        }
    }
}
