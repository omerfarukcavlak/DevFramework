using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevFramework.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NhibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList();

            Assert.AreEqual(79, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());
            var result = productDal.GetList(p=>p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);

        }

        [TestMethod]
        public void Get_all_returns_all_categories()
        {
            NhCategoryDal categoryDal = new NhCategoryDal(new SqlServerHelper());

            var result = categoryDal.GetList();

            Assert.AreEqual(8, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_categories()
        {
            NhCategoryDal categoryDal = new NhCategoryDal(new SqlServerHelper());
            var result = categoryDal.GetList(p=>p.CategoryName.Contains("od"));

            Assert.AreEqual(3, result.Count);

        }
    }
}
