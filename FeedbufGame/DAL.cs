﻿using FeedbufGame.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame
{
    internal class DAL
    {
        string connectionString = "";
        public List<FeedupPop> feedupList = new List<FeedupPop>();
        public List<Feed> feedforwardList = new List<Feed>();
        public List<Feed> feedbackList = new List<Feed>();
        public List<Student> studentList = new List<Student>();
        public DAL()
        {

        }

    }
}
