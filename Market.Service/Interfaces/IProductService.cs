using Market.Service.DTOs;

namespace Market.Service.Interfaces
{
    public interface IProductService
    {
        ValueTask<ProductDto> AddAsync(ProductCreationDto dto);
        ValueTask<ProductDto> UpdateAsync(long id, ProductCreationDto dto);
        ValueTask<bool> DeleteAsync(long id);
        ValueTask<ProductDto> GetAsync(long id);
        ValueTask<List<ProductDto>> GetAllAsync();
    }
}
