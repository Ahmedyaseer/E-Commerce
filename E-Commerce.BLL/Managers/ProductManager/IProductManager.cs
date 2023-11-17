

namespace E_Commerce.BLL;

public interface IProductManager
{
    public List<ProductDto> GetAllProductsDto();

    public ProductDto GetProductByIdDto(int id);

}
