using AdminPanel.DataAccess.Abstract;
using AdminPanel.DataAccess.Concrete.EntityFramework;
using AdminPanel.DataAccess.Concrete.EntityFramework.Context;
using AdminPanel.Entities.Abstract;
using AdminPanel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.DataAccess.Concrete
{
    public class EfProductDal : EfRepositoryBase<Product, AdminPanelContext>, IProductDal
    {

    }
}
