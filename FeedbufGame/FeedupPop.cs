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
    public partial class FeedupPop : Form
    {
        BLL.Feedup feedup = new BLL.Feedup(0, "", "", DateTime.Now);
        public FeedupPop()
        {
            InitializeComponent();
        }

        private void feedButton_Click(object sender, EventArgs e)
        {
            DateTime deadline = DtpFeedup.Value;
            feedup = new BLL.Feedup(0, TbGoal.Text, CbSubject.Text, deadline);
            MessageBox.Show("Succes", "Feedup toegevoegd!",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
