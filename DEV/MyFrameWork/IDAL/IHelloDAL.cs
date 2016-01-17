using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFrameWork.IBLL;

namespace MyFrameWork.IDAL
{
    public interface IHelloDAL: IDependency
    {
        string HelloDALstr();
    }
}
