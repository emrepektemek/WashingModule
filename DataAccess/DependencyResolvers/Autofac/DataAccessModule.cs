using Autofac;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DependencyResolvers.Autofac
{
    public class DataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<WashingModuleContext>();
                optionsBuilder.UseSqlServer(@"Server=MSI;Database=WashingModule;Trusted_Connection=True;TrustServerCertificate=True;");
                return new WashingModuleContext(optionsBuilder.Options);
            }).InstancePerLifetimeScope();

        }
    }
}
