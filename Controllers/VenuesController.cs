using EventManagment.Dtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenuesController : ControllerBase
    {
        private readonly VenueService venueService;

        public VenuesController(VenueService venueService)
        {
            this.venueService = venueService;
        }

        
        [HttpGet("{id}")]
        public async Task<ServiceResponse<Venue?>> GetVenueDetails(int id)
        {
            Venue? venue = await venueService.GetVenueDetails(id);
            if (venue == null)
                return new ServiceResponse<Venue?>(null, false);
            return new ServiceResponse<Venue?>(venue, true);
        }

       
        [HttpPost]
        public async Task<ServiceResponse<Venue?>> PostVenue(int id, CreateVenue createVenue)
        {
            Venue? venue = await venueService.CreateVenue(id, createVenue);
            return new ServiceResponse<Venue?>(venue, true);
        }

      
        [HttpPut("{id}")]
        public async Task<ServiceResponse<Venue?>> Put(int id, UpdateVenue updateVenue)
        {
            Venue? venue = await venueService.UpdateVenueDetails(id, updateVenue);
            if (venue == null)
                return new ServiceResponse<Venue?>(null, false);
            return new ServiceResponse<Venue?>(venue, true);
        }

    
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            return await venueService.DeleteVenue(id);
        }
    }
}
