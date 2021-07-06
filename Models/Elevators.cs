using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks; 

public class ElevatorContext : DbContext
{
    public ElevatorContext(DbContextOptions<ElevatorContext> options) : base(options)
    {
    }

    public DbSet<ElevatorItem> elevators { get; set; }
}

public class ElevatorItem
{
    public long id { get; set; }
    public string SerialNumber { get; set; }
    public string Model { get; set; }
    public string ElevatorType { get; set; }
    public string Status { get; set; }
    public DateTime DateOfCommissioning { get; set; }
    public DateTime DateOfLastInspection { get; set; }
    public string CertificateOfInspection { get; set; }
    public string Info { get; set; }
    public string Notes { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public int column_id { get; set; }
}

//dotnet aspnet-codegenerator controller -name ElevatorController -async -api -m ElevatorItem -dc ElevatorContext -outDir Controllers