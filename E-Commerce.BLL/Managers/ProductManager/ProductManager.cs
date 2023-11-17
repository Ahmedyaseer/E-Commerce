

using E_Commerce.DAL;

namespace E_Commerce.BLL;

public class ProductManager : IProductManager   
{
    private readonly IProductRepo productRepo;

    public ProductManager(IProductRepo productRepo)
    {
        this.productRepo = productRepo;
    }

    public List<ProductDto> GetAllProductsDto()
    {
        List<Products> products = productRepo.GetAllProducts();

        return products.Select(p => new ProductDto
        {
            Name=p.Name,

        }).ToList();    
    }

    public ProductDto GetProductByIdDto(int id)
    {
        Products product = productRepo.GetProductById(id);

        ProductDto productDto = new ProductDto();

        productDto.Name = product.Name;

        return productDto;
    }
}
