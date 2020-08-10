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
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div[5]/a/h4")]
        public IWebElement Oppotunitie;
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/form/div/div/button")]
        public IWebElement AddMileStone;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/form/div/div[1]/div/input")]
        public IWebElement MilStoneName;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/form/div/div[3]/div/input")]
        public IWebElement Percentage;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/form/div/div[4]/div/input")]
        public IWebElement Days;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/form/footer/div/button[1]")]
        public IWebElement Save;
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div[7]/a/h4")]
        public IWebElement Categories;
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[1]/div[2]/button")]
        public IWebElement AddCoverage;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/form/div/div[1]/div/input")]
        public IWebElement TaskName;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/form/div/div[2]/div/div/div[4]")]
        public IWebElement Color;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/form/footer/div/button[1]")]
        public IWebElement SaveTask;
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div[9]/a/h4")]
        public IWebElement Tag;
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/form/div/div[2]/button")]
        public IWebElement AddTag;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/form/div/div[1]/div/input")]
        public IWebElement TagName;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/form/footer/div/button[1]")]
        public IWebElement SaveTag;
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div[3]/a/h4")]
        public IWebElement Integration;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/form/footer/div/button[1]")]
        public IWebElement SaveTcag;


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
        public void Opportunities(String name, String days, String Percnt)
        {
            AccountSettings.Click();
            Thread.Sleep(5000);
            AccountSet.Click();
            Thread.Sleep(5000);
            Oppotunitie.Click();
            Thread.Sleep(5000);
            AddMileStone.Click();
            Thread.Sleep(5000);
            MilStoneName.SendKeys(name);
            Thread.Sleep(5000);
            Percentage.SendKeys(Percnt);
            Thread.Sleep(5000);
            Days.SendKeys(days);
            Thread.Sleep(5000);
            Save.Click();

        }

        public void Task(String name)
        {
            AccountSettings.Click();
            Thread.Sleep(5000);
            AccountSet.Click();
            Thread.Sleep(5000);
            Categories.Click();
            Thread.Sleep(5000);
            AddCoverage.Click();
            Thread.Sleep(5000);
            TaskName.SendKeys(name);
            Thread.Sleep(5000);
            Color.Click();
            Thread.Sleep(5000);
            SaveTask.Click();
            Thread.Sleep(5000);
        }

        public Object Tags(String name)
        {
            AccountSettings.Click();
            Thread.Sleep(5000);
            AccountSet.Click();
            Thread.Sleep(5000);
            Tag.Click();
            Thread.Sleep(5000);
            AddTag.Click();
            Thread.Sleep(5000);
            TagName.SendKeys(name);
            Thread.Sleep(5000);
            SaveTag.Click();
            Thread.Sleep(5000);
            WrrapData wrrap = new WrrapData(driver);
            return wrrap.Wrappup("hyperlink-button.hyperlink-button--plain", "Class")[2];
        }
        public Object Integrations()
        {
            Thread.Sleep(5000);
            AccountSettings.Click();
            Thread.Sleep(5000);
            AccountSet.Click();
            Thread.Sleep(5000);
            Integration.Click();
            Thread.Sleep(50000);
            WrrapData wrrap = new WrrapData(driver);
            return wrrap.Wrappup("Configure", "LinkText")[0];
        }

        }
}
