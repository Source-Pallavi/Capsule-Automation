using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zoopla.TestCases
{
  public  class AccountSetting:ICall
    {
        public IWebDriver driver;

        public AccountSetting(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='select-box-el-33']")]
        public IWebElement AccountSettings;

        [FindsBy(How = How.XPath, Using = "/html/body/nav/div[3]/div[2]/div[2]/a[2]")]
        public IWebElement AccountSet;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div[2]/a/h4")]
        public IWebElement Export;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/section/div/button")]
        public IWebElement ExportReport;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div[1]/a/h4")]
        public IWebElement Apprearance;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/span[1]/div[2]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/span[1]/input[1]")]
        public IWebElement UploadFile;
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[1]/div/form/div/div[1]/div[1]/div/div[1]")]
        public IWebElement Titffqle;

        public void Calling()
        {
            Thread.Sleep(5000);
            AccountSettings.Click();
            Thread.Sleep(50000);
            AccountSet.Click();
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(5000);
            Export.Click();
            Thread.Sleep(5000);
            ExportReport.Click();
            Thread.Sleep(5000);
            AccountSettings.Click();
            Thread.Sleep(50000);
            AccountSet.Click();
            js.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(5000);
            Apprearance.Click();
            Thread.Sleep(5000);
            UploadFile.Click();
            Thread.Sleep(5000);
            Process.Start("C:\\Users\\rebel\\source\\repos\\Zoopla\\Zoopla\\FileUpload");
            Thread.Sleep(3000);
           

        }
    }
}
