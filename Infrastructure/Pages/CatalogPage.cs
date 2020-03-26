using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace Infrastructure
{
    public class CatalogPage : BasePage
    {
        private Product Product => new Product(Driver, Driver.FindElement(By.CssSelector(".product-container")));

        public CatalogPage(IWebDriver driver) : base(driver)
        {
        }

        public CatalogPage PointMouseAtPicture()
        {
            Product.PointMouseAtPicture();
            return new CatalogPage(Driver);
        }

        public CatalogPage AddToCart()
        {
            Product.AddToCart();
            return new CatalogPage(Driver);
        }

        public CatalogPage PressContinueShopping()
        {
            Product.PressContinueShopping();
            return new CatalogPage(Driver);
        }
    }
}
