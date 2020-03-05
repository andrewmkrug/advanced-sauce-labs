using System;
using OpenQA.Selenium;

namespace workshop.Pages
{
    public class ConfirmationPage
    {
        private IWebDriver driver;

        public ConfirmationPage(IWebDriver driver) {
            this.driver = driver;
        }

        public void Visit()
        {
            //TODO duplication in URL with LoginPage
            driver.Navigate().GoToUrl("https://www.saucedemo.com/checkout-step-two.html");
        }

        public void setPageState()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.sessionStorage.setItem('standard-username', 'standard-user')");
            js.ExecuteScript("window.sessionStorage.setItem('cart-contents', '[4,1]')");
            driver.Navigate().Refresh();
        }
        public Boolean hasItems() {
            String cartBadge = "shopping_cart_badge";
            return Int32.Parse(driver.FindElement(By.ClassName(cartBadge)).Text) > 0;
        }
        public CheckoutCompletePage finish() {
            String finished =".btn_action.cart_button";
            driver.FindElement(By.CssSelector(finished)).Click();
            return new CheckoutCompletePage(driver);
        }
    }
}