namespace EventManagment.Services.Interfaces
{
    public interface IEventService
    {
        public Event CreateEvent();

        public Event? GetEvent();

        public List<Event> GetAllEventByRegion();
        public List<Event> GetAllEventByVenue();
        public List<Event> EventSearch();
        public Event DeleteEvent();
        public Event UpdateEvent();
    }
}
