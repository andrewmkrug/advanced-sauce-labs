using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace workshop.Pages
{
    class CheckoutOverviewPage
    {
        private IWebDriver driver;

        public CheckoutOverviewPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Boolean onPage()
        {
            return driver.Url.Equals("https://www.saucedemo.com/checkout-step-two.html");
        }
    }
}
