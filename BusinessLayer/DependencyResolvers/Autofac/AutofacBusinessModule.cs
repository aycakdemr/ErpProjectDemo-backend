using Autofac;
using Autofac.Extras.DynamicProxy;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Castle.DynamicProxy;
using DataAccessLayer.Abtract;
using DataAccessLayer.Concrete.NpgSql;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<TableManager>().As<ITableService>().SingleInstance();
            builder.RegisterType<BranchManager>().As<IBranchService>().SingleInstance();
            builder.RegisterType<SectionManager>().As<ISectionService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<EfBranchDal>().As<IBranchDal>().SingleInstance();
            builder.RegisterType<EfTableDal>().As<ITableDal>().SingleInstance();
            builder.RegisterType<EFSectionDal>().As<ISectionDal>().SingleInstance();
            
        }
    }
}
