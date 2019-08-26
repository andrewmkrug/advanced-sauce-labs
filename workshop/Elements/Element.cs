using System;
using System.IO.Enumeration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace workshop.Elements
{
    public class Element
    {
        private IWebDriver _driver;
        private By _locator;

        public Element(IWebDriver driver, By locator)
        {
            this._driver = driver;
            this._locator = locator;
        }

        public void Click()
        {
            while (true)
            {
                try
                {
                    Find(_locator).Click();
                    return;
                }
                catch (NoSuchElementException e)
                {
                    WaitForElement(_locator);
                }
                catch (ElementNotInteractableException e)
                {
                    WaitForElementVisible(_locator);
                }
            }
        }


        public void SendKeys(String text)
        {
            while (true)
            {
                try
                {
                    Find(_locator).SendKeys(text);
                    return;
                }
                catch (NoSuchElementException)
                {
                    WaitForElement(_locator);
                }
                catch (ElementNotInteractableException)
                {
                    WaitForElementVisible(_locator);
                }
            }
        }
        public IWebElement Find(By locator)
        {
            return _driver.FindElement(locator);
        }

        private void WaitForElement(By locator)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(_locator));
        }

        private void WaitForElementVisible(By locator)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(_locator));
        }
    }
}