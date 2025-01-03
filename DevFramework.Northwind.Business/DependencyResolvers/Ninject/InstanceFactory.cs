﻿using Ninject;

namespace DevFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetIsntance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule(),new AutoMapperModule());
            return kernel.Get<T>();
        }
    }
}
