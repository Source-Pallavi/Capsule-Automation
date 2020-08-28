using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zoopla
{
  public  class Internet
    {
        //for checking internet connection
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        
        public static bool IsConnectedToInternet()
        {
            try
            {
                int Desc;
                return InternetGetConnectedState(out Desc, 0);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
