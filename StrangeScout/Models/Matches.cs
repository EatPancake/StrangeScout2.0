using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StrangeScout.Models
{
    public class Matches
    {
        [Key]
        public int ID {get; set;}
        public string? Event {get; set;}
        public int Round {get; set;}
        public int TeamNumber {get; set;}

        public int Top { get; set;}
        public int Mid {get; set;}
        public int Bot {get; set;}

        public float CycleTime {get; set;}

        public bool Engaged {get; set;}
        
        public int Points {get; set;}
        public int Penalties {get; set;}
    }

    
}