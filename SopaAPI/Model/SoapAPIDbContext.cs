using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;

namespace SopaAPI.Model
{
    public class SoapAPIDbContext : DbContext
    {

        public DbSet<Person> Persons { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<PersonDetails> PersonDetails { get; set; }
        public DbSet<Department> Departaments { get; set; }


        public SoapAPIDbContext(DbContextOptions<SoapAPIDbContext> options) : base(options)
        {
        }
    }


}
