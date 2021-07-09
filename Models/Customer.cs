using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks; 
using System.ComponentModel.DataAnnotations;


public class CustomerItem
{
    public long Id { get; set; }
    public string EmailOfTheCompany { get; set; }
    public string TechManagerServiceEmail { get; set; }
}

//dotnet aspnet-codegenerator controller -name CustomerController -async -api -m CustomerItem -dc CustomerContext -outDir Controllers