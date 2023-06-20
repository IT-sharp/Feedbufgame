using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Shop
    {
        private int Id { get; set; }
        private string Image { get; set; }
        private List<Shop> ShopList { get; set; }
        public Shop(int id, string image)
        {
            Id = id;
            Image = image;
        }
    }
}
