using Microsoft.EntityFrameworkCore;


namespace E_Commerce.DAL;

public  class StoreContext : DbContext
{
    private readonly DbContextOptions options;

    public StoreContext(DbContextOptions options):base(options)
    {
        this.options = options;
    }

    public DbSet<Products> products { get; set; }

  
        
    
}
