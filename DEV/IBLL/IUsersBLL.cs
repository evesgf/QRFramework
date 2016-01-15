using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IUsersBLL<T> : IBaseBLL<T> where T : class
    {
    }
}
