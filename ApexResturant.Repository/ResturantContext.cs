using Microsoft.EntityFrameworkCore;
using ApexResturant.Repository.Domain;
namespace ApexResturant.Repository
{
    public class ResturantContext : DbContext
    {
        public ResturantContext(DbContextOptions<ResturantContext> options) : base(options) 
        {

        }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Staff> Staffs{ get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    { 
        base.OnModelCreating(modelBuilder); 
    }

    }
}