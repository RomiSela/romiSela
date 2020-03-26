using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Infrastructure.Pages
{
    public class CartPage : BasePage
    {
        private ProductInCart ProductInCart => new ProductInCart(Driver, Driver.FindElement(By.Id("product_1_1_0_0")));

        public CartPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
