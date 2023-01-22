using System.ComponentModel.DataAnnotations;

namespace StrangeScout.Models
{
    public class TeamsModel
    {
        [Required(ErrorMessage ="team# required")]
        public int TeamNumber { get; set; }
        [Required(ErrorMessage = "team name required")]
        public string TeamName { get; set; }
        [Required(ErrorMessage = "location required")]
        public string Location { get; set; }
        public string District { get; set; }
        [Required(ErrorMessage = "Rookie year required")]
        public int RookieYear { get; set; }
    }
}
