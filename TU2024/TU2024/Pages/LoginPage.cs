using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TU2024.Utilities;
using NUnit.Framework;



namespace TU2024.Pages
{
    public class LoginPage : Drivers
    {
        

        public void LoginSteps()
        {

          
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();

            try
            {
                IWebElement userName = driver.FindElement(By.Id("UserName"));
                userName.SendKeys("hari");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to locate userName button.", ex.Message);
            }
            
            IWebElement passWord = driver.FindElement(By.Name("Password"));
            passWord.SendKeys("123123");
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            
        }
    }
}
