using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model.Entitys;

namespace BLL
{
    public class UsersBLL<T> : BaseBLL<T>, IUsersBLL<T> where T : class
    {
        public override string Hello()
        {
            return "Hello from users";
        }
    }
}
