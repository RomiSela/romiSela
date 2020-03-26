using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Infrastructure
{
    public class Product : ComponantBase
    {
        private IWebElement AddToCartButton => ParentElement.FindElement(By.CssSelector(".button-container a span"));
        private IWebElement Picture => ParentElement.FindElement(By.ClassName("replace-2x.img-responsive"));
        private IWebElement ContinueShoppingButton => ParentElement.FindElement(By.CssSelector(".continue.btn.btn-default.button.exclusive-medium span"));
        private IList<IWebElement> Colors => ParentElement.FindElements(By.CssSelector(".color_to_pick_list.clearfix a"));

        public Product(IWebDriver driver, IWebElement element) : base(driver, element)
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
