using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductService
    {
         Task<Product> CreateProductAsync(Product product);
         Task<Product> UpdateProductAsync(Product product);
         Task<Product> GetProductByIDAsync(int Id);
         Task<IReadOnlyList<Product>> GetProductsAsync();
         Task<IReadOnlyList<Unit>> GetUnitsAsync();
    }
}