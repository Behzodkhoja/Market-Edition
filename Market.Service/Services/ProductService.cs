using Market.Data.IRepositories;
using Market.Data.Repositories;
using Market.Domain.Entities;
using Market.Service.DTOs;
using Market.Service.Interfaces;

namespace Market.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository = new ProductRepository();
        public async ValueTask<ProductDto> AddServiceAsync(ProductCreationDto dto)
        {
            var product = new Product()
            {
                Count = dto.Count,
                FullName = dto.FullName,
                Price = dto.Price,
                CreatedAt = DateTime.UtcNow
            };
            await productRepository.InsertAsync(product);

            return new ProductDto
            {
                Price = product.Price,
                Count = product.Count,
                FullName = product.FullName,
                Id = product.Id
            };
        }

        public async ValueTask<bool> DeleteServiceAsync(long id)
        {
            var product = await productRepository.GetAsync(id);
            if (product == null)
                return false;

            await productRepository.DeleteAsync(product);
            return true;
        }

        public async ValueTask<IEnumerable<ProductDto>> GetAllServiceAsync()
        {
            var users = await productRepository.GetAllAsync();

            return users.Select(product => new ProductDto 
            { 
                Price = product.Price, 
                Count = product.Count ,
                FullName = product.FullName,
                Id  = product.Id
            });
        }

        public async ValueTask<ProductDto> GetServiceAsync(long id)
        {
            var product = await productRepository.GetAsync(id);

            return new ProductDto()
            {
                FullName = product.FullName,
                Id = product.Id,
                Count = product.Count,
                Price = product.Price
            };
        }

        public async ValueTask<ProductDto> UpdateServiceAsync(long id, ProductCreationDto dto)
        {
            var product = await productRepository.GetAsync(id);

            if (product is null)
                throw new Exception("Product not found...");
            product.Price = dto.Price;
            product.Count = dto.Count;
            product.FullName = dto.FullName;
            product.UpdatedAt = DateTime.UtcNow;

            await productRepository.UpdateAsync(product);

            return new ProductDto()
            {
                FullName = product.FullName,
                Id = product.Id,
                Count = product.Count,
                Price = product.Price
            };
        }
    }
}
