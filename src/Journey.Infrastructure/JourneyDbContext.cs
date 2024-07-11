using Journey.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Journey.Infrastructure;

public class JourneyDbContext : DbContext
{
    public DbSet<Trip> Trips { get; set; }
    public DbSet<Activity> Activities { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\Bruno\\Documents\\nlw-journey-c-sharp-ab1c077696dcd4a6f767c4ac8e5e3487bf0ce304\\src\\Journey.Infrastructure\\JourneyDatabase.db");
    }
}