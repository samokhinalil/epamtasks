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
    public class AwardSqlStorage : IStorage<Award>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public void Add(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("AddAward"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.Add("@title", SqlDbType.NVarChar, 50);
                    command.Parameters["@title"].Value = award.Title;

                    command.Parameters.Add("@description", SqlDbType.NVarChar, 250);
                    if (award.Description == null)
                    {
                        command.Parameters["@description"].Value = string.Empty;
                    }
                    else
                    {
                        command.Parameters["@description"].Value = award.Description;
                    }

                    var returnParameter = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    command.ExecuteNonQuery();

                    int resultID = (int)returnParameter.Value;
                    award.ID = resultID;
                } 
            }
        }

        public void Edit(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "UpdateAward";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = award.ID;

                    command.Parameters.Add("@title", SqlDbType.NVarChar, 50);
                    command.Parameters["@title"].Value = award.Title;

                    command.Parameters.Add("@description", SqlDbType.NVarChar, 250);
                    if (award.Description == null)
                    {
                        command.Parameters["@description"].Value = string.Empty;
                    }
                    else
                    {
                        command.Parameters["@description"].Value = award.Description;
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Remove(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "DeleteAward";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id", award.ID);

                    connection.Open();
                    command.ExecuteNonQuery();
                } 
            }
        }

        public List<Award> GetAll()
        {
            List<Award> awards = new List<Award>();
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "GetAwards";
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Award award = new Award();
                            award.ID = reader.GetInt32(0);
                            award.Title = reader.GetString(1);
                            if (reader.IsDBNull(2))
                            {
                                award.Description = string.Empty;
                            }
                            else
                            {
                                award.Description = reader.GetString(2);
                            }

                            awards.Add(award);
                        }
                    }
                }
                return awards;
            }
        }
    }
}
