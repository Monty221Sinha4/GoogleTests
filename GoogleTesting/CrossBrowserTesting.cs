using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Html5;

namespace GoogleTesting
{
    [TestClass]
    public class CrossBrowserTesting
    {
        [TestMethod]
        public void ChromeTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("Learn Automation");
            Thread.Sleep(2000);
            driver.Quit();

        }
        [TestMethod]
        public void FireFoxTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("Learn Automation");
            driver.Quit();
        }
        [TestMethod]
        public void InternetExplorerTest()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("LearnAutomation");
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
}
