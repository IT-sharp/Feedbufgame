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
        public int Id { get; set; }
        public string Feedup { get; set; }
        public string TaskDescription { get; set; }
        public bool IsDone { get; set; }
        private DAL dal { get; set; }

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
        public GoalTask Create(GoalTask task)
        {
            return dal.CreateTask(task); 
        }
        public void Update(GoalTask task)
        {
            dal.UpdateTask(task);
        }
    }
}
