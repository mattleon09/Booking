namespace Core
{
    public interface IBooking
    {
        Guid Id { get; set; }
        DateTime BookingTime { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        decimal Cost { get; set; }
        string Title { get; set; }
        IBookingEntity BookingEntity { get; set;}
        decimal CalculateEstimateCost();
      
    }
}
