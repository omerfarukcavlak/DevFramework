using DevFramework.Core.DataAccess;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Abstract
{
    public interface IUserRoleDal : IEntityRepository<UserRole>
    {
    }
}
