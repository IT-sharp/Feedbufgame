using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Shop : Product
    {
        private bool Owned { get; set; } = false;
        private bool Equiped { get; set; } = false;

        public Shop(int id, string image, string category, string description, int price, bool owned, bool equiped)
            :base(id, image, category, description, price)
        {
            Owned = owned;
            Equiped = equiped;
        }
        public void Display()
        {

        }
        public void BuyItem()
        {

        }

    }
}
