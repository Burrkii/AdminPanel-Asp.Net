using AdminPanel.Business.Abstract;
using AdminPanel.Business.Contants;
using AdminPanel.Business.ValidationRules.FluentValidation;
using AdminPanel.DataAccess.Abstract;
using AdminPanel.Entities.Abstract.Utilities;
using AdminPanel.Entities.Abstract.Utilities.Results;
using AdminPanel.Entities.Concrete;
using AdminPanel.Entities.Concrete.Results;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;

namespace AdminPanel.Business.Concrete
{
    public class ProductManeger : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManeger(IProductDal productDal)
        {
            _productDal = productDal;
        }
        //public IResult Add(Product product)
        //{
        //    ProductValidator productvalidator=new ProductValidator();
        //    var result = productvalidator.Validate(product);
        //    if (!result.IsValid)
        //    {
        //        throw new ValidationException(result.Errors);
        //    }

        //    //if ()
        //    //{
        //    //    _productDal.Add(product);
        //    //    return new SuccessResult(Messages.ProductAdded);
        //    //}
        //    _productDal.Add(product);
        //    return new SuccessResult(Messages.ProductAdded);
        //}
        private List<OperationClaim> operationClaims = new List<OperationClaim>()
        {
            new OperationClaim{Id=1}
           
        };
        public bool CanAddProduct(int roleId)
        {
            return operationClaims.Any(p => p.Id == roleId);
        }
        public void AddProduct(Product product)
        {
            _productDal.Add(product);
             new SuccessResult(Messages.ProductAdded);

        }



        //public IResult Delet(Product product)
        //{
        //    //if (UserOperationClaim=1)
        //    //{
        //    //   _productDal.delete(product);
        //    //   return new SuccessResult(Messages.ProductDeleted);
        //    //}
        //    _productDal.delete(product);
        //    return new SuccessResult(Messages.ProductDeleted );
        //}

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(filter: p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList());
        }

        public IDataResult<List<Product>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(p => p.CategoryId == categoryId).ToList());
        }

        public IResult Update(Product product)
        {
            _productDal.update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public bool CanDeleteProduct(int roleId)
        {
            return operationClaims.Any(p => p.Id == roleId);
        }

        public void DeleteProduct(Product product)
        {
            _productDal.delete(product);
             new SuccessResult(Messages.ProductDeleted);
        }
    }
}
