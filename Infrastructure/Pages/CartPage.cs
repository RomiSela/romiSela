using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Core;
namespace Infrastructure.Pages
{
    public class CartPage : BasePage
    {
        //private List<ProductInCart> ProductInCart =>Driver.FindElements(By.CssSelector("tbody")).Select(element => new ProductInCart(Driver,Driver.FindElement(By.CssSelector(".cart_item")))).ToList();
        private List<ProductInCart> ProductInCart => Driver.FindElements(By.CssSelector("tbody")).Select(element => new ProductInCart(Driver, WaitManager.WaitUntilDisabled(Driver, By.CssSelector(".cart_item")))).ToList();

        private IWebElement TotalProductsPrice => Driver.FindElement(By.CssSelector("#total_product"));
        private IWebElement AlertNoProducts => Driver.FindElement(By.CssSelector(".alert.alert-warning"));
        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        public double GetTotalProductsPrice()
        {
            string price = TotalProductsPrice.Text;
            return double.Parse(price);
        }

        public CartPage PressTrashButton(int place)
        {
            ProductInCart[place].PressTrashButton();
            return new CartPage(Driver);
        }

        public bool AllertPerform()
        {
            if (AlertNoProducts.Displayed)
                return true;
            else
                return false;
        }
    }
}
