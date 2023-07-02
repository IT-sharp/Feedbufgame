using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Group
    {
        private int Id { get; set; }
        private string GroupName { get; set; }
        private Student Student { get; set; }
        private List<Group> StudentGroup { get; set; }
        private DAL dal { get; set; }

        public Group(int id, string groupName)
        {
            Id = id;
            GroupName = groupName;
        }
        public List<Group> Read()
        {
            return dal.ReadGroup();
        }
    }
}
