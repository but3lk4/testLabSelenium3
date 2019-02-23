using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace testLabSelenium3
{
    public class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.CssSelector, Using =".entry-title")]
        public IWebElement MyAccount { get; set; }

        [FindsBy(How = How.Id, Using = "account")]
        public IWebElement HeaderText { get; set; }

        public void GoToPage()
        {
        driver.Navigate().GoToUrl("https://google.pl");
        }
    }
}
