using AdminPanel.Entities.Abstract.Utilities;
using AdminPanel.Entities.Abstract.Utilities.Results;
using AdminPanel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>>GetList();
        IDataResult<List<Product>>GetListByCategory(int categoryId);
        //IResult Add(Product product);// ekleme işlemi şuanda kullanılmamakta ama başka bir gün herkes ürün eklmek ister veya silmek isterse product maneger tarafında kodlanması lazım
        bool CanAddProduct(int roleId);
        void AddProduct(Product product);
        bool CanDeleteProduct(int roleId);
        void DeleteProduct(Product product);
        IResult Update(Product product);
       // IResult Delet(Product product); // silme işlemi şuanda kullanılmamakta ama başka bir gün herkes ürün eklmek ister veya silmek isterse product maneger tarafında kodlanması lazım
    }
}
