using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFrameWork.IBLL
{
    public interface IBaseBLL<T>:IDependency where T:class
    {
        string  Show();
    }
}
