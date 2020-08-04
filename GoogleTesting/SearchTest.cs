using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace GoogleTesting
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("Start Maximed");
            IWebDriver webDriver = new ChromeDriver(options);
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
            webDriver.Navigate().GoToUrl("http://www.google.com");
            IWebElement textField = webDriver.FindElement(By.Name("q"));
            textField.SendKeys("Automation testing");
            IWebElement searchButton = webDriver.FindElement(By.CssSelector("Input[value='Google Search']"));
            searchButton.Click();
            webDriver.Dispose();
        }


    }
}
