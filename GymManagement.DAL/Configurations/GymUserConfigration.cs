using GymManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Configurations
{
    public class GymUserConfigration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        private object address;

        public int U { get; private set; }

        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(U => U.Name)
                .HasColumnType(typeName: "varchar")
                .HasMaxLength(maxLength: 50);
            builder.Property(U => U.Email)
                .HasColumnType(typeName: "varchar")
                .HasMaxLength(maxLength: 100);
            builder.Property(U => U.Phone)
                .HasColumnType(typeName: "varchar")
                .HasMaxLength(maxLength: 11);

            builder.HasIndex(U => U.Phone).IsUnique();
            builder.HasIndex(U => U.Email).IsUnique();
            builder.OwnsOne(U => U.Address , address =>
            {
                address.Property(A => A.Street)
                                 .HasColumnName("Street")

                                 .HasColumnType("varchar(30)");

                address.Property(A => A.City)
                       .HasColumnName("City")
                       .HasColumnType("varchar(30)");

                address.Property(A => A.BuildingNumber)
                       .HasColumnName("BuildingNumber");
            });
            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint(name: "EmailCheck", sql: "Email like '_%@_%._%'");

                tb.HasCheckConstraint(name: "PhoneCheck", sql: "Phone like '010% ' or Phone like '011% ' or Phone like '012% 'Phone like '015% ' ");

            });
        }
    }
}




