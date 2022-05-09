namespace Core
{
    public class Booking : IBooking
    {
       public Guid Id { get; set; }
       public DateTime BookingTime { get; set; }
       public DateTime StartDate { get; set; }
       public DateTime EndDate { get; set; }
       public decimal Cost { get; set; }
       public string Title { get; set; }
       public IBookingEntity BookingEntity { get; set; } = default!;
       public decimal CalculateEstimateCost()
       {
           return Cost;
       }
    }
}
