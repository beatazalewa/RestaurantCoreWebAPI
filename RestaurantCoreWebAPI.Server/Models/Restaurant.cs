using System.ComponentModel.DataAnnotations;

namespace RestaurantCoreWebAPI.Server.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Display(Name = "Restaurant name:")]
        public string Name { get; set; }
        [Display(Name = "Address:")]
        public string Address { get; set; }
        [Display(Name = "Is open:")]
        public bool IsOpen { get; set; }
        [Display(Name = "Speciality:")]
        public string Speciality { get; set; }
        [Range(0, 5)]
        [Display(Name = "Review:")]
        public int Review { get; set; }
    }
}


