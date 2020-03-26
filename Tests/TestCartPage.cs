using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class TestCartPage : TestBase
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
