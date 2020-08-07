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
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[1]/div/form/div/div[1]/div/div/div/input")]
        public IWebElement Name;
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[1]/div/form/div/div[1]/div/div/div[2]")]
        public IWebElement Selectname;
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[1]/div/form/div/div[3]/div/input")]
        public IWebElement CaseName;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[1]/div/form/footer/div/button[1]")]
        public IWebElement Save;

        public void Calling()
        {
           
            Thread.Sleep(4000);

            Addcase.Click();
            Thread.Sleep(4000);

            Case.Click();
            Thread.Sleep(400);


            Name.SendKeys("Pranjali .k");
            Thread.Sleep(4000);

           Selectname.Click();
            Thread.Sleep(5000);

            CaseName.SendKeys("Automating");
            Thread.Sleep(5000);

            Save.Click();
            Thread.Sleep(5000);


        }
    }
}
