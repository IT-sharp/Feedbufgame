using FeedbufGame.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame
{
    internal class DAL
    {
        string connectionString = "";
        public List<Student> feedupList = new List<Student>();
        public List<Feed> feedbackList = new List<Feed>();
        public List<Feed> feedforwardList = new List<Feed>();
        public List<Student> studentList = new List<Student>();
        public List<Task> taskList = new List<Task>();
        public DAL()
        {

        }
        public List<Feed> Read()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Feedback ORDER BY Id";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            feedbackList.Add(new Feed(Int32.Parse(reader[0].ToString())
                                , reader[1].ToString()
                                , reader[2].ToString()
                                , DateTime.Parse(reader[3].ToString())
                                , reader[4].ToString()
                                ));
                        }
                    }
                }
            }
            return feedbackList;
        }
    }
}
