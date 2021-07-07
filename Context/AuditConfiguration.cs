using AuditIssue.Entities;

namespace AuditIssue.Context
{
    public class AuditConfiguration
    {
        public static void Configure()
        {
            ConfigureEntityFramework();
        }

        private static void ConfigureEntityFramework()
        {
            Audit.EntityFramework.Configuration.Setup()
                .ForContext<DatabaseContext>(x =>
                    x.IncludeEntityObjects(true)
                    .AuditEventType("{context}:{database}"))
                .UseOptIn()
                    .Include(typeof(Request))
                    .Include(typeof(ReservationRequest));
        }
    }
}
