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
            Student student = new Student(0,"",0,"",0,"");
            InitializeComponent();
            if(student.Animal == "None")
            {
                AnimalSelectPop animalSelect = new AnimalSelectPop();
                animalSelect.ShowDialog();
            }
            else if(student.Animal == "Fox1")
            {
                if (HappyBar.Value >= 20)
                {
                    AnimalPIc.Image = FeedbufGame.Properties.Resources.HappyFox1;
                }
                else if (HappyBar.Value < 20)
                {
                    AnimalPIc.Image = FeedbufGame.Properties.Resources.SadFox1;
                }
            }
            else if(student.Animal == "Fox2")
            {
                if(HappyBar.Value >= 20)
                {
                    AnimalPIc.Image = FeedbufGame.Properties.Resources.HappyFox2;
                }
                else if(HappyBar.Value < 20)
                {
                    AnimalPIc.Image = FeedbufGame.Properties.Resources.SadFox2;
                }
            }
            else if(student.Animal == "Frog1")
            {
                if (HappyBar.Value >= 20)
                {
                    AnimalPIc.Image = FeedbufGame.Properties.Resources.HappyFrog1;
                }
                else if (HappyBar.Value < 20)
                {
                    AnimalPIc.Image = FeedbufGame.Properties.Resources.SadFrog1;
                }
            }
            else if (student.Animal == "Frog2")
            {
                if (HappyBar.Value >= 20)
                {
                    AnimalPIc.Image = FeedbufGame.Properties.Resources.HappyFrog2;
                }
                else if (HappyBar.Value < 20)
                {
                    AnimalPIc.Image = FeedbufGame.Properties.Resources.SadFrog2;
                }
            }
            else if (student.Animal == "Dragon1")
            {
                if (HappyBar.Value >= 20)
                {
                    AnimalPIc.Image = FeedbufGame.Properties.Resources.HappyDragon1;
                }
                else if (HappyBar.Value < 20)
                {
                    AnimalPIc.Image = FeedbufGame.Properties.Resources.SadDragon1;
                }
            }
            else if (student.Animal == "Dragon2")
            {
                if (HappyBar.Value >= 20)
                {
                    AnimalPIc.Image = FeedbufGame.Properties.Resources.HappyDragon2;
                }
                else if (HappyBar.Value < 20)
                {
                    AnimalPIc.Image = FeedbufGame.Properties.Resources.SadDragon2;
                }
            }

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
