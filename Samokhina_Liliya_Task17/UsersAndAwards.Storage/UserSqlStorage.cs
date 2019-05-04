using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.Entities;

namespace UsersAndAwards.Storage
{
    public class UserSqlStorage : IStorage<User>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private List<User> users = new List<User>();

        public void Add(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("AddUser");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.Add("@firstname", SqlDbType.NVarChar, 50);
                command.Parameters["@firstname"].Value = user.FirstName;

                command.Parameters.Add("@lastname", SqlDbType.NVarChar, 50);
                command.Parameters["@lastname"].Value = user.LastName;

                command.Parameters.Add("@birthdate", SqlDbType.DateTime2);
                command.Parameters["@birthdate"].Value = user.BirthDate;

                var returnParameter = command.Parameters.Add("@Return", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                connection.Open();
                command.ExecuteNonQuery();

                int resultID = (int)returnParameter.Value;
                user.ID = resultID;
                users.Add(user);
                AddUserAwards(connection, user);
            }
        }

        private void AddUserAwards(SqlConnection connection, User user)
        {
            DataTable tempRewardsTable = new DataTable();
            tempRewardsTable.Columns.Add("RewardId", typeof(int));
            foreach (var award in user.UserAwards)
            {
                tempRewardsTable.Rows.Add(award.ID);
            }

            using (var command = new SqlCommand())
            {
                command.CommandText = "InsertUserRewards";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                
                command.Parameters.AddWithValue("@userId", user.ID);
                var rewardsTableParameter = command.Parameters.AddWithValue("@rewardIds", tempRewardsTable);
                rewardsTableParameter.SqlDbType = SqlDbType.Structured;

                command.ExecuteNonQuery();
            }
        }

        private void DeleteUserAwards(SqlConnection connection, User user)
        {
            using (var command = new SqlCommand())
            {
                command.CommandText = "DeleteUserAwards";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@userId", user.ID);

                command.ExecuteNonQuery();
            }
        }

        public void Edit(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandText = "UpdateUser";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = user.ID;

                command.Parameters.Add("@firstname", SqlDbType.NVarChar, 50);
                command.Parameters["@firstname"].Value = user.FirstName;

                command.Parameters.Add("@lastname", SqlDbType.NVarChar, 50);
                command.Parameters["@lastname"].Value = user.LastName;

                command.Parameters.Add("@birthdate", SqlDbType.DateTime2);
                command.Parameters["@birthdate"].Value = user.BirthDate;

                connection.Open();
                command.ExecuteNonQuery();
                DeleteUserAwards(connection, user);
                AddUserAwards(connection, user);
            }
        }

        public void Remove(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandText = "DeleteUser";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", user.ID);

                connection.Open();
                command.ExecuteNonQuery();

                users.Remove(user);
            }
        }

        public List<User> GetAll()
        {
            users = new List<User>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandText = "GetUsers";
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.ID = reader.GetInt32(0);
                        user.FirstName = reader.GetString(1);
                        user.LastName = reader.GetString(2);
                        user.BirthDate = reader.GetDateTime(3);

                        users.Add(user);
                    }
                }
                FillUserRewards(users);
                return users;
            }
        }

        private void FillUserRewards(List<User> users)
        {
            foreach (var user in users)
            {
                user.UserAwards = new List<Award>();
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    command.CommandText = "GetUserAwards";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@userId", user.ID);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var reward = new Award();
                                reward.ID = reader.GetInt32(0);
                                reward.Title = reader.GetString(1);
                                reward.Description = reader.GetString(2);
                                user.UserAwards.Add(reward);
                            }
                        }
                    } 
                }
            }
        }
        
        //public User GetByID(int index)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
