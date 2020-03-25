using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Tests : TestBase
    {
        [TestMethod]
        public void TestMethod1()
        {
            HomePage
                .ClickOnWomenButton()
                //.PointMouseAtPicture()
                .AddToCart().PressContinueShopping();
        }
    }
}
