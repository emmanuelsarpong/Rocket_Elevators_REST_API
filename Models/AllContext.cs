using Microsoft.EntityFrameworkCore;

public class AllContext : DbContext
{
    public AllContext(DbContextOptions<AllContext> options) : base(options)
    {
    }


    public DbSet<batteriesItem> batteries { get; set; }
    public DbSet<BuildingItem> buildings { get; set; }
    public DbSet<columnsItem> columns { get; set; }
    public DbSet<ElevatorItem> elevators { get; set; }
    public DbSet<leadItem> leads { get; set; }
    public DbSet<CustomerItem> customers { get; set; }

}