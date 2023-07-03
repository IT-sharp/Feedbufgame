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
    public partial class TaskPop : Form
    {
        BLL.Feedup feedup = new BLL.Feedup(0, "", "", DateTime.Now);
        BLL.GoalTask task = new BLL.GoalTask(0, "", "", false);
        public TaskPop()
        {
            InitializeComponent();
            foreach (BLL.Feedup feedup in feedup.Read())
            {
                feedup.Update(feedup);
                CbGoal.Items.Add(feedup.Goal);
            }
        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            task = new BLL.GoalTask(0, CbGoal.SelectedItem.ToString(), TbTask.Text, false);
            task.Create(task);
            MessageBox.Show("Succes", "Taak toegevoegd!",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
