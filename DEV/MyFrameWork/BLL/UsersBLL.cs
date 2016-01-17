using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFrameWork.IBLL;
using MyFrameWork.IDAL;

namespace MyFrameWork.BLL
{
    public class UsersBLL:IUsersBLL
    {
        private readonly IUserDAL _iUserDal;

        public UsersBLL(IUserDAL iUserDal)
        {
            _iUserDal = iUserDal;
        }

        public string Users()
        {
            return "Users " + _iUserDal.UserDALstr();
        }
    }
}
