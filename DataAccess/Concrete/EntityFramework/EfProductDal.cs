using System.Runtime.InteropServices;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetail()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from product in context.Products
                             join category in context.Categories
                                 on product.CategoryId equals category.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = product.ProductId,
                                 CategoryName = category.CategoryName,
                                 ProductName = product.ProductName,
                                 UnitsInStock = product.UnitsInStock
                             };

                return result.ToList();
            }
        }
    }
}
