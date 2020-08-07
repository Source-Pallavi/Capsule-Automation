using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoopla.Base
{
   public class BaseC
    {
        IWebDriver driver = null;
        ChromeOptions optionss = new ChromeOptions();
        public IWebDriver StartBrowser(String browserName)
        {

            try
            {
                
                optionss.AddArgument("--incognito");
                if (browserName.ToLower().Equals("")) throw (new Exception("BROWSER_NAME is not specified"));
                if (browserName.ToLower().Equals("chrome")) driver = new ChromeDriver(optionss);
                if (browserName.ToLower().Equals("firefox")) driver = new FirefoxDriver();
            }
            catch (Exception e)
            {
                throw (new Exception("BROWSER_NAME is not specified"));
            }
           /* var desiredCapabilities;
            var options = new ChromeOptions();
            options.AddArgument(@"--incognito");
            options.AddArgument("--start-maximized");
            desiredCapabilities.SetCapability(ChromeOptions.Capability, options);*/
            driver.Url = "https://bridgelabz.capsulecrm.com/login";
            driver.Manage().Window.Maximize();
            return driver;
        }

    }
}
