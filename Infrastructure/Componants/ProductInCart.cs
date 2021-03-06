﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Core;

namespace Infrastructure
{
    public class ProductInCart : ComponantBase
    {
        private IWebElement TotalPrice => Driver.WaitAndFindElement(By.Id("total_product_price_1_1_0"));
        private Quantity Quantity => new Quantity(Driver, Driver.WaitAndFindElement(By.CssSelector(".cart_quantity.text-center")));
        private IWebElement TrashButton => Driver.WaitAndFindElement(By.CssSelector(".icon-trash"));

        public ProductInCart(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public void PressTrashButton()
        {
            TrashButton.Click();
        }
    }
}
