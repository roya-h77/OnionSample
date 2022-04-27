using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnionSample.Infra.Data.Commands.EF.EfConfings
{
    public class AllConfigs
    {
        public class CourseConfig : IEntityTypeConfiguration<Core.Domain.Course>
        {
            public void Configure(EntityTypeBuilder<Core.Domain.Course> builder)
            {
                builder.Property(c => c.ImageUrl).IsRequired().HasMaxLength(1000);
                builder.Property(c => c.Title).IsRequired().HasMaxLength(100);
                builder.Property(c => c.Description).IsRequired();
                builder.Property(c => c.ShortDescription).IsRequired().HasMaxLength(500);
            }
        }

        public class TeacherConfig : IEntityTypeConfiguration<Core.Domain.Teacher>
        {
            public void Configure(EntityTypeBuilder<Core.Domain.Teacher> builder)
            {
                builder.Property(p => p.FirstName).HasMaxLength(100);
                builder.Property(p => p.LastName).HasMaxLength(100);
            }
        }

    }
}
