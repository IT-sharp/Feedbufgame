﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Feedup
    {
        private string Subject { get; set; }
        public string Goal { get; set; }
        private DateTime Deadline { get; set; }
        private Student student {get; set; }
        public Feedup(string subject, string goal, DateTime deadline)
        {
            Subject = subject;
            Goal = goal;
            Deadline = deadline;
        }

        //public List<Feedup> Read()
        //{
        //    return FeedupList;
        //}
        public void CreateFeedup()
        {

        }
    }
}
