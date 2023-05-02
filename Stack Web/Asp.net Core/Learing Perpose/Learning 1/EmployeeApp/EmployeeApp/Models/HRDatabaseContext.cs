using Microsoft.EntityFrameworkCore;
using EmployeeApp.Models;


namespace EmployeeApp.Models
{
    public class HRDatabaseContext : DbContext
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=IFCODEY; initial catalog=EmployeeDB; integrated security=SSPI;TrustServerCertificate=True;");
        }
    }
}
