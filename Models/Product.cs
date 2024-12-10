using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Html_Helper_Asp.net.Models
{
    public class Product
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; }
        public string SKU  { get; set; }
        public string Category { get; set; }
        public decimal Price  {get; set; }
        public bool InStock { get; set; }
        public string Gender { get; set; }
        public bool Hobby { get; set; }
        public string Description { get; set; }
        public List<string> Countries { get; set; } = new List<string>();
    }
}