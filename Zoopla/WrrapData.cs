using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zoopla
{
   public class WrrapData
    {

        public IWebDriver driver;
        public WrrapData(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public Object[] Wrappup( String Path,String PathBy)
        {
            IList<IWebElement> header=null;
            Thread.Sleep(2000);
            if (PathBy == "Class")
            {
                header = driver.FindElements(By.ClassName(Path));

            }
            if (PathBy == "TagName")
            {
                 header = driver.FindElements(By.TagName(Path));
            }
            List<string> mylist = new List<string>();
            foreach (var items in header)
            {

                string text = items.Text;
                mylist.Add(text);
            }
            mylist.Sort();
            int count = header.Count();
            Object[] array= { count,mylist[0],mylist[header.Count-1] };
            return array;
        }

       
    }
}
