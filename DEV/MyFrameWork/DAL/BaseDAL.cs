using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MyFrameWork.IDAL;

namespace MyFrameWork.DAL
{
    public class BaseDAL<T> :IBaseDAL<T> where T:class 
    {
        DbContext db=new EFDBContext();

        public IQueryable<T> GetListBy<TKey>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderLambda)
        {
            return db.Set<T>().Where(whereLambda).OrderBy(orderLambda);
        }
    }
}
