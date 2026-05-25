using GymManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace GymManagement.DbContexts
{
    public class GymDbContext : DbContext
    {
       public GymDbContext(DbContextOptions <GymDbContext> options) : base(options)
        {
        }

        protected GymDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      //  {
      
//}
public DbSet<Plan> Plans { get; set; }
    }

}


    

