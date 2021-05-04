using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using db__1._2.Entitites;

namespace db__1._2.EntityConfig
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client>builder)
        {
            builder.ToTable("Client").HasKey(p => p.ClientId);
            builder.Property(p => p.ClientId).HasColumnName("ClientId").IsRequired();
            builder.Property(p => p.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
            builder.Property(p => p.LastName).HasColumnName("LastName").HasMaxLength(50).IsRequired();
            builder.Property(p => p.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();
            builder.Property(p => p.Company).HasColumnName("Company").IsRequired();

            builder.HasMany(c => c.Projects)
                .WithOne(s => s.Client)
                .HasForeignKey(c => c.ClientId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
