using AuditIssue.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuditIssue.Context.Configuration
{
    internal sealed class ReservationRequestMapping : IEntityTypeConfiguration<ReservationRequest>
    {
        public void Configure(EntityTypeBuilder<ReservationRequest> builder)
        {
            builder.ToTable("ReservationRequests");
        }
    }
}
