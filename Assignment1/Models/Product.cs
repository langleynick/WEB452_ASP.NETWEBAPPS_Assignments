using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment1.Models
{
    // OCT 14 3:30 Model class for the products
    // OCT 14 7:30 Added validation
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Title")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Type of Wood")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string WoodType  { get; set; }

        [Display(Name = "Height(inches)")]
        [Range(0, 200)]
        public int Height { get; set; }

        [Display(Name = "Width(inches)")]
        [Range(0, 200)]
        public int Width { get; set; }

        [Display(Name = "Length(inches)")]
        [Range(0, 200)]
        public int Length { get; set; }

        [Display(Name = "Price(CAD$)")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Review")]
        [Range(1,5)]
        public int Review { get; set; }
    }
}
