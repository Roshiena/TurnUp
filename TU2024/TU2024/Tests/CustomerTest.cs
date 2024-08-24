using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TU2024.Pages;
using TU2024.Utilities;

namespace TU2024.Tests
{
    public class CustomerTest : Drivers
    {
        LoginPage loginPageObj = new LoginPage();
        Homepage homePageObj = new Homepage();

        [SetUp]
        public void LoginAction()
        {
            driver = new ChromeDriver();
            loginPageObj.LoginSteps();
            homePageObj.GoToCustomersPage();
        }

        [Test]

        public void CreateCustomerTest()
        {
            loginPageObj.LoginSteps();
            homePageObj.GoToCustomersPage();
        }
    }
}
