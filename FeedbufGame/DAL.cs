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
        public List<Feedup> feedupList = new List<Feedup>();
        public List<Feed> feedbackList = new List<Feed>();
        public List<Feed> feedforwardList = new List<Feed>();
        public List<Student> studentRoster = new List<Student>();
        public List<Teacher> teacherRoster = new List<Teacher>();
        public List<GoalTask> taskList = new List<GoalTask>();
        public List<Group> studentGroup = new List<Group>();
        public List<Product> productList = new List<Product>();
        public DAL()
        {

        }
        public List<Feed> ReadFeedback()
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
        public List<Feed> ReadFeedforward()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Feedforward ORDER BY Id";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            feedforwardList.Add(new Feed(Int32.Parse(reader[0].ToString())
                                , reader[1].ToString()
                                , reader[2].ToString()
                                , DateTime.Parse(reader[3].ToString())
                                , reader[4].ToString()
                                ));
                        }
                    }
                }
            }
            return feedforwardList;
        }
        public List<Feedup> ReadFeedup()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Feedup ORDER BY Id";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            feedupList.Add(new Feedup(Int32.Parse(reader[0].ToString())
                                , reader[1].ToString()
                                , reader[2].ToString()
                                , DateTime.Parse(reader[3].ToString())
                                ));
                        }
                    }
                }
            }
            return feedupList;
        }
        public List<Student> ReadStudent()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Student ORDER BY Id";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            studentRoster.Add(new Student(Int32.Parse(reader[0].ToString())
                                , reader[1].ToString()
                                , Int32.Parse(reader[2].ToString())
                                , reader[3].ToString()
                                , Int32.Parse(reader[4].ToString())
                                , reader[5].ToString()
                                ));
                        }
                    }
                }
            }
            return studentRoster;
        }
        public List<Teacher> ReadTeacher()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Teacher ORDER BY Id";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teacherRoster.Add(new Teacher(Int32.Parse(reader[0].ToString())
                                , reader[1].ToString()
                                , Int32.Parse(reader[2].ToString())
                                , reader[3].ToString()
                                ));
                        }
                    }
                }
            }
            return teacherRoster;
        }
        public List<GoalTask> ReadTask()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Task ORDER BY Id";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            taskList.Add(new GoalTask(Int32.Parse(reader[0].ToString())
                                , reader[1].ToString()
                                , reader[2].ToString()
                                , Boolean.Parse(reader[3].ToString())
                                ));
                        }
                    }
                }
            }
            return taskList;
        }
        public List<Group> ReadGroup()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Group ORDER BY Id";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            studentGroup.Add(new Group(Int32.Parse(reader[0].ToString())
                                , reader[1].ToString()
                                ));
                        }
                    }
                }
            }
            return studentGroup;
        }
        public List<Product> ReadProduct()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Product ORDER BY Id";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productList.Add(new Product(Int32.Parse(reader[0].ToString())
                                , reader[1].ToString()
                                , reader[2].ToString()
                                , reader[3].ToString()
                                , Int32.Parse(reader[4].ToString())
                                ));
                        }
                    }
                }
            }
            return productList;
        }
    }
}
