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
        BLL.Feedup feedup = new BLL.Feedup(0, "", "", DateTime.Now);
        public FeedBackForwardPop()
        {
            InitializeComponent();
            foreach(BLL.Feedup feedup in feedup.Read())
            {
                feedup.Update(feedup);
                CbGoal.Items.Add(feedup.Goal);
            }
            
        }

        private void feedButton_Click(object sender, EventArgs e)
        {
            feed = new BLL.Feed(0, CbGoal.SelectedItem.ToString(), CbTeacher.Text, DateTime.Now, TbComFeed.Text);

            if (CbBackForward.SelectedItem.ToString() == "Feedback")
            {
                feed.CreateFeedback(feed);
                MessageBox.Show("Succes", "Feedback toegevoegd!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (CbBackForward.SelectedItem.ToString() == "Feedforward")
            {
                feed.CreateFeedforward(feed);
                MessageBox.Show("Succes", "Feedforward toegevoegd!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
