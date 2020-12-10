using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EMS.Models
{
    public class EmployeeDbContext: DbContext
    {
        public EmployeeDbContext() : base("name=EMSDBConnectionString")
        {

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}