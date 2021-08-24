using Microsoft.EntityFrameworkCore;
using NonGenericRepositoryPattern.Models;

namespace NonGenericRepositoryPattern.Data
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext()
            : base()
        {
        }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}