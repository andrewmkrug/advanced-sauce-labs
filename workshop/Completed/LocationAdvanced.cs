using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace workshop.Exercises
{
    class LocationAdvanced : Base.Base
    {
        [Test]
        public void LocateZipCodeField()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/checkout-step-one.html");

            String cssDescendant = "#checkout_info_container #postal-code";
            String cssDirectChild = ".checkout_info > #postal-code";
            String cssLastChild = "input:last-child";
            String cssChildFromEnd = "input:nth-last-child(1)";
            String cssChildFromBeginning = "input:nth-child(3)";
            String cssAttributeStartsWith = "[data-test^=post]";
            String cssAttributeEndsWith = "[data-test$=ode]";
            String cssAttributeContains = "[data-test*=alC]";
            String cssNextSibling = "[data-test=lastName] + [data-test=postalCode]";
            String cssSubsequentSibling = "[data-test=firstName] ~ [data-test=postalCode]";




            // IGNORE THE DETAILS OF THE ASSERTIONS BELOW
            // ALL YOU NEED TO KNOW IS THAT IF YOU RUN THIS TEST
            // WITH THE RIGHT VALUES ABOVE IT WILL PASS

            IWebElement zipCode = driver.FindElement(By.Id("postal-code"));

            Assert.AreEqual(zipCode, driver.FindElement(By.CssSelector(cssDescendant)));
            Assert.AreEqual(zipCode, driver.FindElement(By.CssSelector(cssDirectChild)));
            Assert.AreEqual(zipCode, driver.FindElement(By.CssSelector(cssLastChild)));
            Assert.AreEqual(zipCode, driver.FindElement(By.CssSelector(cssChildFromEnd)));
            Assert.AreEqual(zipCode, driver.FindElement(By.CssSelector(cssChildFromBeginning)));
            Assert.AreEqual(zipCode, driver.FindElement(By.CssSelector(cssAttributeStartsWith)));
            Assert.AreEqual(zipCode, driver.FindElement(By.CssSelector(cssAttributeEndsWith)));
            Assert.AreEqual(zipCode, driver.FindElement(By.CssSelector(cssAttributeContains)));
            Assert.AreEqual(zipCode, driver.FindElement(By.CssSelector(cssNextSibling)));
            Assert.AreEqual(zipCode, driver.FindElement(By.CssSelector(cssSubsequentSibling)));

            Assert.True(cssDescendant.Contains(" "));
            Assert.True(cssDirectChild.Contains(" > "));
            Assert.True(cssLastChild.Contains(":last"));
            Assert.True(cssChildFromEnd.Contains(":nth-l"));
            Assert.True(cssChildFromBeginning.Contains(":nth-c"));
            Assert.True(cssAttributeStartsWith.Contains("^="));
            Assert.True(cssAttributeEndsWith.Contains("$="));
            Assert.True(cssAttributeContains.Contains("*="));
            Assert.True(cssNextSibling.Contains(" + "));
            Assert.True(cssSubsequentSibling.Contains(" ~ "));
        }
    }
}
