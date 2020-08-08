using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoopla.Base;
using Zoopla.Pages;
using Zoopla.TestCases;

namespace Zoopla
{

    [TestFixture("chrome")]
    [Parallelizable]
    public class TestCase2:BaseC
    {
        IWebDriver driver;
        ICall call;
        public TestCase2(string browserName)
        {

            driver = StartBrowser("chrome");
        }

        [Test, Order(1)]
        public void Login()
        {

            call = new Login(driver);
            call.Calling();
        }
        [Test, Order(2)]
        public void Header()
        {

          AccountSetting  call = new AccountSetting(driver);
            call.Calling();
            call.AddUsers("Steve","XYZ","abc@gmail.com","xyz");

        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}
