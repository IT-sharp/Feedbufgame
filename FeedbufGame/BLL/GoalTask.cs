using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class GoalTask
    {
        private List<GoalTask> TaskList { get; set; }
        private Feedup FeedupFetch { get; }
        private int Id { get; set; }
        private string Feedup { get; set; }
        private string TaskDescription { get; set; }
        private bool IsDone { get; set; }

        public GoalTask(int id, string feedup, string taskDescription, bool isDone)
        {
            Id = id;
            TaskDescription = taskDescription;
            Feedup = feedup;
            IsDone = isDone;
        }
        public List<GoalTask> ReadTask()
        {
            return TaskList;
        }
        public string GetGoal()
        {
            string goal = FeedupFetch.Goal;
            Feedup = goal;
            return Feedup;
        }
    }
}
