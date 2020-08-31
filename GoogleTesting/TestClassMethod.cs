using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;


namespace GoogleTesting
{
    class TestClassMethod
    {
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "ID")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }

            if (elementtype == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "ID")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            if (elementtype == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
        }
        public static void DropDown(IWebDriver driver, string element, string value, string elementype)
        {

            if (elementype == "ID")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);

            }
            if (elementype == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }
        }

    }
}
