using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoopla.Base;
using Zoopla.Pages;

namespace Zoopla
{
    [TestFixture("firefox")]
    [Parallelizable]
    public class Negative : BaseC
    {
        // negative scenariors
        IWebDriver driver;
        LoginN call;
        public Negative(string browserName)
        {
            driver = StartBrowser("chrome");
        }

        [Test, Order(1)]
        public void Login()
        {

            call = new LoginN(driver);
            call.Calling();
        }
        [Test, Order(2)]
        public void Login1()
        {
            //login with wrong details
            call = new LoginN(driver);
            call.Calling1();
        }
    }
}
