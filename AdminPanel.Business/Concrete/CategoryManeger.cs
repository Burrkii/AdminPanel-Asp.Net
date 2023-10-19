using AdminPanel.Business.Abstract;
using AdminPanel.Business.Contants;
using AdminPanel.DataAccess.Abstract;
using AdminPanel.Entities.Abstract.Utilities.Results;
using AdminPanel.Entities.Concrete;
using AdminPanel.Entities.Concrete.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Business.Concrete
{
    public class CategoryManeger : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManeger(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        private List<OperationClaim> operationClaims = new List<OperationClaim>()
        {
             new OperationClaim{Id=2}
        };
        public bool CanAddCategory(int roleId)
        {
            return operationClaims.Any(p => p.Id == roleId);
        }
        public void AddCategory(Category category)
        {
            _categoryDal.Add(category);
            new SuccessResult(Messages.CategoryAdded);
        }

        public bool CanDeletecategory(int roleId)
        {
            return operationClaims.Any(p => p.Id == roleId);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.delete(category);
            new SuccessResult(Messages.CategoryAdded);
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList()); ;
        }
    }
}
