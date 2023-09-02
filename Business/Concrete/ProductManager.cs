using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAllProducts()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _productDal.GetAll(x => x.CategoryId == categoryId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(x => x.UnitPrice > min && x.UnitPrice < max);
        }

        public List<ProductDetailDto> GetAllProductsDetail()
        {
            return _productDal.GetProductDetail();
        }
    }
}
