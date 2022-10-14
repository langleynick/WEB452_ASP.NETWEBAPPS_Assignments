using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    //Model class for the products
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string WoodType  { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public decimal Price { get; set; }
        public int Review { get; set; }
    }
}
