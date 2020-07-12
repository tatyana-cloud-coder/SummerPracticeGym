using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using Gym.DAL.Interfaces;
namespace Gym.DAL
{
    public class ClientDaoDB:IClientDao
    {
        private readonly string connectionstring;
        private readonly ICoachDao coachDao;
        public ClientDaoDB()
        {
            coachDao = new CoachDaoDB();
            connectionstring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True";
        }
        public IEnumerable<Client> GetClients()
        {
            var result = new List<Client>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("GetAllClients", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())  //пока читаем
                {
                    int idClinet = (int)read["IDClient"];
                    string firstName = (string)read["FirstName"];
                    string lastName = (string)read["LastName"];
                    string telephoneNumber = (string)read["TelephoneNumber"];
                    int? idCoach = read["IDFavoriteCoach"] as int?;
                    if (idCoach.HasValue)
                    { 
                        var client = new Client
                        {
                            IDClient = idClinet,
                            FirstName = firstName,
                            LastName = lastName,
                            TelephoneNumber = telephoneNumber,
                            FirstNameOfFavoriteCoach = coachDao.GetFirstNameNeedCoach((int)idCoach),
                            LastNameOfFavoriteCoach = coachDao.GetLastNameNeedCoach((int)idCoach)
                        };
                        result.Add(client);
                    } else
                    {
                        var client = new Client
                        {
                            IDClient = idClinet,
                            FirstName = firstName,
                            LastName = lastName,
                            TelephoneNumber = telephoneNumber,
                            FirstNameOfFavoriteCoach = "NULL",
                            LastNameOfFavoriteCoach = "NULL",

                        };
                        result.Add(client);
                    }
                    
                }
            }
            return result;
        }
        public IEnumerable <Client> GetNeedClients(int idClient)
        {
            var result = new List<Client>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("GetNeedClients", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idClient", idClient);
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())  //пока читаем
                {
                    var client = new Client
                    {
                        IDClient = (int)read["IDClient"],
                        FirstName = (string)read["FirstName"],
                        LastName = (string)read["LastName"],
                        TelephoneNumber = (string)read["TelephoneNumber"],
                        FirstNameOfFavoriteCoach = coachDao.GetFirstNameNeedCoach((int)read["IDFavoriteCoach"]),
                        LastNameOfFavoriteCoach = coachDao.GetLastNameNeedCoach((int)read["IDFavoriteCoach"])
                    };
                    result.Add(client);
                }
            }
            return result;
        }
        public void AddClient (Client client)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("AddClient", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@firstName", client.FirstName);
                cmd.Parameters.AddWithValue("@lastName", client.LastName);
                cmd.Parameters.AddWithValue("@telephoneNumber", client.TelephoneNumber);
                if (client.FirstNameOfFavoriteCoach != null && client.LastNameOfFavoriteCoach != null)
                {
                    cmd.Parameters.AddWithValue("@idFavoriteCoach", coachDao.SelectIdNeedCoach(client.FirstNameOfFavoriteCoach, client.LastNameOfFavoriteCoach));
                }
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void RemoveClient (int idClient)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("RemoveClient", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idClient", idClient);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
