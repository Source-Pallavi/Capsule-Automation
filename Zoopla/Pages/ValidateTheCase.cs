using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoopla.Pages
{
   public class ValidateTheCase
    {
        public IWebDriver driver;

        public ValidateTheCase(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/section[1]/div[1]/div[2]/div[2]/div")]
        public IWebElement Person;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/section[2]/div[1]/div/span")]
        public IWebElement Status;

        public Object[] Validate()
        {
            Object[] arr = { Person.Text.Replace("for\r\n", ""), Status.Text };
            return arr ;
        }
    }
}
