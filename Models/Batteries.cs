using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks; 

public class batteriesContext : DbContext
{
    public batteriesContext(DbContextOptions<batteriesContext> options) : base(options)
    {
    }

    public DbSet<batteriesItem> batteries { get; set; }
}

public class batteriesItem
{
    public long id { get; set; }

    // [Column(TypeName = "varchar(255)")]
    public string BType { get; set; }
    public DateTime DateOfCommissioning { get; set; }
    public DateTime DateOfLastInspection { get; set;}
    public string Info { get; set; }
    public string Notes { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public long building_id { get; set; }
    public long employee_id { get; set;}
}
 
//dotnet aspnet-codegenerator controller -name batteriesController -async -api -m batteriesItem -dc batteriesContext -outDir Controllers
