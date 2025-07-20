using EmployeeManagementAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.TestSuits
{
    public class EmployeeTest : AutomationWrapper
    {
        [Test]
        public void AddEmployeeTest()
        {

            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[text()=' Login ']")).Click();
            driver.FindElement(By.XPath("(//a[@class='oxd-main-menu-item'])[2]")).Click();
            driver.FindElement(By.Name("firstName")).SendKeys("john");
            driver.FindElement(By.Name("middleName")).SendKeys("w");
            driver.FindElement(By.Name("lastName")).SendKeys("wick");
            driver.FindElement(By.XPath("//button[text()=' Save ']")).Click();


            Thread.Sleep(5000);


        }
    }
}
