using EmployeeMAnagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeMAnagementSystem.Context
{
    public class employeeContext : DbContext
    {  
        public DbSet<employeeModel> employees { get; set; }
       
    }
}