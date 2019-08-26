using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using workshop.Data;

namespace workshop.Pages
{
    class CheckoutPage
    {
        private By firstName = By.Id("first-name");
        private By lastName = By.Id("last-name");
        private By zipCode = By.Id("postal-code");
        private By submit = By.ClassName("cart_button");

        private IWebDriver driver;

        public static CheckoutPage visit(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/checkout-step-one.html");
            return new CheckoutPage(driver);
        }

        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterInformation()
        {
            Person person = new Person();

            driver.FindElement(firstName).SendKeys(person.FirstName);
            driver.FindElement(lastName).SendKeys(person.LastName);
            driver.FindElement(zipCode).SendKeys(person.ZipCode);
            driver.FindElement(submit).Click();
        }
    }
}
