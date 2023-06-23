using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Feed
    {
        private Teacher Teacher { get; set; }
        private string Commentary { get; set; }
        private DateTime Date { get; set; }
        private Feedup Feedup { get; set; }
        public Feed(Teacher teacher, string commentary, DateTime date, Feedup feedup)
        {
            Teacher = teacher;
            Commentary = commentary;
            Date = date;
            Feedup = feedup;
        }
    }
}
