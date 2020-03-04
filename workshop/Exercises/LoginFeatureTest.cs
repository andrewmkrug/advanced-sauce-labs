using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace workshop.Exercises
{
    public class LoginFeatureTest : workshop.Base.Base
    {
        protected IWebDriver driver;

        String username = "standard_user";
        String password = "secret_sauce";
        
        //TODO Find and Complete these Locators
        By userField;
        By passField;
        By loginBtn;

        [Test]
        public void ShouldBeAbleToLogin()
        {

            //navigate to the url of the Sauce Labs Sample app
            driver.Navigate().GoToUrl("https://www.saucedemo.com");

            // wait 5 seconds
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // send username keystrokes
            driver.FindElement(userField).SendKeys(username);

            // send password keystrokes
            driver.FindElement(passField).SendKeys(password);

            // click login button to submit keystrokes
            driver.FindElement(loginBtn).Click();

            // ignore assertion
            Assert.Equals("https://www.saucedemo.com/inventory.html", driver.Url);
        }
    }
}