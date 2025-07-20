﻿using EmployeeManagementAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.TestSuits
{
    public class LoginUITest : AutomationWrapper
    {
        
        [Test]
        public void TitleTest()
        {
           
            Assert.That(driver.Title, Is.EqualTo("OrangeHRM"));

        }

        [Test]
        public void HeaderTest()
        {
            Assert.That(driver.FindElement(By.XPath("//h5")).Text, Is.EqualTo("Login"));

        }
    }
}
