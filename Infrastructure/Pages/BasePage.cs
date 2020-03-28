using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Core;
namespace Infrastructure
{
    public abstract class BasePage : DriverUser
    {
        private IWebElement _cart => Driver.FindElement(By.CssSelector(".shopping_cart a"));
        //private TopMenu TopMenu => new TopMenu(Driver, Driver.FindElement(By.CssSelector(".sf-menu.clearfix.menu-content.sf-js-enabled.sf-arrows")));
        private TopMenu TopMenu => new TopMenu(Driver,WaitManager.WaitUntilDisabled(Driver, By.CssSelector(".sf-menu.clearfix.menu-content.sf-js-enabled.sf-arrows")));

        public BasePage(IWebDriver driver) : base(driver)
        {
        }

        public CatalogPage ClickOnWomenButton()
        {
            TopMenu.ClickOnWomen();
            return new CatalogPage(Driver);
        }
    }
}
