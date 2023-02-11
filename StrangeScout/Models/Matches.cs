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

        public int Cones_A {get; set;}
        public int Cubes_A {get; set;}

        public int Cones {get; set;}
        public int Cubes {get; set;}

        public int Cones_E {get; set;}
        public int Cubes_E {get; set;}

        public int DoubleSubstation_A {get; set;}
        public int SingleSubstation_A {get; set;}
        public int Center_A {get; set;}

        public int DoubleSubstation {get; set;}
        public int SingleSubstation {get; set;}
        public int Center {get; set;}

        public int DoubleSubstation_E {get; set;}
        public int SingleSubstation_E {get; set;}
        public int Center_E {get; set;}

        public int Top_A { get; set;}
        public int Mid_A {get; set;}
        public int Bot_A {get; set;}

        public int Top { get; set;}
        public int Mid {get; set;}
        public int Bot {get; set;}

        public int Top_E { get; set;}
        public int Mid_E {get; set;}
        public int Bot_E {get; set;}

        public float CycleTime {get; set;}

        public string? Engaged_A {get; set;}

        public string? Engaged {get; set;}

        public string? Mobility {get; set;}

        public string? Parked {get; set;}
        
        public int Points {get; set;}
    }

    
}