using Microsoft.EntityFrameworkCore;
using NonGenericRepositoryPattern.Models;

namespace NonGenericRepositoryPattern.Data
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {
        }
        // public EmployeeDBContext([NotNullAttribute] DbContextOptions options) : base(options)
        // {
        // }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}