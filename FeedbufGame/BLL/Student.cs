using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Student
    {
        private string Name { get; set; }
        private int PhoneNumber { get; set; }
        private string EmailAddress { get; set; }
        private int Points { get; set; }
        private List<Student> FeedupList { get; set; }
        private List<Student> Students { get; set; }
        public List<Student> Read()
        {
            return Students;
        }
    }
}
