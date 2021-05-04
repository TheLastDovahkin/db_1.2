using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using db__1._2.Entitites;

namespace db__1._2.EntityConfig
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(a => a.ProjectId);
            builder.Property(a => a.NameOfProject).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(a => a.Budget).HasColumnName("Budget").HasColumnType("money").IsRequired();
            builder.Property(a => a.InitialDate).HasColumnName("StartedDate").HasColumnType("datetime2").IsRequired();
        }
    }
}
