﻿using DevFramework.Core.DataAccess;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Core.DataAccess.NHihabernate;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.Concrete.Managers;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Ninject.Modules;
using System.Data.Entity;

namespace DevFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();   
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();
            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
