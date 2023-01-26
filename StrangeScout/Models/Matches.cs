using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StrangeScout.Models
{
    public class Matches
    {
        [Key]
        public int ID {get; set;}
        public string Event{get; set;}
        public int TeamNumber{get; set;}
        public string TeamName{get; set;}    
        public int Points {get; set;}
        public int Penalties{get; set;}
    }
}