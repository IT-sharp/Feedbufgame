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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void FeedBackForwardBtn_Click(object sender, EventArgs e)
        {
            FeedBackForwardPop feedBackFoward = new FeedBackForwardPop();
            feedBackFoward.ShowDialog();
        }

        private void FeedupBtn_Click(object sender, EventArgs e)
        {
            FeedupPop feedup = new FeedupPop();
            feedup.ShowDialog();
        }

        private void FeedTasksBtn_Click(object sender, EventArgs e)
        {
            TasksPop tasks = new TasksPop();
            tasks.ShowDialog();
        }

        private void FeedBtn_Click(object sender, EventArgs e)
        {
            FeedAllPop feedAll = new FeedAllPop();
            feedAll.ShowDialog();
        }
    }
}
