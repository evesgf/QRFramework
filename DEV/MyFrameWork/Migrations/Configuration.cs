namespace MyFrameWork.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyFrameWork.DAL.EFDBContext>
    {
        public Configuration()
        {
            //¿ªÆô×Ô¶¯Ç¨ÒÆ
            AutomaticMigrationsEnabled = true;
            ContextKey = "MyFrameWork.DAL.EFDBContext";
        }

        protected override void Seed(MyFrameWork.DAL.EFDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
