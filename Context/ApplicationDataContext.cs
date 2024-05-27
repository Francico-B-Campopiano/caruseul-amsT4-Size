using AMST4.Carousel.Models;
using Microsoft.EntityFrameworkCore;

namespace AMST4.Carousel.Context;

    public class ApplicationDataContext : DbContext
{

    public ApplicationDataContext(DbContextOptions<ApplicationDataContext> opts) :base(opts)
    {
        
    }
   public DbSet<Category> Category { get; set; }
 
    public DbSet<AMST4.Carousel.Models.Product> Product { get; set; } = default!;

public DbSet<AMST4.Carousel.Models.Size> Size { get; set; } = default!;


}

