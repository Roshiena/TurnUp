using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V125.WebAuthn;
using System;
using OpenQA.Selenium.Support;
using TU2024.Pages;
using TU2024.Utilities;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;



namespace TU2024.Tests
{

    public class TMTest : Drivers



    {
        LoginPage loginPageObject = new LoginPage();
        Homepage homePageObj = new Homepage();
        TMPage tmPageObj = new TMPage();


        [SetUp]
        public void LoginTest()
        {
            driver = new ChromeDriver();

            loginPageObject.LoginSteps();
            homePageObj.GoToTMPage();

        }

        [Test]
        public void ACreateTMTest()
        {
            tmPageObj.CreateRecord(driver);
        }

        [Test]
        public void BEditTMTest()
        {
            tmPageObj.UpdateRecord(driver);
        }

        [Test]
        public void CDeleteTMTest()
        {
            tmPageObj.DeleteRecord(driver);

        }
    }

       // [TearDown]

        //public void CloseTest()
        //{
        //    driver.Quit();
        //}
    
}






        
       


