using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using MyFrameWork.DAL;
using MyFrameWork.DI;
using MyFrameWork.Migrations;

namespace MyFrameWork
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //自动更新migration
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EFDBContext, Configuration>());

            IOCConfig.RegisterAutofac();
        }
    }
}
