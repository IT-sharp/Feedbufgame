using FeedbufGame.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbufGame
{
    public partial class FeedAllPop : Form
    {
        public FeedAllPop()
        {
            InitializeComponent();
            BLL.Feed feed = new BLL.Feed(0, "", "", DateTime.Now, "");
            BLL.Feedup feedup = new BLL.Feedup(0, "", "", DateTime.Now);
            BLL.GoalTask task = new BLL.GoalTask(0, "", "", false);
            foreach (BLL.Feedup feedUp in feedup.Read())
            {
                feedup.Update(feedUp);
                LbFeedup.Items.Add("Vak: " + feedUp.Subject + "     Doel: " + feedUp.Goal + "     Deadline: " + feedUp.Deadline);
            }
            foreach (BLL.Feed feedback in feed.ReadFeedback())
            {
                feed.UpdateFeedback(feedback);
                LbFeedback.Items.Add("Teacher: " + feedback.Teacher + "     Feedback: " + feedback.Commentary + "     Datum: " + feedback.Date + "     Doel: " + feedback.Feedup);
            }
            foreach (BLL.Feed feedforward in feed.ReadFeedforward())
            {
                feed.UpdateFeedback(feedforward);
                LbFeedback.Items.Add("Teacher: " + feedforward.Teacher + "     Feedforward: " + feedforward.Commentary + "     Datum: " + feedforward.Date + "     Doel: " + feedforward.Feedup);
            }
            foreach (BLL.GoalTask tasked in task.ReadTask())
            {
                task.Update(tasked);
                if (task.IsDone)
                {
                    LbTasks.Items.Add("Taak: " + tasked.TaskDescription + "     Doel: " + task.Feedup);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
