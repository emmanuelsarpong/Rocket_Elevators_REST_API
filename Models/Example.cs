using Microsoft.EntityFrameworkCore;

public class ExampleContext : DbContext
{
    public ExampleContext(DbContextOptions<ExampleContext> options) : base(options)
    {
    }

    public DbSet<ExampleItem> ExampleItems { get; set; }
}

public class ExampleItem
{
    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }
}

//dotnet aspnet-codegenerator controller -name ExampleItemsController -async -api -m ExampleItem -dc ExampleContext -outDir Controllers