using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Feedup
    {
        private List<Feedup> FeedupList { get; set; }
        private string Subject { get; set; }
        private string Goal { get; set; }
        private DateTime Deadline { get; set; }
        public Feedup(string subject, string goal, DateTime deadline)
        {
            Subject = subject;
            Goal = goal;
            Deadline = deadline;
        }

        public List<Feedup> Read()
        {
            return FeedupList;
        }
        public void CreateGoal()
        {

        }
    }
}
