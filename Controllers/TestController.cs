using AuditIssue.Context;
using AuditIssue.Entities;
using AuditIssue.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AuditIssue.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly DatabaseContext databaseContext;

        public TestController(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddReservationRequest addReservationRequest)
        {
            var reservationRequest = new ReservationRequest(addReservationRequest);

            databaseContext.ReservationRequests.Add(reservationRequest);
            await databaseContext.SaveChangesAsync();

            return Ok();
        }
    }
}
