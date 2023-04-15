using Market.Service.DTOs;

namespace Market.Service.Interfaces
{
    public interface IProductService
    {
        ValueTask<ProductDto> AddServiceAsync(ProductCreationDto dto);
        ValueTask<ProductDto> UpdateServiceAsync(long id, ProductCreationDto dto);
        ValueTask<bool> DeleteServiceAsync(long id);
        ValueTask<ProductDto> GetServiceAsync(long id);
        ValueTask<IEnumerable<ProductDto>> GetAllServiceAsync();
    }
}
