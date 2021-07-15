using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks; 
using System.ComponentModel.DataAnnotations;

public class interventionsItem
{
    [Key]
    public long id { get; set; }
    public long Author { get; set; }
    public long CustomerID { get; set; }
    public long BuildingID { get; set; }
    public long BatteryID { get; set;}
    public long ColumnID { get; set; }
    public long ElevatorID { get; set; }
    public DateTime Start_Date { get; set; }
    public DateTime End_Date { get; set; }
    public string Result { get; set; }
    public string Report { get; set;}
    public string Status { get; set;}
}