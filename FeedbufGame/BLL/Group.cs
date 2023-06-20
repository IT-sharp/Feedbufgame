using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Group
    {
        private string Name { get; set; }
        private List<Group> Students { get; set; }
        public List<Group> GetStudent(List<Group> students)
        {
            Students = students;

            return Students;
        }
    }
}
