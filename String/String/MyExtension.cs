using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public double Price { get; set; }

        public Product() { }
        public Product(int id, string name, string origin, double price) {
            this.ID = id;
            this.Name = name;
            this.Origin = origin;
            this.Price = price;
        }
    }
}
