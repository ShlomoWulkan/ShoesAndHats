using System.ComponentModel.DataAnnotations;

namespace ShoesAndHats.Models
{
    public class Shoes
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "מידה")]
        public int Size { get; set; }

        [Display(Name ="מותג")]
        public string Brands { get; set; }

        [Display(Name = "צבע")]
        public string Color { get; set; }

        [Display(Name = "קישור לתמונה")]
        public string UrlImage { get; set; }    
    }
}
