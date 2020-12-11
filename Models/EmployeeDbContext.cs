using System.Data.Entity;

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