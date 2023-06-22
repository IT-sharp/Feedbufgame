using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Feedback : Feed
    {
        private List<Feedback> FeedbackList { get; set; }
        public List<Feedback> Read()
        {
            return FeedbackList;
        }
    }
}
