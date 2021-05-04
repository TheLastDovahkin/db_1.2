using Microsoft.EntityFrameworkCore;
using db__1._2.Entitites;
using db__1._2.EntityConfig;

namespace db__1._2
{
    public class ApplicationsContext : DbContext
    {
        public ApplicationsContext(DbContextOptions<ApplicationsContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeOfProject> EmployeeProjects { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfig());
            modelBuilder.ApplyConfiguration(new OfficeConfig());
            modelBuilder.ApplyConfiguration(new ProjectConfig());
            modelBuilder.ApplyConfiguration(new TitleConfig());
            modelBuilder.ApplyConfiguration(new ClientConfig());
        }
    }
}
