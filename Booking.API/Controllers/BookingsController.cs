using Application.Bookings;
using Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Booking>>> GetBookings()
        {
            return await Mediator.Send(new List.Query());
        }

        public async Task<IActionResult> DeleteBookings()
        {
            // return await Mediator.Send(new Edit)
            return Ok();
        }

        public async Task<ActionResult<Booking>> GetBooking(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }


    }
}
