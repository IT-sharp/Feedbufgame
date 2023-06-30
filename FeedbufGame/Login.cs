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
                AnimalSelect animal = new AnimalSelect();
                animal.ShowDialog();
                this.Close();
            }
            else if (tbUsername.Text == Teacher && tbPassword.Text == PasswordT)
            {
                this.Hide();
                TeacherView teacherView = new TeacherView();
                teacherView.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Log in mislukt", "Log in gegevens zijn niet correct. Probeer het opnieuw",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
