using Microsoft.EntityFrameworkCore;

namespace EventManagment.Models
{
    class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Event> Events { get; set; }
        public DbSet<Venue> Venue { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        
    }
}