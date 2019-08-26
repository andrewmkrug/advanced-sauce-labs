using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using workshop.Pages;

namespace workshop.Exercises
{
    [TestFixture]
    [Parallelizable]
    class CheckoutInformationTest : Base.Base
    {
        [Test]
        public void CheckoutTest()
        {
            CheckoutPage checkoutPage = CheckoutPage.visit(driver);
            checkoutPage.EnterInformation();

            CheckoutOverviewPage checkoutOverviewPage = new CheckoutOverviewPage(driver);
            Assert.That(checkoutOverviewPage.onPage());
        }
    }
}
