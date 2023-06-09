﻿using EventManagment.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace EventManagment.Services
{
    public class EventService : IEventService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public EventService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Event> CreateEvent(EventDto createEvent)
        {

            Event evnt = _mapper.Map<EventDto, Event>(createEvent);

            _context.Events.Add(evnt);
            await _context.SaveChangesAsync();
            return evnt;
        }

        public async Task<int> DeleteEvent(int eventId)
        {
            Event? evnt = await _context.Events.Where(p => p.Id == eventId).SingleOrDefaultAsync();
            if (evnt == null)
            {
                throw new Exception("Object Not found");
            }

            _context.Remove(evnt);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Event>> EventSearch(string name)
        {
            List<Event> events = await _context.Events.Where(p => p.Name!.Contains(name)).ToListAsync();
            if (events.IsNullOrEmpty())
                throw new Exception("events not found");

            return events;
        }

        public async Task<List<Event>> GetAllEventByRegion(Regions region)
        {
            List<Event> events = await _context.Events.Where(p => p.EventRegion == region).ToListAsync();

            if (events.IsNullOrEmpty())
                throw new Exception("events not found");
            return events;
        }

        public async Task<List<Event>> GetAllEventByVenue(int venueId)
        {
            List<Event>? events = await _context.Events.Where(p => p.VenueId == venueId).ToListAsync();
            return events;

        }

        public async Task<Event>? GetEvent(int eventId)
        {
            Event? evnt = await _context.Events.Where(p => p.Id == eventId).SingleOrDefaultAsync();
            return evnt == null ? throw new Exception("Event not found") : evnt;
        }

        public async Task<Event> UpdateEvent(int eventId, EventDto eventDto)
        {
            Event? evnt = await _context.Events.Where(p => p.Id == eventId).SingleOrDefaultAsync();
            if (evnt == null)
            {
                throw new Exception("Event not found");
            }

            _context.Events.Update(_mapper.Map<EventDto, Event>(eventDto));
            await _context.SaveChangesAsync();
            return evnt;
        }
    }
}
