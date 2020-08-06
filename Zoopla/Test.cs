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
using Zoopla.TestCases;

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
        
        [Test, Order(1) ]
        public void TestNews()
        {

            call = new Login(driver);
            call.Calling();
        }
        [Test,Order(2)]
        public void AddPeople()
        {
             call = new AddPeoples(driver);
            call.Calling();

        }
        [Test, Order(3)]
        public void AddCase()
        {
            call = new AddCase(driver);
            call.Calling();

        }
          [Test, Order(4)]
        public void CLose()
        {
            
            driver.Close();
            driver.Quit();
        }
    }
}
