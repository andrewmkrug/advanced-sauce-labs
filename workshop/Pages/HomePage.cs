using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using workshop.Data;

namespace workshop.Pages
{
    class HomePage : BasePage
    {
        private By username = By.Id("user-name");
        private By password = By.Id("password");
        private By submit = By.ClassName("btn_action");

        public static HomePage Visit(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            return new HomePage(driver);
        }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Signin(User user)
        {
            GetElement(username).SendKeys(user.getUsername());
            GetElement(password).SendKeys(user.getPassword());
            GetElement(submit).Click();
        }

        // These are here for previous exercises
        public IWebElement getUsername()
        {
            return driver.FindElement(By.Id("user-name"));
        }
        public IWebElement getPassword()
        {
            return driver.FindElement(By.Id("password"));
        }
        public IWebElement getSubmit()
        {
            return driver.FindElement(By.ClassName("btn_action"));
        }
    }
}
