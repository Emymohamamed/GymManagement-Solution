using GymManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace GymManagement.DbContexts
{
    public class GymDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Server =.;Database=GymManagement;Trusted_Connection=True;TrustServerCertificate=True");
}       public DbSet<Plan> Plans { get; set; }
    }

}


    

