using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaseBLL<T> where T:class
    {
         string Say()
         {
             return "hello";
         }
    }
}
