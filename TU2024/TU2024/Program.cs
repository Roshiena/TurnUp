using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V125.WebAuthn;
using System;
using OpenQA.Selenium.Support;





internal class Program
{
    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        driver.Manage().Window.Maximize();

        IWebElement userName = driver.FindElement(By.Id("UserName"));
        userName.SendKeys("hari");
        IWebElement passWord = driver.FindElement(By.Name("Password"));
        passWord.SendKeys("123123");
        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();
        Thread.Sleep(2000);
        IWebElement profileIcon = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));


        if (profileIcon.Text == "Hello hari!")
        {
            Console.WriteLine("Logged in successfully, Test Passed");
        }
        else
        {
            Console.WriteLine("Logged in failed, Test Failed");
        }

        //create time record

        IWebElement adminDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        adminDropdown.Click();
        IWebElement tmSelect = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        tmSelect.Click();
        IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        createButton.Click();
        IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]"));
        typeCode.Click();
        Thread.Sleep(2000);
        IWebElement timeSelect = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        timeSelect.Click();
        IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
        codeTextbox.SendKeys("Vitamin03");
        IWebElement descpTextbox = driver.FindElement(By.Id("Description"));
        descpTextbox.SendKeys("Organic Multi-Vitamins");
        IWebElement inputTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        inputTag.Click();
        IWebElement priceField = driver.FindElement(By.Id("Price"));
        priceField.SendKeys("12.50");

        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();
        Thread.Sleep(2000);

        IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        lastPage.Click();

        IWebElement createdRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

        if (createdRecord.Text == "Vitamin03") 
        {
            Console.WriteLine("Record is created successfully");

        }
        else
        {
            Console.WriteLine("Failed to create new record");
        }
    }
}