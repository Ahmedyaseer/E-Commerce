using E_Commerce.DAL;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.BLL;

public class ProductRepo : IProductRepo
{
    private readonly StoreContext context;

    public ProductRepo(StoreContext context)
    {
        this.context = context;
    }
    public List<Products> GetAllProducts()
    {
        List<Products> products = context.Set<Products>().ToList(); 
        return products;
    }

    public Products? GetProductById(int id)
    {
        Products? product = context.Set<Products>().Find(id);
        return product;
    }
}

