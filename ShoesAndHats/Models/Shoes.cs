using System.ComponentModel.DataAnnotations;

namespace ShoesAndHats.Models
{
    public class Shoes
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="מותג")]
        public string Brands { get; set; }

        public string Color { get; set; }

        public string UrlImage { get; set; }    
    }
}
