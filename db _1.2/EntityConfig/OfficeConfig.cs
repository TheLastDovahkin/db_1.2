using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using db__1._2.Entitites;

namespace db__1._2.EntityConfig
{
    public class OfficeConfig : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(p => p.OfficeId);
            builder.Property(p => p.OfficeId).HasColumnName("OfficeId").IsRequired();
            builder.Property(p => p.Title).HasColumnName("Title").HasMaxLength(100).IsRequired();
            builder.Property(p => p.Location).HasColumnName("Location").HasMaxLength(100).IsRequired();
        }
    }
}
