using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MyFrameWork.Entitys;
using MyFrameWork.IDAL;

namespace MyFrameWork.DAL
{
    public class UserInfoDAL:BaseDAL<UserInfo>,IUserInfoDAL
    {
        public IQueryable<Users> GetListBy<TKey>(Expression<Func<Users, bool>> whereLambda, Expression<Func<Users, TKey>> orderLambda)
        {
            throw new NotImplementedException();
        }
    }
}
