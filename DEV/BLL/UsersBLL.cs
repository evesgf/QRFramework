using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model.Entitys;

namespace BLL
{
    public class UsersBLL : BaseBLL<Users>, IUsersBLL
    {
        public string MyHello()
        {
            return "Hello from users";
        }

        public void UserBLLMethod()
        {
            throw new NotImplementedException();
        }
    }
}
