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
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public List<Teacher> Teachers { get; set; }
        private Group Group { get; set; }
        private DAL dal { get; set; }

        public Teacher(int id, string name, int phoneNumber, string emailAdress)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAdress = emailAdress;
        }
        public void GetStudents()
        {

        }
        public List<Teacher> Read()
        {
            return dal.ReadTeacher();
        }
    }
}
