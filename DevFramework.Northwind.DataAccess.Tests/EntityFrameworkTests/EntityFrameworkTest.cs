﻿using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevFramework.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList();

            Assert.AreEqual(79, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList(p => p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);

        }


        [TestMethod]
        public void Get_all_returns_all_categories()
        {
            EfCategoryDal categoryDal = new EfCategoryDal();

            var result = categoryDal.GetList();

            Assert.AreEqual(8, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_categories()
        {
            EfCategoryDal categoryDal = new EfCategoryDal();
            var result = categoryDal.GetList(p => p.CategoryName.Contains("od"));

            Assert.AreEqual(3, result.Count);

        }
    }
}
