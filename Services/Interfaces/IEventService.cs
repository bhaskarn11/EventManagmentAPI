using EventManagment.Dtos;

namespace EventManagment.Services.Interfaces
{
    public interface IEventService
    {
        public Task<Event> CreateEvent(EventDto createEvent);

        public Task<Event>? GetEvent(int eventId);

        public Task<List<Event>> GetAllEventByRegion(Regions region);
        public Task<List<Event>> GetAllEventByVenue(int venueId);
        public Task<List<Event>> EventSearch(string eventName);
        public Task<int> DeleteEvent(int eventId);
        public Task<Event> UpdateEvent(int eventId, EventDto eventDto);
    }
}
