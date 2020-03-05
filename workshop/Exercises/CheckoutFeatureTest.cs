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
    }
}