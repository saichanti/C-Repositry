using EntityFramework.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace EntityFramework.Data
{
    public class DemoDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }
       

        public DemoDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-70LPGGG\MSSQLSERVER01;Database=Study;Trusted_Connection=True;");

        }
    }
}
