using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Extensions;
using Core;

namespace Tests
{
    [TestClass]
    public class TestCartPage : TestBase
    {
        [TestMethod]
        public void AddingOneDeletingProductFromCart()
        {
            HomePage.
                ClickOnWomenButton()
                .AddProductAndProceedToCart(ConfigManager.IndexOfProductZero)
                .PressTrashButton(ConfigManager.IndexOfProductZero)
                .AllertPerform().Should().BeTrue();
        }

        [TestMethod]
        public void AddingSomeDeletingProductFromCart()
        {
            HomePage
            .ClickOnWomenButton()
            .AddTwoProductsAndProceedToCart()
            .PressTrashButton(ConfigManager.IndexOfProductZero)
            .NumberOfProducts().Should().Be(1);
        }
    }
}
