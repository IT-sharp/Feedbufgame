using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Task
    {
        private List<Task> TaskList { get; set; }
        private int Id { get; set; }
        private Feedup Feedup { get; set; }
        private string TaskDescription { get; set; }
        private bool IsDone { get; set; }

        public Task(int id, Feedup feedup, string taskDescription, bool isDone)
        {
            Id = id;
            Feedup = feedup;
            TaskDescription = taskDescription;
            IsDone = isDone;
        }
        public List<Task> ReadTask()
        {
            return TaskList;
        }
        public string GetGoal()
        {
            return Feedup.Goal;
        }

    }
}
