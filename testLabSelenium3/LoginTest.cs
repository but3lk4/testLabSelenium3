using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumUnitTests;
using testLabSelenium3;


namespace SeleniumUnitTests
{
    [TestFixture]
    public class LogInTest : MaintTest
    {
        private readonly string _login = "wsei_test";
        private readonly string _password = "wsei_test";

        

        public IWebDriver _driver { private set; get; }

           

        [Test]
        public void Logintest()
        {
            _driver.Url = "http://www.store.demoqa.com";

            var homePage = new HomePage(_driver);
            homePage.MyAccount.Click();

            var loginPage = new LoginPage(_driver);
            loginPage.UserName.SendKeys(_login);
            loginPage.Password.SendKeys(_password);
            loginPage.Submit.Submit();

            Assert.IsTrue(homePage.HeaderText.Displayed);
            
        }

    }
}
