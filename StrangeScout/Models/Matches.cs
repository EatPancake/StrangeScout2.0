using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StrangeScout.Models
{
    public class Matches
    {
        [Key]
        public int ID {get; set;}
        [Required]
        public string? Event {get; set;}
        [Required]
        public int Round {get; set;}
        [Required]
        public int TeamNumber {get; set;}

        public int Cones {get; set;}
        public int Cubes {get; set;}

        public int DoubleSubstation {get; set;}
        public int SingleSubstation {get; set;}
        public int Center {get; set;}

        public int Top { get; set;}
        public int Mid {get; set;}
        public int Bot {get; set;}

        public float CycleTime {get; set;}

        public bool Engaged {get; set;}
        
        public int Points {get; set;}
    }

    
}