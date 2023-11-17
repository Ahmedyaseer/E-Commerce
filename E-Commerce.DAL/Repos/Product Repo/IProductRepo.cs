
namespace E_Commerce.DAL;

public  interface IProductRepo
{
    public List<Products> GetAllProducts();

    public Products GetProductById (int id);    

}

