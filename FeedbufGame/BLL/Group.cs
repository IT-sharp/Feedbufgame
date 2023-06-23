using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Group
    {
        private string GroupName { get; set; }
        private Student Student { get; set; }
        private List<Group> Students { get; set; }
        public List<Group> GroupStudents(List<Group> students)
        {
            Students = students;

            return Students;
        }
    }
}
