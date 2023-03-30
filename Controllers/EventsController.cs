using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EventManagment.Dtos;
using Microsoft.IdentityModel.Tokens;

namespace EventManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EventService eventService;

        public EventsController(EventService eventService)
        {
            this.eventService = eventService;
        }



        [HttpGet("GetEventDetails")]
        public async Task<ServiceResponse<Event>?> GetEventDetails(int eventId)
        {
            Event? evnt = await eventService.GetEvent(eventId);
            return new ServiceResponse<Event>(evnt, true);
        }




        [HttpPost]
        public async Task<ServiceResponse<Event>> CreateEvent(EventDto eventDto)
        {
            Event? evnt = await eventService.CreateEvent(eventDto);
            return new ServiceResponse<Event>(evnt, true);
        }



        [HttpPut("UpdateEvent")]
        public async Task<ServiceResponse<Event>> UpdateEvent(int eventId, EventDto eventDto)
        {
            Event? evnt = await eventService.UpdateEvent(eventId, eventDto);
            return new ServiceResponse<Event>(evnt, true);
        }



        [HttpDelete("DeleteEvent")]
        public async Task<ServiceResponse<int>> CreateEvent(int eventId)
        {
            int r = await eventService.DeleteEvent(eventId);
            return new ServiceResponse<int>(r, true);
        }



        [HttpGet("GetAllEventsByVenue")]
        public async Task<ActionResult<List<Event>>> GetAllEventByVenue(int venueId)
        {
            List<Event>? events = await eventService.GetAllEventByVenue(venueId);
            if (events.IsNullOrEmpty())
                return NotFound();
            return Ok(new ServiceResponse<List<Event>>(events, true));

        }


        [HttpGet("SearchEvenstByName")]
        public async Task<ActionResult<List<Event>>> GetAllEventsByName(string name)
        {
            List<Event>? events = await eventService.EventSearch(name);
            if (events.IsNullOrEmpty())
                return NotFound();
            return Ok(new ServiceResponse<List<Event>>(events, true));

        }


        [HttpGet("GetEventsByRegion")]
        public async Task<ActionResult<List<Event>>> GetEventsByRegion(Regions region)
        {
            List<Event>? events = await eventService.GetAllEventByRegion(region);
            if (events.IsNullOrEmpty())
                return NotFound();
            return Ok(new ServiceResponse<List<Event>>(events, true));

        }

    }
}
