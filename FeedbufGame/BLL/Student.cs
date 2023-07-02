using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Student
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private int PhoneNumber { get; set; }
        private string EmailAdress { get; set; }
        private int Points { get; set; }
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
