using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
namespace Tests
{
    [TestClass]
    public class TestBase
    {
        public HomePage HomePage { get; private set; }
        private IWebDriver Driver { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl($@"{ConfigurationManager.AppSettings["WEBSITE_URL"]}");
            HomePage = new HomePage(Driver);
        }

        //[TestCleanup]
        //public void CleanUp()
        //{
        //    Driver.Close();
        //}
    }
}