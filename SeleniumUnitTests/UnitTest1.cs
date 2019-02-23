using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumUnitTests
{
    [TestFixture]
    public abstract class MaintTest
    {
        public IWebDriver _driver { private get; set; }

        [SetUp]
        public void StartBrowser()
        {
            _driver = new FirefoxDriver();
        }
        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
        }
    }
}
