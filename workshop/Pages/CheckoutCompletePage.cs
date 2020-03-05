using System;
using OpenQA.Selenium;

namespace workshop.Pages
{
    public class CheckoutCompletePage
    {
        private IWebDriver driver;
        //TODO more duplication
        public CheckoutCompletePage(IWebDriver driver) {
            this.driver = driver;
        }

        public Boolean IsLoaded() {
            return driver.Url.Equals("https://www.saucedemo.com/checkout-complete.html");
        }
    }
}