using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Microsoft.Owin;

using Owin;
using Tier.Repository;
using Tier.Repository.Infrastructure;
using Tier.Repository.Repositories;
using Tier.Services;

[assembly: OwinStartup(typeof(Build_Infrastructure_ASP.NetFramework.App_Start.Startup))]

namespace Build_Infrastructure_ASP.NetFramework.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigAutofac(app);
        }

        public void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<DataSoure_DbContext>().AsSelf().InstancePerRequest();

            // Register Service
            builder.RegisterAssemblyTypes(typeof(ProductCategoryService).Assembly)
                .Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces()
                .InstancePerRequest();

            // Register Repository
            builder.RegisterAssemblyTypes(typeof(ProductCategoryRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces()
                .InstancePerRequest();

            // day vao 1 container và khởi tạo nó
            Autofac.IContainer container = builder.Build();

            // Set the WebMVC DependencyResolver
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //Set the WebApi DependencyResolver
            GlobalConfiguration.Configuration.DependencyResolver = 
                new AutofacWebApiDependencyResolver((IContainer)container); 

        }
    }
}
