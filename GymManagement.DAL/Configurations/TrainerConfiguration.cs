using GymManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Configurations
{
    public class TrainerConfiguration : GymUserConfigration<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new void configur(EntityTypeBuilder<Trainer> Builder)
        {
            Builder.Property(M => M.CreatedAt)
                 .HasColumnName(name: "HaireDate")
                 .HasDefaultValueSql(sql: "GETDATE()");
            base.Configure(Builder);

        }
    }
}
