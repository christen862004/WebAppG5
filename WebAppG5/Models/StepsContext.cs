using Microsoft.EntityFrameworkCore;

namespace WebAppG5.Models
{
    //
    public class StepsContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        //DBMS - server name ,auth ,database (DbContextOptions)
        public StepsContext():base()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=WebAppG5;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
