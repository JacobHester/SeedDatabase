using SeedDatabase.models;
using Microsoft.EntityFrameworkCore;
namespace SeedDatabase.SeedDatabase{

public class SeedContext : DbContext
{
    public SeedContext(DbContextOptions<SeedContext> options) : base(options)
    {
    }
    public DbSet<seed> Seeds {get; set;}
}
}
