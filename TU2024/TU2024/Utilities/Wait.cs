using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace TU2024.Utilities
{
    public class Wait
    {
        public static void WaitToBeClickable(IWebDriver driver, string locator, string locatorValue,int seconds)
        {
            var wait = new WebDriverWait(driver,new TimeSpan(0,0,seconds));

            if (locator == "XPath")
            {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }

            if (locator == "Id")

            {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }

            if(locator == "CssSelector")
            {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }


        }

        public static void WaitElementExists(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "XPath")
            {
                wait.Until(ExpectedConditions.ElementExists(By.XPath(locatorValue)));
            }

            if (locator == "Id")

            {
                wait.Until(ExpectedConditions.ElementExists(By.Id(locatorValue)));
            }

            if (locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
            }
        }

        public static void WaitToBeVisible(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "XPath")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }

            if (locator == "Id")

            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }

            if (locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));
            }
        }
    }
}
