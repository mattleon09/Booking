using Core;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Booking> Bookings { get; set; } = default!;
        public DbSet<BookingEntity> BookingEntities { get; set; } = default!;
    }
}