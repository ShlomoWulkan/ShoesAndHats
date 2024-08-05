using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ShoesAndHats.Models
{
    public class Hats
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "מידה")]
        public int Size { get; set; }
        [Display(Name = "צבע")]
        public string Color { get; set; } = string.Empty;
        [Display(Name = "מותג")]
        public string Brand { get; set; } = string.Empty;
        [Display(Name = "תמונה")]
        public string Url { get; set; } = string.Empty;

    }
}
