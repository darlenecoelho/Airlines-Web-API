using FormulaAirline.API.Models;
using FormulaAirline.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace FormulaAirline.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingsController : ControllerBase
{
    private readonly ILogger<BookingsController> _logger;
    private readonly IMessageProducer _messageProducer;

    // In-Memory db
    public static readonly List<Booking> _bookings = new();

    public BookingsController(ILogger<BookingsController> logger,
        IMessageProducer messageProducer) 
    {
        _logger = logger;
        _messageProducer = messageProducer;
    }

    [HttpPost]
    public IActionResult CreatingBooking(Booking newbooking)
    {
        if(!ModelState.IsValid) return BadRequest();
        _bookings.Add(newbooking);
        _messageProducer.SendingMessage<Booking>(newbooking);
        return Ok();
    }
     
}
