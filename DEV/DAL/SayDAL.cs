using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model.Entitys;

namespace DAL
{
    public class SayDAL:BaseDAL<Users>,IUserDAL
    {
        public override string Say()
        {
            return "Hello World";
        }
    }
}
