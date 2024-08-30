using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_var_AnonymousType
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public List<string> Category { get; set; }
        public decimal Price { get; set; }

        public Product(
            int id, 
            string name, 
            string picture, 
            string description, 
            List<string> category, 
            decimal price)
        {
            Id = id;
            Name = name;
            Picture = picture;
            Description = description;
            Category = category;
            Price = price;
        }
    }
}
