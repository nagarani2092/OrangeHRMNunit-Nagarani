using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class MainPage
    {
        private IWebDriver _driver;

        public MainPage(IWebDriver driver)
        {
            this._driver = driver;
        }
    }
}
