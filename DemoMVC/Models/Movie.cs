
using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
{
    public class Movie
    {
        [Display(Name = "Movie Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name="Year of Release")]
        public int Year { get; set; }
        [Display(Name="People Rating")]
        public int Rating { get; set; }
    }
}
