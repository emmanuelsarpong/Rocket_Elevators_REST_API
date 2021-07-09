using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks; 
using System.ComponentModel.DataAnnotations;

// public class BuildingContext : DbContext
// {
//     public BuildingContext(DbContextOptions<BuildingContext> options) : base(options)
//     {
//     }

//     public DbSet<BuildingItem> building { get; set; }
// }

public class BuildingItem
{
    [Key]
    public long id { get; set; }
    public string FullNameOfTheBuildingAdministrator { get; set; }
    public string EmailOfTheAdministratorOfTheBuilding { get; set; }
    public string PhoneNumberOfTheBuildingAdministrator { get; set; }
    public string FullNameOfTheTechContactForTheBuilding { get; set;}
    public string TechContactEmail { get; set; }
    public string TechContactPhone { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public long customer_id { get; set; }
    public long address_id { get; set;}
}
 
//dotnet aspnet-codegenerator controller -name batteriesController -async -api -m batteriesItem -dc batteriesContext -outDir Controllers