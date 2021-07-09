using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks; 
using System.ComponentModel.DataAnnotations;

// public class columnsContext : DbContext
// {
//     public columnsContext(DbContextOptions<columnsContext> options) : base(options)
//     {
//     }

//     public DbSet<columnsItem> columns { get; set; }
// }

public class columnsItem
{
    [Key]
    public long id { get; set; }
     public string ColumnType { get; set; }
    public int NbOfFloorsServed { get; set; }
    public string Status { get; set;}
    public string Info { get; set; }
    public string Notes { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public long battery_id { get; set; }
}
 
//dotnet aspnet-codegenerator controller -name columnsController -async -api -m columnsItem -dc columnsContext -outDir Controllers
