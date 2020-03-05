using System;
using NUnit.Framework;
using OpenQA.Selenium;
using workshop.Pages;

namespace workshop.Exercises
{
    [TestFixture]
    public class LoginFeatureTest : Base.Base
    {

        String username = "standard_user";
        String password = "secret_sauce";
        
        //TODO Find and Complete these Locators
        By userField = By.CssSelector("[data-test='username']");
        By passField = By.CssSelector("[data-test='password']");
        By loginBtn = By.CssSelector("[value='LOGIN']");

        [Test]
        public void    ShouldBeAbleToLogin()
        {

            LoginPage l = new LoginPage(driver);
            l.visit();
            
            driver.FindElement(By.CssSelector("[data-test='username']")).SendKeys(username);

            // send password keystrokes
            driver.FindElement(By.CssSelector("[data-test='password']")).SendKeys(password);
            
            driver.FindElement(By.CssSelector("[value='LOGIN']")).Click();

            // ignore assertion
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
        }
    }
}