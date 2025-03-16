using Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DependencyResolvers.Autofac
{
    public class AutofacDataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<EfDefectDal>().As<IDefectDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfFabricDal>().As<IFabricDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfMachineDal>().As<IMachineDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfOrderProcessDal>().As<IOrderProcessDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfPantDal>().As<IPantDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfWashingTypeDal>().As<IWashingTypeDal>().InstancePerLifetimeScope();
   
            builder.RegisterType<EfUserDal>().As<IUserDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>().InstancePerLifetimeScope();
          
        }
    }
}
