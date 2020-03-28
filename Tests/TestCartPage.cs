using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
namespace Tests
{
    [TestClass]
    public class TestCartPage : TestBase
    {
        [TestMethod]
        public void AddingOneDeletingProductFromCart()
        {
            HomePage
                .ClickOnWomenButton()
                .PointMouseAtPicture(0)
                .AddToCart(0)
                .PressProceedToCheckout()
                .PressTrashButton(0)
                .AllertPerform().Should().BeTrue();
        }

        [TestMethod]
        public void AddingSomeDeletingProductsFromCart()
        {
            HomePage
                .ClickOnWomenButton()
                .PointMouseAtPicture(0)
                .AddToCart(0)
                .PressContinueShopping()
                .PointMouseAtPicture(1)
                .AddToCart(1)
                .PressProceedToCheckout();
        }
    }
}
