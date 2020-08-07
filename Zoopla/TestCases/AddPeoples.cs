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
    public class AddPeoples:ICall
    {
        public IWebDriver driver;

        public AddPeoples(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@id='ember20']")]
        public IWebElement People;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[1]/div[2]/a[1]")]
        public IWebElement AddPeople;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[1]/div/form/div/div[1]/div[1]/div/div[1]")]
        public IWebElement Title;

        [FindsBy(How = How.Id, Using = "select-box-el-72")]
        public IWebElement Pre;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/input[1]")]
        public IWebElement name;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[3]/input[1]")]
        public IWebElement Lname;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[1]/div[1]/div[1]/form[1]/div[1]/div[2]/div[1]/input[1]")]
        public IWebElement Job;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[1]/div[1]/div[1]/form[1]/div[1]/div[2]/div[2]/div[1]/div[1]/input[1]")]
        public IWebElement Company;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[1]/div[1]/div[1]/form[1]/footer[1]/div[1]/button[1]")]
        public IWebElement Submit;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/form/footer/div/button[1]")]
        public IWebElement OK;

        public void Calling()
        {
            Thread.Sleep(5000);
            People.Click();

            Thread.Sleep(5000);
            AddPeople.Click();

            Thread.Sleep(5000);
            Title.Click();
            Thread.Sleep(5000);

             Pre.Click();
            Thread.Sleep(5000);

            name.SendKeys("Pranjali");
            Thread.Sleep(5000);

            Lname.SendKeys(".k");
            Thread.Sleep(500);

            Job.SendKeys("QA Engineer");
            Thread.Sleep(5000);

            Company.SendKeys("Bridge Labz");
            Thread.Sleep(200);

            Submit.Click();
            Thread.Sleep(5000);

            OK.Click();

        }
    }
}
