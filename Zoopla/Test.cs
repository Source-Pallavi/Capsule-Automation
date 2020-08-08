using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
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
using Zoopla.SendEmails;


namespace Zoopla
{
    [TestFixture("chrome")]
    [Parallelizable]
    public class Test:BaseC
    {
      /*  IWebDriver driver;
        ICall call;
        protected ExtentReports _extent = null;
        protected ExtentTest _test = null;
        ///For report directory creation and HTML report template creation
        ///For driver instantiation
        public static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Test(string browserName)
        {
            try
            {
                driver = StartBrowser("chrome");
                _extent = new ExtentReports();
                var htmlReporter = new ExtentHtmlReporter(@"C:\Users\rebel\source\repos\Zoopla\Zoopla\ExtentReport\extent.html");
                //To create report directory and add HTML report into it
                _extent.AddSystemInfo("User Name", "Pallavi");
                _extent.AttachReporter(htmlReporter);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        
        [Test, Order(1) ]
        public void Login()
        {

            call = new Login(driver);
            call.Calling();
            
        }
        [Test,Order(2)]
        public void AddPeople()
        {
             call = new AddPeoples(driver);
            // call.Calling();
          

        }
        [Test, Order(3)]
        public void AddCase()
        {
            call = new AddCase(driver);
           // call.Calling();
          

        }
        [Test, Order(4)]
        public void StatusCheck()
        {
            ValidateTheCase validate = new ValidateTheCase(driver);
           // Assert.AreEqual( validate.Validate()[0], "Pranjali .k");
           // Assert.AreEqual(validate.Validate()[1], "Open");
            

        }


        [TearDown]
        public void AfterTest()
        {
            try
            {
                _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var stacktrace = "" + TestContext.CurrentContext.Result.StackTrace + "";
                var errorMessage = TestContext.CurrentContext.Result.Message;
                Status logstatus;
                switch (status)
                {
                    case TestStatus.Failed:
                        logstatus = Status.Fail;
                        string screenShotPath = ScreenS.Capture(driver, TestContext.CurrentContext.Test.Name);
                        _test.Log(logstatus, "Test ended with " + logstatus + " – " + errorMessage);
                        _test.Log(logstatus, "Snapshot below: " + _test.AddScreenCaptureFromPath(screenShotPath));
                        break;
                    case TestStatus.Skipped:
                        logstatus = Status.Skip;
                        _test.Log(logstatus, "Test ended with " + logstatus);
                        break;
                    default:
                        logstatus = Status.Pass;
                        _test.Log(logstatus, "Test ended with " + logstatus);
                        break;
                }
            }
            catch (Exception e)
            {
                throw (e);
            }


        }
         [OneTimeTearDown]
        public void CLose()
        {

            try
            {
                _extent.Flush();
                driver.Close();
                driver.Quit();
                SendMail.Send_Report_In_Mail();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }*/
    }
}
