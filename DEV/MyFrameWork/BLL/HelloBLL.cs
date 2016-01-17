using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFrameWork.IBLL;
using MyFrameWork.IDAL;

namespace MyFrameWork.BLL
{
    public class HelloBLL:IHlelloBLL
    {
        private readonly IHelloDAL _iHelloDal;

        public HelloBLL(IHelloDAL iHelloDal)
        {
            _iHelloDal = iHelloDal;
        }

        public string Hello()
        {
            return "Hello "+ _iHelloDal.HelloDALstr();
        }
    }
}
