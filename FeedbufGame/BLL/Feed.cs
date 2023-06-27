using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Feed
    {
        private List<Feed> FeedbackList { get; set; }
        private List<Feed> FeedfowardList { get; set; }
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
        public List<Feed> ReadFeedback()
        {
            return FeedbackList;
        }
        public List<Feed> ReadFeedforward()
        {
            return FeedfowardList;
        }
    }
}
