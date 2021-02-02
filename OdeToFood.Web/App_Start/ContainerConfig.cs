using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using OdeToFood.Data.Services;
using RepairShop.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace RepairShop.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            //build RepairOrder class
            builder.RegisterType<SqlRepairOrderData>().As<IRepairOrderData>().InstancePerRequest();
            //builder.RegisterType<RepairShopDbContext>().InstancePerRequest();
            //build Part class
            builder.RegisterType<SqlPartData>().As<IPartData>().InstancePerRequest();
            //builder.RegisterType<PartsDbContext>().InstancePerRequest();
            //build Proberen DbContext te combineren
            builder.RegisterType<CollectieDbContext>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);

        }
    }
}