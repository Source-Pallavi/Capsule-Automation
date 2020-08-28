using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zoopla
{
  public  class ScreenS
    {
        public static string Capture(IWebDriver driver, string screenShotName)
        {   //screenshot
            string localpath = "";
            try
            {
                Thread.Sleep(4000);
                ITakesScreenshot ts = (ITakesScreenshot)driver;//(down casting)
                Screenshot screenshot = ts.GetScreenshot();
                string finalpth = @"C:\Users\rebel\source\repos\Zoopla\Zoopla\ScreenShot\" + screenShotName + TakesScreenshotWithDate() + ".png";
                localpath = new Uri(finalpth).LocalPath;
                screenshot.SaveAsFile(localpath);
            }
            catch (Exception e)
            {
                throw (e);
            }
            return localpath;

        }
        private static StringBuilder TakesScreenshotWithDate()
        {
            //Updates the number of screenshots that we took during the execution

            StringBuilder TimeAndDate = new StringBuilder(DateTime.Now.ToString());
            TimeAndDate.Replace("/", "_");
            TimeAndDate.Replace(":", "_");
            return TimeAndDate;
        }
    }
}
