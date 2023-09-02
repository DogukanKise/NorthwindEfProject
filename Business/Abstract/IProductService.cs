using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        List<Product> GetAllByCategoryId(int categoryId);
        List<Product> GetByUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetAllProductsDetail();
    }
}
