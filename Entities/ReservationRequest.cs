using AuditIssue.Models;
using System;

namespace AuditIssue.Entities
{
    public class ReservationRequest : Request
    {
        public string ReservationComments { get; set; }
        public DateTime ReservationTo { get; set; }

        private ReservationRequest()
        {
        }

        internal ReservationRequest(AddReservationRequest reservationRequest)
            : base(reservationRequest.UserId)
        {
            ReservationComments = reservationRequest.ReservationComments;
            ReservationTo = reservationRequest.ReservationTo;
        }
    }
}
