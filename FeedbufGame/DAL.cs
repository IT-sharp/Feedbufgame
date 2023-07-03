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
        string connectionString = "Data Source=ASUSDRAGON\\SQLEXPRESS;Initial Catalog=FeedbufGame;Integrated Security=True";
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

        //Read methods
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
        
        //Create methods
        public Feedup CreateFeedup(Feedup feedup)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Feedup (Subject, Goal, Deadline) VALUES (@Subject, @Goal, @Deadline)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Subject", feedup.Subject);
                        command.Parameters.AddWithValue("@Goal", feedup.Goal);
                        command.Parameters.AddWithValue("@Deadline", feedup.Deadline);
                        command.ExecuteNonQuery();
                        command.CommandText = "SELECT CAST(@@Identity AS INT);";
                        int id = Convert.ToInt32(command.ExecuteScalar());
                        feedup.Id = id;
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
            return feedup;
        }
        public Feed CreateFeedback(Feed feedback)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Feedback (Teacher, Commentary, Date, Feedup) VALUES (@Subject, @Goal, @Deadline)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Teacher", feedback.Teacher);
                        command.Parameters.AddWithValue("@Commentary", feedback.Commentary);
                        command.Parameters.AddWithValue("@Date", feedback.Date);
                        command.Parameters.AddWithValue("@Feedup", feedback.Feedup);
                        command.ExecuteNonQuery();
                        command.CommandText = "SELECT CAST(@@Identity AS INT);";
                        int id = Convert.ToInt32(command.ExecuteScalar());
                        feedback.Id = id;
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
            return feedback;
        }
        public Feed CreateFeedforward(Feed feedforward)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Feedforward (Teacher, Commentary, Date, Feedup) VALUES (@Subject, @Goal, @Deadline)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Teacher", feedforward.Teacher);
                        command.Parameters.AddWithValue("@Commentary", feedforward.Commentary);
                        command.Parameters.AddWithValue("@Date", feedforward.Date);
                        command.Parameters.AddWithValue("@Feedup", feedforward.Feedup);
                        command.ExecuteNonQuery();
                        command.CommandText = "SELECT CAST(@@Identity AS INT);";
                        int id = Convert.ToInt32(command.ExecuteScalar());
                        feedforward.Id = id;
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
            return feedforward;
        }
        public GoalTask CreateTask(GoalTask task)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Task (Feedup, TaskDescription, IsDone) VALUES (@Feedup, @TaskDescription, @IsDone)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Feedup", task.Feedup);
                        command.Parameters.AddWithValue("@TaskDescription", task.TaskDescription);
                        command.Parameters.AddWithValue("@IsDone", task.IsDone);
                        command.ExecuteNonQuery();
                        command.CommandText = "SELECT CAST(@@Identity AS INT);";
                        int id = Convert.ToInt32(command.ExecuteScalar());
                        task.Id = id;
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
            return task;
        }

        //Update methods
        public void UpdateFeedup(Feedup feedup)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE Feedup SET Subject = @Subject, Goal = @Goal, Deadline = @Deadline WHERE Id = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", feedup.Id);
                        command.Parameters.AddWithValue("@Subject", feedup.Subject);
                        command.Parameters.AddWithValue("@Goal", feedup.Goal);
                        command.Parameters.AddWithValue("@Deadline", feedup.Deadline);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void UpdateFeedback(Feed feedback)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE Feedback SET Teacher = @Teacher, Commentary = @Commentary, Date = @Date, Feedup = @Feedup WHERE Id = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", feedback.Id);
                        command.Parameters.AddWithValue("@Teacher", feedback.Teacher);
                        command.Parameters.AddWithValue("@Commentary", feedback.Commentary);
                        command.Parameters.AddWithValue("@Date", feedback.Date);
                        command.Parameters.AddWithValue("@Feedup", feedback.Feedup);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void UpdateFeedforward(Feed feedforward)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE Feedforward SET Teacher = @Teacher, Commentary = @Commentary, Date = @Date, Feedup = @Feedup WHERE Id = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", feedforward.Id);
                        command.Parameters.AddWithValue("@Teacher", feedforward.Teacher);
                        command.Parameters.AddWithValue("@Commentary", feedforward.Commentary);
                        command.Parameters.AddWithValue("@Date", feedforward.Date);
                        command.Parameters.AddWithValue("@Feedup", feedforward.Feedup);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void UpdateTask(GoalTask task)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE Task SET Feedup = @Feedup, TaskDescription = @TaskDescription, IsDone = @IsDone WHERE Id = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", task.Id);
                        command.Parameters.AddWithValue("@Feedup", task.Feedup);
                        command.Parameters.AddWithValue("@TaskDescription", task.TaskDescription);
                        command.Parameters.AddWithValue("@IsDone", task.IsDone);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
    }
}
