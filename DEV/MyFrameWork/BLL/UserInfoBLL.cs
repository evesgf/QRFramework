using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFrameWork.DAL;
using MyFrameWork.IBLL;

namespace MyFrameWork.BLL
{
    public partial class UserInfoBLL:BaseBLL<UserInfo>,IUserInfoBLL
    {
        public override string Show()
        {
            return "hello show";
        }
    }
}
