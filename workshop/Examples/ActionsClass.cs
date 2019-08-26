using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace workshop.Examples
{
    class ActionsClass : Base.Base
    {
        [Test]
        public void advanced()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com");

            Actions actions = new Actions(driver);
            IWebElement element = driver.FindElement(By.TagName("div"));
            IWebElement element2 = driver.FindElement(By.TagName("input"));

            // Hover
            actions.MoveToElement(element).Build().Perform();

            // Drag & Drop
            actions.DragAndDrop(element, element2).Build().Perform();

            // Click, Pause, Release
            actions.ClickAndHold(element).Build().Perform();

            Thread.Sleep(500);

            actions.Release().Build().Perform();
        }
    }
}
