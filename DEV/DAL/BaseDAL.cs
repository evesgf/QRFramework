using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;

namespace DAL
{
    public class BaseDAL<T>:IDAL.IBaseDAL<T> where T:class,new()
    {
        public virtual string Say()
        {
            return null;
        }
    }
}
