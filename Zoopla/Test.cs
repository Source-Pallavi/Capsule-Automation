using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zoopla.Base;
using Zoopla.Pages;

namespace Zoopla
{
    [TestFixture("chrome")]
    [Parallelizable]
    public class Test:BaseC
    {
        IWebDriver driver;
        ICall call;
        public Test(string browserName)
        {
           
                driver = StartBrowser("chrome");
            }

                [Test]
        public void TestNews()
        {

            call = new Login(driver);
            call.Calling();
        }
    }
}
