using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFrameWork.Entitys;

namespace MyFrameWork.DAL
{
    public class EFDBContext:DbContext
    {
        public EFDBContext() : base("EFDBContext")
        {
        }

        //指定实体集
        public DbSet<Users> Users { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }

        //重写创建方法指定命名规则为单数
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
