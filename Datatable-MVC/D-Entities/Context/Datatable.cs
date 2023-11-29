using Microsoft.EntityFrameworkCore;

namespace Datatable_MVC.D_Entities.Context
{
    public class Datatable : DbContext
    {
        public Datatable(DbContextOptions<Datatable> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
