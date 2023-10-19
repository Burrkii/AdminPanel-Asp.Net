using AdminPanel.Entities.Abstract.Utilities.Results;
using AdminPanel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetList();
        bool CanAddCategory(int roleId);
        void AddCategory(Category category);
        bool CanDeletecategory(int roleId);
        void DeleteCategory(Category category);
    }
}
