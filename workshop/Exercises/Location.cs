using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace workshop.Exercises
{
    public class Location : Base.Base
    {
         //
    // Exercise:
    // Fill in the Strings and Update the Indexes to get the tests to pass
    //

    [SetUp]
    public void navigate() {
        driver.Url = "http://a.testaddressbook.com/sign_in";
    }

    [Test]
    public void locateEmailField() {

        // Update these fields:

        String id = "";
        String name = "";
        String className = "";

        // There is more than one Tag name that matches the Email Field, so you
        // need to specify which number it is in the tagIndex value
        String tagName = "";
        Int16 tagIndex = 0;



        // IGNORE THE DETAILS OF THE ASSERTIONS BELOW
        // ALL YOU NEED TO KNOW IS THAT IF YOU RUN THIS TEST
        // WITH THE RIGHT VALUES ABOVE IT WILL PASS

        // Obfuscated way of getting the Email Field
        IWebElement emailField = driver.FindElements(By.XPath("//*"))[30];

        // Assert correct element has been found withe the updated strings
        Assert.AreSame(emailField, driver.FindElement(By.Id(id)));
        Assert.AreSame(emailField, driver.FindElement(By.Name(name)));
        Assert.AreSame(emailField, driver.FindElement(By.ClassName(className)));
        Assert.AreSame(emailField, driver.FindElements(By.TagName(tagName))[tagIndex]);
    }

    [Test]
    public void locateSignInButton() {

        // Update these fields:

        String name = "";
        String className = "";

        // There is more than one Tag name that matches the Sign In Button, so you
        // need to specify which number it is in the tagIndex value
        String tagName = "";
        int tagIndex = 0;



        // IGNORE THE DETAILS OF THE ASSERTIONS BELOW
        // ALL YOU NEED TO KNOW IS THAT IF YOU RUN THIS TEST
        // WITH THE RIGHT VALUES ABOVE IT WILL PASS

        // Obfuscated way of getting the Sign in Button
        IWebElement signInButton = driver.FindElements(By.XPath("//*"))[34];

        Assert.AreSame(signInButton, driver.FindElement(By.Name(name)));
        Assert.AreSame(signInButton, driver.FindElement(By.ClassName(className)));
        Assert.AreSame(signInButton, driver.FindElements(By.TagName(tagName))[tagIndex]);
    }

    [Test]
    public void locateSignUpLink() {

        // Update these fields:

        String linkText = "";
        String partialLinkText = "";

        // There is more than one Tag name that matches the Sign Up Link, so you
        // need to specify which number it is in the tagIndex value
        String tagName = "";
        Int16 tagIndex = 0;



        // IGNORE THE DETAILS OF THE ASSERTIONS BELOW
        // ALL YOU NEED TO KNOW IS THAT IF YOU RUN THIS TEST
        // WITH THE RIGHT VALUES ABOVE IT WILL PASS

        // Obfuscated way of getting the Sign Up Link
        IWebElement signUpLink = driver.FindElements(By.XPath("//*"))[36];

        Assert.AreSame(signUpLink, driver.FindElement(By.LinkText(linkText)));
        Assert.AreSame(signUpLink, driver.FindElement(By.PartialLinkText(partialLinkText)));
        Assert.AreSame(signUpLink, driver.FindElements(By.TagName(tagName))[tagIndex]);

    }
    }
}