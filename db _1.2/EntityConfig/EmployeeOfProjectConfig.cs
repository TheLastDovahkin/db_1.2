using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using db__1._2.Entitites;

namespace db__1._2.EntityConfig
{
    public class EmployeeProjectConfig : IEntityTypeConfiguration<EmployeeOfProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeOfProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(p => p.EmployeeOfProjectId);
            builder.Property(p => p.EmployeeOfProjectId).HasColumnName("EmployeeProjectId").IsRequired();
            builder.Property(p => p.Rate).HasColumnName("Rate").HasColumnType("money").IsRequired();
            builder.Property(p => p.DayOfStart).HasColumnName("StartedDate").HasColumnType("datetime2").IsRequired();

            builder.HasOne(d => d.Employee)
                .WithMany(p => p.EmployeeProjects)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(d => d.Project)
                .WithMany(p => p.EmployeeOfProjects)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
