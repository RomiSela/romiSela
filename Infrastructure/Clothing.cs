using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Infrastructure
{
    public class Clothing : ComponantBase
    {
        private IWebElement AddToCartButton => ParentElement.FindElement(By.CssSelector(".button-container a span"));
        private IWebElement Picture => ParentElement.FindElement(By.ClassName("replace-2x.img-responsive"));
        private IWebElement ContinueShoppingButton => ParentElement.FindElements(By.CssSelector(".button-container span")).First();

        public Clothing(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public void PointMouseAtPicture()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(Picture).Perform();
        }

        public void AddToCart()
        {
            AddToCartButton.Click();
        }

        public void PressContinueShopping()
        {
            ContinueShoppingButton.Click();
        }
    }
}
