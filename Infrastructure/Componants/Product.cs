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
        private IWebElement AddToCartButton => ParentElement.FindElement(By.CssSelector(".button.ajax_add_to_cart_button.btn.btn-default span"));
        private IWebElement Picture => ParentElement.FindElement(By.CssSelector(".left-block"));
        
        private IList<IWebElement> Colors => ParentElement.FindElements(By.CssSelector(".color_to_pick_list.clearfix a"));

        public Product(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public void StandOnProduct()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(Picture).Perform();
        }

        public void AddToCart()
        {
            AddToCartButton.Click();
        }
    }
}
