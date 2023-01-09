 using Microsoft.EntityFrameworkCore;
using EmployeesManagement.Models;
namespace EmployeesManagement.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> contextOptions)
            :base(contextOptions)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
