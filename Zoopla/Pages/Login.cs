using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zoopla.Pages
{
   public class Login : ICall
    {
        public IWebDriver driver;

        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='login:usernameDecorate:username']")]
        public IWebElement Userid;

        [FindsBy(How = How.XPath, Using = "//input[@id='login:passwordDecorate:password']")]
        public IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//input[@id='login:login']")]
        public IWebElement SignIn;

        public void Calling()
        {
            
            Userid.SendKeys("pallavidubey0823");
            Password.SendKeys("12respect34");

            SignIn.Click();
            Thread.Sleep(5000);
        }
    }
}
