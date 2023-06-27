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
    public partial class Login : Form
    {
        private string Student { get; } = "student";
        private string PasswordSt { get; } = "student";
        private string Teacher { get; } = "teacher";
        private string PasswordT { get; } = "teacher";
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == Student && tbPassword.Text == PasswordSt)
            {
                this.Hide();
                Game game = new Game();
                game.ShowDialog();
                this.Close();
            }
            //else if (tbUsername.Text == Teacher && tbPassword.Text == PasswordT)
            //{
            //this.Hide();
            //TeachView teachView = new TeachView();
            //teachView.ShowDialog();
            //this.Close();
            //}
            else
            {
                MessageBox.Show("Log in failed", "Log in credentials are not correct. Please try again",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
