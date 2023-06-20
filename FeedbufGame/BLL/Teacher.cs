using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbufGame.BLL
{
    internal class Teacher
    {
        private string Name { get; set; }
        private int PhoneNumber { get; set; }
        private string EmailAdress { get; set; }
        private List<Teacher> Teachers { get; set; }
        private Group Group { get; set; }
        public void GetStudent()
        {

        }
        public List<Teacher> Read()
        {
            return Teachers;
        }
    }
}
