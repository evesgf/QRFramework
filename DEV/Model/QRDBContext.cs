using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entitys;

namespace Model
{
    public class QRDBContext:DbContext
    {
        //构造连接字符串
        public QRDBContext() : base("QRDBContext")
        {
        }

        //指定实体集
        public DbSet<Users> Users { get; set; }

        //重写创建方法指定命名规则为单数
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
