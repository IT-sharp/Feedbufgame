using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public int Points { get; set; }
        public string Animal { get; set; }
        private List<Student> StudentRoster { get; set; }
        private DAL dal { get; set; }

        public Student(int id, string name, int phoneNumber, string emailAdress, int points, string animal)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAdress = emailAdress;
            Points = points;
            Animal = animal;
        }
        public List<Student> Read()
        {
            return dal.ReadStudent();
        }
    }
}
