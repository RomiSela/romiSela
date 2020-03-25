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
        private Clothing Clothing => new Clothing(Driver, Driver.FindElement(By.CssSelector(".product-container")));

        public CatalogPage(IWebDriver driver) : base(driver)
        {
        }

        public CatalogPage PointMouseAtPicture()
        {
            Clothing.PointMouseAtPicture();
            return new CatalogPage(Driver);
        }

        public CatalogPage AddToCart()
        {
            Clothing.AddToCart();
            return new CatalogPage(Driver);
        }

        public CatalogPage PressContinueShopping()
        {
            Clothing.PressContinueShopping();
            return new CatalogPage(Driver);
        }
    }
}
