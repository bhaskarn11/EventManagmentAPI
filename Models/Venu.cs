using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace EventManagment.Models
{
    class Venue
    {
        public int Id {get; set;}

        public string? Name {get; set;}

        public Regions VenueRegion {get; set;}

        public decimal? Lat {get; set;}
        public decimal? Lng {get; set;}

        [Required]
        public string? Address {get; set;}
    }
}