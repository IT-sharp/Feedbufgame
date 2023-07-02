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
        private int Id { get; set; }
        private string Subject { get; set; }
        public string Goal { get; set; }
        private DateTime Deadline { get; set; }
        private Student student {get; set; }
        private DAL dal { get; set; }

        public Feedup(int id, string subject, string goal, DateTime deadline)
        {
            Id = id;
            Subject = subject;
            Goal = goal;
            Deadline = deadline;
        }

        public List<Feedup> Read()
        {
            return dal.ReadFeedup();
        }
        public void CreateFeedup()
        {

        }
    }
}
