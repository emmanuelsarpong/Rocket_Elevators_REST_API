using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks; 
using System.ComponentModel.DataAnnotations;

public class batteriesItem
{
    [Key]
    public long id { get; set; }
    public string BType { get; set; }
    public string Status { get; set; }
    public DateTime DateOfCommissioning { get; set; }
    public DateTime DateOfLastInspection { get; set;}
    public string Info { get; set; }
    public string Notes { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public long building_id { get; set; }
    public long employee_id { get; set;}
}
 
//dotnet aspnet-codegenerator controller -name BuildingController -async -api -m BuildingItem -dc BuildingContext -outDir Controllers
