using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFrameWork.IBLL;

namespace MyFrameWork.BLL
{
    public abstract class BaseBLL<T>:IBaseBLL<T>where T:class 
    {
        public virtual string Show()
        {
            return "Show";
        }
    }
}
