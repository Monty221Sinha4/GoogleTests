using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;



namespace GoogleTesting
{
    [TestClass]
    
    public class UnitTesting
    {
        IWebDriver driver = new ChromeDriver();
        [TestMethod]
        public void UnitTest1()
        {
            TestClassMethod.DropDown(driver, "title", "Google", "ID");
            TestClassMethod.EnterText(driver, "initail", "executeaumtomation","Name");
            TestClassMethod.Click(driver, "Save", "Name");
        }

        [Test]
        [SetUp]
        public void Intialize()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("OpenedUrl");

        }
        public void ExecuteTest()
        {
            
            
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
