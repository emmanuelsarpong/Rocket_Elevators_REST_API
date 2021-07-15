using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks; 
using System.ComponentModel.DataAnnotations;
using System.Web;

public class leadItem
{
    public long Id { get; set; }
    public string Email { get; set; }
    public DateTime created_at { get; set; }
}

//dotnet aspnet-codegenerator controller -name leadController -async -api -m leadItem -dc leadContext -outDir Controllers