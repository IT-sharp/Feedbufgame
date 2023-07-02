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
        private int Id { get; set; }
        private string Teacher { get; set; }
        private string Commentary { get; set; }
        private DateTime Date { get; set; }
        private string Feedup { get; set; }

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
        public void CreateFeed()
        {

        }
    }
}
