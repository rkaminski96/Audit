using System;

namespace AuditIssue.Models
{
    public class AddReservationRequest
    {
        public string ReservationComments { get; set; }
        public DateTime ReservationTo { get; set; }
        public string UserId { get; set; }
    }
}
