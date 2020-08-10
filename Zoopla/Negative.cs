using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoopla.Base;

namespace Zoopla
{
    public class Negative : BaseC
    {
        IWebDriver driver;
        ICall call;
        public Negative(string browserName)
        {

            driver = StartBrowser("chrome");
        }

        [Test, Order(1)]
        public void Login()
        {

            call = new LogSinN(driver);
            call.Calling();
        }
    }
}
