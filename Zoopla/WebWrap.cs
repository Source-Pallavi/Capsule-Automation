using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoopla
{
  public  interface WebWrap
    {//interface for  providing abstraction 
         Object Wrappup(String Path, String Order, String PathBy);
    }
}
