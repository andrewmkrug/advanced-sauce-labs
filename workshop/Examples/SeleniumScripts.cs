using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace workshop.Examples
{
    [TestFixture]
    [Parallelizable]
    public class SeleniumScripts : Base.SauceBase
    {
        [Test]
        public void FirstTest()
        {
            String email = "standard_user";
            String password = "secret_sauce";
            
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            
            driver.FindElement(By.Id("user-name")).SendKeys(email);
            driver.FindElement(By.Id("password")).SendKeys(password);
            
            driver.FindElement(By.ClassName("btn_action")).Click();
            Assert.That(true.Equals(true));
        }
        

        [Test]
        public void SecondTest()
        {
            String email = "standard_user";
            String password = "secret_sauce";
            
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            
            driver.FindElement(By.Id("user-name")).SendKeys(email);
            driver.FindElement(By.Id("password")).SendKeys(password);
            
            driver.FindElement(By.ClassName("btn_action")).Click();
            Assert.That(true.Equals(true));
        }
        
        [Test]
        public void ThirdTest()
        {
            String email = "standard_user";
            String password = "secret_sauce";
            
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            
            driver.FindElement(By.Id("user-name")).SendKeys(email);
            driver.FindElement(By.Id("password")).SendKeys(password);
            
            driver.FindElement(By.ClassName("btn_action")).Click();
            Assert.That(true.Equals(true));
        }
        public SeleniumScripts(Platforms platform, Browsers browser, string version) : base(platform, browser, version)
        {
        }
    }
}
