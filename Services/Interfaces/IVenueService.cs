namespace EventManagment.Services.Interfaces
{
    public interface IVenueService
    {
        public List<Venue> GetAllVenueByRegion();

        public Venue? GetVenueDetails();

        public Venue? UpdateVenueDetails();

        public void DeleteVenue();
    }
}
