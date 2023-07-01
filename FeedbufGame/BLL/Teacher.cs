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
        public string Name { get; set; }
        private int PhoneNumber { get; set; }
        private string EmailAdress { get; set; }
        private List<Teacher> Teachers { get; set; }
        private Group Group { get; set; }

        public Teacher(string name, int phoneNumber, string emailAdress)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAdress = emailAdress;
        }
        public void GetStudents()
        {

        }
        public List<Teacher> Read()
        {
            return Teachers;
        }
    }
}
