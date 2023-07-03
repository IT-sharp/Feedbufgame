using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Feed
    {
        private Teacher TeacherFetch { get; }
        private Feedup FeedupFetch { get; }
        private DAL dal { get; set; }
        private List<Feed> FeedbackList { get; set; }
        private List<Feed> FeedforwardList { get; set; }
        public int Id { get; set; }
        public string Teacher { get; set; }
        public string Commentary { get; set; }
        public DateTime Date { get; set; }
        public string Feedup { get; set; }

        public Feed(int id, string teacher, string commentary, DateTime date, string feedup)
        {
            Id = id;
            Teacher = teacher;
            Commentary = commentary;
            Date = date;
            Feedup = feedup;
        }
        public List<Feed> ReadFeedback(List<Feed> feedbackList)
        {
            FeedbackList = feedbackList;
            return dal.ReadFeedback();
        }
        public List<Feed> ReadFeedforward(List<Feed> feedforwardList)
        {
            FeedforwardList = feedforwardList;
            return dal.ReadFeedforward();
        }
        public Feed CreateFeedback(Feed feedback)
        {
            return dal.CreateFeedback(feedback);
        }
        public Feed CreateFeedforward(Feed feedforward)
        {
            return dal.CreateFeedforward(feedforward);
        }
        public void UpdateFeedback(Feed feedback)
        {
            dal.UpdateFeedback(feedback);
        }
        public void UpdateFeedforward(Feed feedforward)
        {
            dal.UpdateFeedforward(feedforward);
        }
    }
}
