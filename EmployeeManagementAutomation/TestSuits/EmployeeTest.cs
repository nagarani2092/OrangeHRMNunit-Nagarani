using EmployeeManagementAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Utilities;

public class EmployeeTest : AutomationWrapper
{
    [Test,TestCaseSource(typeof(DataSource), nameof(DataSource.EmployeeTestData))]
    public void AddEmployeeTest(string username, string password, string firstName, string middleName, string lastName)
    {

        driver.FindElement(By.Name("username")).SendKeys("Admin");
        driver.FindElement(By.Name("password")).SendKeys("admin123");
        driver.FindElement(By.XPath("//button[text()=' Login ']")).Click();
        driver.FindElement(By.XPath("(//a[@class='oxd-main-menu-item'])[2]")).Click();
        driver.FindElement(By.XPath("//a[text()='Add Employee']")).Click();
        driver.FindElement(By.Name("firstName")).SendKeys("john");
        driver.FindElement(By.Name("middleName")).SendKeys("w");
        driver.FindElement(By.Name("lastName")).SendKeys("wick");
        driver.FindElement(By.XPath("//button[text()=' Save ']")).Click();
        //Assert the profile name john wick
       string actualProfileName = driver.FindElement(By.XPath("//h6[text()='john wick']")).Text;
        Assert.That(actualProfileName, Is.EqualTo("john wick"));
        //Assert the firstname textbox contains - john
      string actualFirstNameeName = driver.FindElement(By.Name("firstName")).GetAttribute("value");

        Assert.That(actualFirstNameeName, Is.EqualTo("john"));
        Thread.Sleep(5000);


    }
}
