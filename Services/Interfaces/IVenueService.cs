using EventManagment.Dtos;

namespace EventManagment.Services.Interfaces
{
    public interface IVenueService
    {
        public Task<List<Venue>> GetAllVenueByRegion(Regions region);

        public Task<Venue?> GetVenueDetails(int venuId);

        public Task<Venue?> UpdateVenueDetails(int venueId, UpdateVenue updateVenue);

        public Task<int> DeleteVenue(int venueId);

        public Task<Venue> CreateVenue(CreateVenue createVenue);
    }
}
