﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;

namespace BLL
{
    public class BaseBLL<T>:IBaseBLL<T> where T:class ,new()
    {
        public virtual string Hello()
        {
            return null;
        }
    }
}
