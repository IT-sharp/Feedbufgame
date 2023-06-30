using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Product
    {
        private int Id { get; set; }
        private string Image { get; set; }
        private string Category { get; set; }
        private string Description { get; set; }
        private int Price { get; set; }
        private List<Product> ProductList { get; set; }

        public Product(int id, string image, string category, string description, int price)
        {
            Id = id;
            Image = image;
            Category = category;
            Description = description;
            Price = price;
        }
        public List<Product> Read()
        {
            return ProductList;
        }
    }
}
