using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zoopla.TestCases
{
     public class AddCase:ICall
    {

        public IWebDriver driver;

        public AddCase(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

       
        [FindsBy(How = How.XPath, Using = "/html/body/nav/div[3]/div[1]/div[1]")]
        public IWebElement Addcase;
        [FindsBy(How = How.XPath, Using = "/html/body/nav/div[3]/div[1]/div[2]/a[4]")]
        public IWebElement Case;
        [FindsBy(How = How.XPath, Using = "//a[@id='ember20']")]
        public IWebElement Peopleacs;
        [FindsBy(How = How.XPath, Using = "//a[@id='ember20']")]
        public IWebElement Peoplevas;
        [FindsBy(How = How.XPath, Using = "//a[@id='ember20']")]
        public IWebElement Peoplceas;

        public void Calling()
        {
            Thread.Sleep(400);
           // Case.Click();
            Thread.Sleep(400);
            Addcase.Click();
            Thread.Sleep(400);
            Case.Click();

        }
    }
}
