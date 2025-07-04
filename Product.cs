using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide6
{
    internal class Product
    {
        public int brandId { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        
        public Product(int brandId, string name, int price, string description)
        {
            this.brandId = brandId;
            this.name = name;
            this.price = price;
            this.description = description;
        }
    }
}
