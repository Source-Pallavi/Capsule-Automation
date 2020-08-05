using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoopla
{

    public class SendData
    {
        IWebDriver driver = new ChromeDriver();
        [FindsBy(How = How.XPath, Using = "//input[@id='search-input-location']")]
        public IWebElement Search;
            [FindsBy(How = How.XPath, Using ="ui-button-primary ui-cookie-accept-all-medium-large")]
        public IWebElement cookies;

        public SendData(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void send()
        {
            cookies.Click();
            Search.SendKeys("London");
        }

    }
}
