using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;

namespace Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }      

        public async Task<Product> CreateProductAsync(Product product)
        {
           _unitOfWork.Repository<Product>().Add(product);
           await _unitOfWork.Complete();

           return product;
        }

        public async Task<Product> GetProductByIDAsync(int Id)
        {
            var spec = new ProductWithUnitSpecification(Id);
            return await _unitOfWork.Repository<Product>().GetEntityWithSpec(spec);            
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _unitOfWork.Repository<Product>().ListAllAsync();
        }

        public async Task<IReadOnlyList<Unit>> GetUnitsAsync()
        {
            return await _unitOfWork.Repository<Unit>().ListAllAsync();
        }


        public async Task<Product> UpdateProductAsync(Product product)
        {
             _unitOfWork.Repository<Product>().Update(product);
            await _unitOfWork.Complete();

            return product;
        }
    }
}