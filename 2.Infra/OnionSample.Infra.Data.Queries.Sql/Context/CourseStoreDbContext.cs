using Microsoft.EntityFrameworkCore;
using OnionSample.Core.Domain;
using OnionSample.Infra.Data.Commands.EF.EfConfings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionSample.Infra.Data.Queries.Sql.Context
{
    public class CourseStoreDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseComment> CourseComments { get; set; }
        public DbSet<CourseTeacher> CourseTeachers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public CourseStoreDbContext(DbContextOptions<CourseStoreDbContext> options) : base(options)
        {
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AllConfigs).Assembly);
        }
    }
}
