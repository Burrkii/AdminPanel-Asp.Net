using AdminPanel.DataAccess.Abstract;
using AdminPanel.DataAccess.Concrete.EntityFramework.Context;
using AdminPanel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfRepositoryBase<Category, AdminPanelContext>, ICategoryDal
    {
    }
}
