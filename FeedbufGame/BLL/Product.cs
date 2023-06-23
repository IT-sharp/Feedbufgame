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
        private int Worth { get; set; }
        private List<Product> ProductList { get; set; }
        public Product(int id, string image)
        {
            Id = id;
            Image = image;
        }
        public List<Product> Read()
        {
            return ProductList;
        }
    }
}
