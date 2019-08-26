using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using workshop.Elements;

namespace workshop.Pages
{
    class BasePage
    {
        protected IWebDriver driver;

        public Element GetElement(By locator)
        {
            return new Element(driver, locator);
        }
    }
}
