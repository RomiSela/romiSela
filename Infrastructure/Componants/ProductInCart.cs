using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class ProductInCart : ComponantBase
    {
        private IWebElement TotalPrice => Driver.FindElement(By.Id("total_product_price_1_1_0"));
        private Quantity Quantity => new Quantity(Driver, Driver.FindElement(By.CssSelector(".cart_quantity.text-center")));
        private IWebElement TrashButton => Driver.FindElement(By.CssSelector(".icon-trash"));

        public ProductInCart(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }
    }
}
