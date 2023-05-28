using Microsoft.EntityFrameworkCore;

namespace BIGBANG_Assesment.Models
{
    public class HotelContext: DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Reservation> Reservations { get; set; }

    public HotelContext(DbContextOptions<HotelContext> options) : base(options)
    {

    }
}
}
