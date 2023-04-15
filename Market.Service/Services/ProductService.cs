using Market.Service.DTOs;
using Market.Service.Interfaces;

namespace Market.Service.Services
{
    public class ProductService : IProductService
    {
        public ValueTask<ProductDto> AddAsync(ProductCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<ProductDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<ProductDto> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<ProductDto> UpdateAsync(long id, ProductCreationDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
