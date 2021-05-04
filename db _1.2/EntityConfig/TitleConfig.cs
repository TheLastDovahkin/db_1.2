using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using db__1._2.Entitites;

namespace db__1._2.EntityConfig
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(p => p.TitleId);
            builder.Property(p => p.TitleId).HasColumnName("TitleId").IsRequired();
            builder.Property(p => p.NameOfTitle).HasColumnName("Name").HasMaxLength(50).IsRequired();

            builder.HasMany(c => c.Employees)
                .WithOne(w => w.Title)
                .HasForeignKey(f => f.TitleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
