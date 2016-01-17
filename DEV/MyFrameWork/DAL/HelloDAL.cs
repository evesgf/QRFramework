using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFrameWork.IBLL;
using MyFrameWork.IDAL;

namespace MyFrameWork.DAL
{
    public class HelloDAL:IHelloDAL
    {
        public string HelloDALstr()
        {
            return "HelloDALstr";
        }
    }
}
