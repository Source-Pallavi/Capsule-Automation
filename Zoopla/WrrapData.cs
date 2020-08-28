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
        //declaring webdriver
        public IWebDriver driver;
        //constructor for using pom
        public WrrapData(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        //method so it will return object array containing max min and size of IwebList
        public Object[] Wrappup(String Path,String PathBy)
        {
            IList<IWebElement> header=null;
            // web sracping by linktxt
            if (PathBy == "LinkText")
            {
                header = driver.FindElements(By.LinkText(Path));

            } 
            //web sracping by class

            if (PathBy == "Class")
            {
                 header = driver.FindElements(By.ClassName(Path));
            }
            List<string> mylist = new List<string>();
            foreach (var items in header)
            {

                string text = items.Text;
                mylist.Add(text);
            }
            Thread.Sleep(200000);
            mylist.Sort();
            int count = header.Count();
            Object[] array= { count,mylist[0],mylist[header.Count-1] };
            return array;
        }

       
    }
}
