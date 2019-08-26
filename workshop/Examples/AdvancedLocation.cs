using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace workshop.Examples
{
    [TestFixture]
    [Parallelizable]
    class AdvancedLocation : Base.Base
    {
        [Test]
        public void CssHeirarchy()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            // descendant --> text field
            driver.FindElement(By.CssSelector((".login_wrapper .form_input")));

            // direct descendant --> text field
            driver.FindElement(By.CssSelector(("form > .form_input")));

            // first child --> text field
            driver.FindElement(By.CssSelector(("input:first-child")));

            // last child --> submit field
            driver.FindElement(By.CssSelector(("input:last-child")));

            // third child --> submit button
            driver.FindElement(By.CssSelector(("input:nth-child(3)")));

            // third child from end --> text field
            driver.FindElement(By.CssSelector(("input:nth-last-child(3)")));
        }

        [Test]

        public void CssAttributeSubString()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            // starts with --> text field
            driver.FindElement(By.CssSelector(("[data-test^=user]")));

            // ends with --> password field
            driver.FindElement(By.CssSelector(("[data-test$=word]")));

            // contains --> submit button
            driver.FindElement(By.CssSelector(("[type*=ubm]")));
        }

        [Test]
        public void CssSiblings()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            // next sibling --> text field
            driver.FindElement(By.CssSelector(("[type=text] + [type=password]")));

            // subsequent sibling --> password field
            driver.FindElement(By.CssSelector(("[type=text] ~ [type=submit]")));
        }
    }
}
