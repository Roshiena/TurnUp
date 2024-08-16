using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V125.WebAuthn;





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
    

