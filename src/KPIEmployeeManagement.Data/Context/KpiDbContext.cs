using Microsoft.EntityFrameworkCore;
using KPIEmployeeManagement.Core.Models;

namespace KPIEmployeeManagement.Data.Context
{
    public class KpiDbContext : DbContext
    {
        public KpiDbContext(DbContextOptions<KpiDbContext> options) : base(options)
        {
        }

        public DbSet<KpiEmployee> KpiEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<KpiEmployee>().HasKey(e => e.Seq);
        }
    }
}
