using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using workshop.Data;
using workshop.Pages;

namespace workshop.Examples
{
    class SignInTest :Base.Base
    {
        [Test]
        public void ValidTest()
        {
            HomePage homePage = HomePage.Visit(driver);
            User user = User.valid();

            homePage.Signin(user);

            InventoryPage inventoryPage = new InventoryPage(driver);
            Assert.That(inventoryPage.onPage());
        }
    }
}
