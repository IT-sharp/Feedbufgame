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
    public partial class FeedBackForwardPop : Form
    {
        BLL.Feed feed = new BLL.Feed(0,"","",DateTime.Now,"");
        BLL.Feedup feedup = new BLL.Feedup(0, "Math", "Getgud", DateTime.Now);
        public FeedBackForwardPop()
        {
            InitializeComponent();
            foreach(BLL.Feedup feedup in feedup.Read())
            {

            }
        }

        private void feedButton_Click(object sender, EventArgs e)
        {
            string inputGoal = CbGoal.Text;
            string inputTeach = CbTeacher.Text;
            string inputCom = TbComFeed.Text;

            if(CbBackForward.ValueMember == "Feedback")
            {
                feed.CreateFeedback();
            }    
            else if(CbBackForward.ValueMember == "Feedforward")
            {
                feed.CreateFeedforward();
            }
        }
    }
}
