using Microsoft.EntityFrameworkCore;

namespace EventManagment.Models
{
    public class Movie 
    {
        public int Id {get; set;}
        public string? Title {get; set;}
        public string? Desciption {get; set;}
    }
}