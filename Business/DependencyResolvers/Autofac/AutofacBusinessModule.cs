using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<DefectManager>().As<IDefectService>().SingleInstance();
            builder.RegisterType<EfDefectDal>().As<IDefectDal>().SingleInstance();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().SingleInstance();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>().SingleInstance();

            builder.RegisterType<FabricManager>().As<IFabricService>().SingleInstance();
            builder.RegisterType<EfFabricDal>().As<IFabricDal>().SingleInstance();

            builder.RegisterType<MachineManager>().As<IMachineService>().SingleInstance();
            builder.RegisterType<EfMachineDal>().As<IMachineDal>().SingleInstance();

            builder.RegisterType<OrderManager>().As<IOrderService>().SingleInstance();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>().SingleInstance();

            builder.RegisterType<OrderProcessManager>().As<IOrderProcessService>().SingleInstance();
            builder.RegisterType<EfOrderProcessDal>().As<IOrderProcessDal>().SingleInstance();

            builder.RegisterType<PantManager>().As<IPantService>().SingleInstance();
            builder.RegisterType<EfPantDal>().As<IPantDal>().SingleInstance();

            builder.RegisterType<WashingTypeManager>().As<IWashingTypeService>().SingleInstance();
            builder.RegisterType<EfWashingTypeDal>().As<IWashingTypeDal>().SingleInstance();



            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>().SingleInstance();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}