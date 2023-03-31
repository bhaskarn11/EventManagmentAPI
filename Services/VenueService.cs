using EventManagment.Dtos;
using EventManagment.Models;
using Microsoft.EntityFrameworkCore;

namespace EventManagment.Services
{
    public class VenueService : IVenueService
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;

        public VenueService(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<int> DeleteVenue(int venuId)
        {
            Venue? venue = await context.Venues.Where(p => p.Id == venuId).FirstOrDefaultAsync();
            if (venue == null)
                throw new Exception("Venue not found");
            context.Remove(venue);
            return await context.SaveChangesAsync();
        }

        public async Task<List<Venue>> GetAllVenueByRegion(Regions region)
        {
            List<Venue>? venues = await context.Venues.Where(p => p.VenueRegion == region).ToListAsync();
            if (venues == null)
                throw new Exception("Venue not found");
            return venues;
        }

        public async Task<Venue?> GetVenueDetails(int venuId)
        {
            Venue? venue = await context.Venues.Where(p => p.Id == venuId).FirstOrDefaultAsync();
            if (venue == null)
                throw new Exception("Venue not found");

            return venue;
        }

        public async Task<Venue?> UpdateVenueDetails(int venueId, UpdateVenue updateVenue)
        {
            Venue? venue = await context.Venues.Where(p => p.Id == venueId).FirstOrDefaultAsync();
            if (venue == null)
                throw new Exception("Venue not found");
            context.Venues.Update(venue);
            await context.SaveChangesAsync();

            return venue;
        }

        public async Task<Venue> CreateVenue(CreateVenue createVenue)
        {
            Venue venue = mapper.Map<CreateVenue, Venue>(createVenue);

            context.Venues.Add(venue);
            await context.SaveChangesAsync();

            return venue;
        }
    }
}
