using Microsoft.EntityFrameworkCore;

namespace EventManagment.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Event> Events { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Seat> Seats { get; set; }
        
    }
}