using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.IBLL
{
    public interface IBaseBLL<T>:where T:class,new()
    {
    }
}
