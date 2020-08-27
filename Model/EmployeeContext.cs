using System.Data.Entity;

namespace SQLiteWPF.Model
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
