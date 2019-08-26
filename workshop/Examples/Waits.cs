using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace workshop.Examples
{
    [TestFixture]
    [Parallelizable]
    class Waits : Base.Base
    {

        [Test]
    public void noWait()
        {
            driver.Navigate().GoToUrl("https://a.testaddressbook.com/");
            driver.FindElement(By.Id("sign-in")).Click();

            driver.FindElement(By.Id("session_email"));
        }

        [Test]
        public void sleep() 
        {
            driver.Navigate().GoToUrl("https://a.testaddressbook.com/");
        driver.FindElement(By.Id("sign-in")).Click();

        Thread.Sleep(TimeSpan.FromSeconds(2));

        driver.FindElement(By.Id("session_email"));
    }

    [Test]
    public void fluentWait()
    {
        driver.Navigate().GoToUrl("https://a.testaddressbook.com/");
        driver.FindElement(By.Id("sign-in")).Click();


        DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(20);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

        IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.Id("session_email")));
    }

    [Test]
    public void explicitWait()
    {
        driver.Navigate().GoToUrl("https://a.testaddressbook.com/");
        driver.FindElement(By. Id("sign-in")).Click();

        WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        explicitWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id("session_email")));

        driver.FindElement(By.Id("session_email"));
        }
    }
}
