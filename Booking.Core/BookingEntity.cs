namespace Core
{
    public class BookingEntity : IBookingEntity
    {
       public Guid Id { get; set; }
       public string Name { get; set; } = default!;
    }
}
