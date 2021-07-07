using Audit.EntityFramework;
using AuditIssue.Context.Configuration;
using AuditIssue.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuditIssue.Context
{
    public class DatabaseContext : AuditDbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ReservationRequest> ReservationRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RequestMapping());
            modelBuilder.ApplyConfiguration(new ReservationRequestMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
