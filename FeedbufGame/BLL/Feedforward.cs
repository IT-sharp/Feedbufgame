using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Feedforward : Feed
    {
        private List<Feedforward> FeedfowardList { get; set; }
        public Feedforward(Teacher teacher, string commentary, DateTime date, Feedup feedup)
        {
            
        }
        public List<Feedforward> Read()
        {
            return FeedfowardList;
        }
    }
}
