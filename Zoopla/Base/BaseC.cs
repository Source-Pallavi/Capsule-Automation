﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
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

        public IWebDriver StartBrowser(String browserName)
        {

            try
            {
                if (browserName.ToLower().Equals("")) throw (new Exception("BROWSER_NAME is not specified"));
                if (browserName.ToLower().Equals("chrome")) driver = new ChromeDriver();
                if (browserName.ToLower().Equals("firefox")) driver = new FirefoxDriver();
            }
            catch (Exception e)
            {
                throw (new Exception("BROWSER_NAME is not specified"));
            }
            driver.Url = "https://bridgelabz.capsulecrm.com/login";
            driver.Manage().Window.Maximize();
            return driver;
        }

    }
}