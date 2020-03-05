using System;
using NUnit.Framework;
using workshop.Pages;

namespace workshop.Exercises
{
    [TestFixture]
    public class CheckoutFeatureTest : Base.Base
    {
        [Test]
        public void ShouldBeAbleToCheckoutWithItems() {
            // wait 5 seconds
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5) ;
            //navigate to the url of the Sauce Labs Sample app
            LoginPage loginPage = new LoginPage(driver);
            loginPage.visit();

            // Ignore the following selectors
            String username = "standard_user";
            String password = "secret_sauce";
            InventoryPage inventoryPage = loginPage.login(username, password);

            ConfirmationPage confirmationPage = new ConfirmationPage(driver);
            confirmationPage.Visit();
            confirmationPage.setPageState();
            Assert.True(confirmationPage.hasItems());
    
            CheckoutCompletePage completePage = confirmationPage.finish();
            // assert that the test is finished by checking the last page's URL
            Assert.True(completePage.IsLoaded());
        }
        
        [Test]
        public void ShouldBeAbleToCheckoutWithItems_Before() {
             
            //navigate to the url of the Sauce Labs Sample app
            LoginPage loginPage = new LoginPage(driver);
            loginPage.visit();

            // Ignore the following selectors
            String username = "standard_user";
            String password = "secret_sauce";
            InventoryPage inventoryPage = loginPage.login(username, password);

            // Assert that the url is on the inventory page
            //TODO fix this assertion later
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
            inventoryPage.addBackpackToCart();
            ShoppingCartPage cart = inventoryPage.goToShoppingCart();
            CheckoutStepTwoPage stepTwoPage = cart.checkout();
            ConfirmationPage confirmationPage = stepTwoPage.fillOutInformation("first", "last", "zip");
            CheckoutCompletePage finalConfirmationPage = confirmationPage.finish();
            Assert.True(finalConfirmationPage.IsLoaded());
        }
    }
}