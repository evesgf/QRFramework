using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;

namespace MyFrameWork.DI
{
    public class IOCConfig
    {
        public static void RegisterAutofac()
        {
            //配置autofac
            var builder = new ContainerBuilder();
            //注册了当前程序集内所有的controller类
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //注册了当前程序集内的所有类
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}
