using System;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;

namespace workshop.Base
{
    [Parallelizable]
    [TestFixture(Platforms.Windows_10, Browsers.Edge, "latest")]
    [TestFixture(Platforms.Mac_Mojave, Browsers.Safari, "latest")]
    [TestFixture(Platforms.Windows_7, Browsers.Firefox, "latest")]
    public class SauceBase
    {
        protected IWebDriver driver;
        
        private string _sauceUsername;
        private string _sauceAccessKey;
        private DriverOptions _options;

        public SauceBase(Platforms platform, Browsers browser, String version = "0")
        {
            //TODO please supply your Sauce Labs user name in an environment variable
            _sauceUsername = Environment.GetEnvironmentVariable("SAUCE_USERNAME", EnvironmentVariableTarget.User);
 
            //TODO please supply your own Sauce Labs access Key in an environment variable
            _sauceAccessKey = Environment.GetEnvironmentVariable("SAUCE_ACCESS_KEY", EnvironmentVariableTarget.User);
            
            
            var sauceOptions = new Dictionary<string, object>
            {
                ["username"] = _sauceUsername,
                ["accessKey"] = _sauceAccessKey,
                ["name"] = TestContext.CurrentContext.Test.Name,
                ["selenium_version"] = "3.141.59"
            };

            _options = Options(platform, browser, version, sauceOptions);

        }

        public enum Platforms
        {
            Windows_10,
            Mac_Mojave = 14,
            Windows_7
        };

        public enum Browsers
        {
            Safari,
            Edge,
            Firefox,
            Chrome
        }


        
        public String PlatformToString(Platforms platform)
        {
            String Platform = "";
            switch (platform)
            {
                
                case Platforms.Windows_7:
                    Platform = "Windows 7";
                    break;
                case Platforms.Windows_10:
                    Platform = "Windows 10";
                    break;
                case Platforms.Mac_Mojave:
                    Platform = "macOS 10.14";
                    break;
            }

            return Platform;
        }
        
        public DriverOptions Options(Platforms platform, Browsers browser, String version, Dictionary<string, object> SauceOptions)
        {
            DriverOptions options = DriverOptions;
            switch (browser)
            {
                case Browsers.Chrome:
                    ChromeOptions co = new ChromeOptions()
                    {
                        UseSpecCompliantProtocol = true
                    };
                    co.AddAdditionalCapability("sauce:options", SauceOptions, true);
                    options = co;
                    break;
                case Browsers.Edge:
                    EdgeOptions eo = new EdgeOptions();
                    eo.AddAdditionalCapability("sauce:options", SauceOptions);
                    options = eo;
                    break;
                case Browsers.Safari:
                    SafariOptions so = new SafariOptions();
                    so.AddAdditionalCapability("sauce:options", SauceOptions);
                    options = so;
                    break;
                case Browsers.Firefox:
                    FirefoxOptions fo = new FirefoxOptions();
                    fo.AddAdditionalCapability("sauce:options", SauceOptions, true);
                    options = fo;
                    break;
            }

            if(version.Equals("0") || version.Equals("latest"))
                options.BrowserVersion = "latest";
            else
                options.BrowserVersion = version;
            options.PlatformName = PlatformToString(platform);
            
            return options;
        }

        public DriverOptions DriverOptions { get; }
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="platform">Specifies platform for test</param>
        /// <param name="browser">Specifies browser for test</param>
        /// <param name="version">Specifies browser version for test, 0 is latest</param>
        [SetUp]

        public void SetUp()
        {
            
            driver = new RemoteWebDriver(new Uri("https://ondemand.saucelabs.com/wd/hub"), _options);
            
        }

        /// <summary>
        /// This attribute is used inside a TestFixture to provide a common set of functions that are performed after each test method.
        /// For more infomration: https://github.com/nunit/docs/wiki/TearDown-Attribute
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            //Checks the status of the test and passes the result to the Sauce Labs job
            var passed = TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed;
            ((IJavaScriptExecutor)driver).ExecuteScript("sauce:job-result=" + (passed ? "passed" : "failed"));
            
            driver?.Quit(); 
        }
    }
}