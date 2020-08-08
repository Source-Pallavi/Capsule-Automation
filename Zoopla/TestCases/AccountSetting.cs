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

        [FindsBy(How = How.XPath, Using = "/html/body/nav/div[3]/div[2]/div")]
        public IWebElement AccountSettings;

        [FindsBy(How = How.XPath, Using = "/html/body/nav/div[3]/div[2]/div[2]/a[2]")]
        public IWebElement AccountSet;

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Export Data')]")]
        public IWebElement Export;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/section/div/button")]
        public IWebElement ExportReport;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div[1]/a/h4")]
        public IWebElement Apprearance;
        [FindsBy(How = How.XPath, Using = "//input[@name='appearance:uploadDecorate:logoImage']")]
        public IWebElement UploadFile;
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div")]
        public IWebElement LimitExide;
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div[2]/a/h4")]
        public IWebElement UserAndTeams;
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[1]/form[1]/div[1]/div[2]/a[1]")]
        public IWebElement AddUser;
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/span[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/span[1]/input[1]")]
        public IWebElement EnterName;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/span/div[2]/div/form/div[1]/div/div/div[1]/div[2]/div/div/span/input")]
        public IWebElement LastName;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/span/div[2]/div/form/div[1]/div/div/div[2]/div/span/input")]
        public IWebElement EmailID;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/span/div[2]/div/form/div[1]/div/div/div[3]/div/span/input")]
        public IWebElement Username;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/span/div[2]/div/form/div[3]/ul/li[1]/input")]
        public IWebElement Invite;
        public void Calling()
        {
            Thread.Sleep(5000);
            AccountSettings.Click();
            Thread.Sleep(5000);
            AccountSet.Click();
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(5000);
            Export.Click();
            Thread.Sleep(5000);
            ExportReport.Click();
            Thread.Sleep(5000);
            if (LimitExide.Text == ("Account export limit reached, please try again later."))
            {
                AccountSettings.Click();
                Thread.Sleep(5000);
                AccountSet.Click();
            }
            js.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(5000);
           // Apprearance.Click();
           // Thread.Sleep(5000);
           // UploadFile.Click();
         //   Thread.Sleep(5000);
          //  Process.Start("C:\\Users\\rebel\\source\\repos\\Zoopla\\Zoopla\\FileUpload");
         //   Thread.Sleep(3000);
           

        }
       public  void  AddUsers(String name, String lastName, String emailid, String userid)
        {
            Thread.Sleep(5000);
            UserAndTeams.Click();
            Thread.Sleep(5000);
            AddUser.Click();
            Thread.Sleep(5000);
            EnterName.SendKeys(name);
            Thread.Sleep(5000);
            LastName.SendKeys(lastName);
            Thread.Sleep(5000);
            EmailID.SendKeys(emailid);
            Thread.Sleep(5000);
            Username.SendKeys(userid);
            Thread.Sleep(5000);
            Invite.Click();
            Thread.Sleep(5000);

        }


    }
}
