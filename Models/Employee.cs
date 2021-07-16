using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


public class EmployeesItem
{
[Key]
    public long id { get; set; }
    public string last_name { get; set; }
    public string first_name { get; set; }
    public string title { get; set; }
    public string email { get; set; }

    public string encrypted_password { get; set;}
}
