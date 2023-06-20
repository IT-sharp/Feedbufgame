using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Feedback
    {
        private List<Feedback> FeedbackList { get; set; }
        private string Teacher { get; set; }
        private string Commentary { get; set; }
        private DateTime Date { get; set; }
        public List<Feedback> Read()
        {
            return FeedbackList;
        }
    }
}
