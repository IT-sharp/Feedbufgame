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
    public partial class Game : Form
    {
        public Game()
        {
            //Student student = new Student();
            InitializeComponent();
            //if(student.Animal == "None")
            //{
            //    AnimalSelectPop animalSelect = new AnimalSelectPop();
            //    animalSelect.ShowDialog();
            //}
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
            Feedup feedup = new Feedup();
            feedup.ShowDialog();
        }

        private void FeedTasksBtn_Click(object sender, EventArgs e)
        {
            TaskPop tasks = new TaskPop();
            tasks.ShowDialog();
        }

        private void FeedBtn_Click(object sender, EventArgs e)
        {
            FeedAllPop feedAll = new FeedAllPop();
            feedAll.ShowDialog();
        }
    }
}
