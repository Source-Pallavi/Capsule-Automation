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
           // call.AddUsers("Stjxcxeevee","mXYtczyZ","anbbbggvczxcccc@gmail.com","xcdcdnvxxfyz");

        }
        [Test, Order(3)]
        public void AddMileStones()
        {

            AccountSetting call = new AccountSetting(driver);
            
        //   call.Opportunities("ABCDD", "10","100");

        }
        [Test, Order(4)]
        public void TaskCategories()
        {

            AccountSetting call = new AccountSetting(driver);

         //   call.Task("Pallaviivmii");

        }
        [Test, Order(5)]
        public void AddTags()
        {

            AccountSetting call = new AccountSetting(driver);
            String Tag = "Shubhaazsaaaaa";
            Assert.AreEqual(call.Tags(Tag), Tag);


        }
        [Test, Order(6)]
        public void Integration()
        {

            AccountSetting call = new AccountSetting(driver);

          var count=  call.Integrations();
            Assert.AreEqual(count, 11);

        }
        [Test, Order(0)]
        public void Internet()
        {

            Internet check = new Internet(driver);
            System.Console.WriteLine(check.IsConnectedToInternet());

        }


        [OneTimeTearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}
