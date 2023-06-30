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
        BLL.Feed feed = new BLL.Feed(0,"",DateTime.Now,0);
        public FeedBackForwardPop()
        {
            InitializeComponent();
        }

        private void feedButton_Click(object sender, EventArgs e)
        {
            feed.CreateFeed();
        }
    }
}
