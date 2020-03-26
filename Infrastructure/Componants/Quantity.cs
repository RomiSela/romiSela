using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class Quantity : ComponantBase
    {
        private IWebElement QuantityNumber => ParentElement.FindElement(By.ClassName("cart_quantity_input form-control grey"));
        private IWebElement AddQuantity => ParentElement.FindElement(By.ClassName("icon-plus"));
        private IWebElement MinusQuantity => ParentElement.FindElement(By.ClassName("icon-minus"));

        public Quantity(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }
    }
}
