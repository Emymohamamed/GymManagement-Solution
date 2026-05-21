using GymManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.Configrations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(p => p.Name)
                   .HasColumnType(typeName: "varchar")
                   .HasMaxLength(50);

            builder.Property(p => p.Description)
                   
                   .HasMaxLength(200);
            builder.Property(p => p.Price)
                    .HasPrecision(precision: 10, 2);
            builder.Property(p => p.CreatedAt)
             .HasDefaultValueSql(sql: "GETDATE()");
            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint(name: "planDurationDayCheck", sql: "DurationDays between 1 and 365");
            }
            );
                  
        }
    }
}