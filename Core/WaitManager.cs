using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Core
{
    public class WaitManager
    {

        public static IWebElement WaitUntilDisabled(IWebDriver Driver ,By by)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            return wait.Until(drv => drv.FindElement(by));
        }
    }
}
