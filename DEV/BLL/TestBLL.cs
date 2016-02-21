using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAL;

namespace BLL
{
    public class TestBLL:ITestBLL
    {
        private readonly IBaseDAL _iBaseDal;

        public TestBLL(IBaseDAL ibBaseDal)
        {
            _iBaseDal = ibBaseDal;
        }

        public string Hello()
        {
            return "Hello World from testbll,id:"+ _iBaseDal.GetId();
        }
    }
}
