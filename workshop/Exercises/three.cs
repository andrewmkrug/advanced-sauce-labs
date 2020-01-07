using System;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace workshop.Exercises
{
    public class three : Base.Base
    {
        [Test]
        public void signUpExistingAccount() {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0,0,10));

            // navigate to desired page
            driver.Url = "http://a.testaddressbook.com/sign_up";

            // Specify Data

            String email = "user@example.com";
            String password = "password";

            // wait for Email Field

            // fill out email field using `email` variable

            // fill out password field using `password` variable

            // click Sign Up button (or Submit Form)


            // Note that because this user already exists, Sign Up will not be successful
            wait.Until((ExpectedConditions.UrlMatches("http://a.testaddressbook.com/users")));
        }
    }
}