using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class OptionsAfterAddingProduct : ComponantBase
    {
        private IWebElement ContinueShoppingButton => Driver.FindElement(By.CssSelector(".continue.btn.btn-default.button.exclusive-medium"));
        private IWebElement ProceedToCheckoutButton => Driver.FindElement(By.CssSelector(".btn.btn-default.button.button-medium span"));

        public OptionsAfterAddingProduct(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public void ClickContinueShoppingButton()
        {
            ContinueShoppingButton.Click();
        }

        public void ClickProceedToCheckoutButton()
        {
            ProceedToCheckoutButton.Click();
        }
    }
}
