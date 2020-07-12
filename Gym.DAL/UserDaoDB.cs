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
    public class UserDaoDB : IUserDao
    {
        private string connectionstring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True";
        public void RegisterUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("AddUser", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@firstName", user.FirstName);
                cmd.Parameters.AddWithValue("@lastName", user.LastName);
                cmd.Parameters.AddWithValue("@telephoneNumber", user.TelephoneNumber);
                cmd.Parameters.AddWithValue("@email", user.EmailAddress);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@passwordHashCode", user.Password.GetHashCode());
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public IEnumerable<User> GetNeedUsers(string login, int passwordHashCode)
        {
            var result = new List<User>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("GetNeedUsers", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@passwordHashCode", passwordHashCode);
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())  //пока читаем
                {
                    var user = new User
                    {
                        IDUser = (int)read["IDUser"],
                        FirstName = (string)read["FirstName"],
                        LastName = (string)read["LastName"],
                        TelephoneNumber = (string)read["TelephoneNumber"],
                        EmailAddress = (string)read["Email"]
                    };
                    result.Add(user);
                }
            }
            return result;
        }
        public void UpdateFirstName(int idUser, string nextName)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("UpdateFirstName", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUser", idUser);
                cmd.Parameters.AddWithValue("@nextName", nextName);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateLastName(int idUser, string nextName)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("UpdateLastName", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUser", idUser);
                cmd.Parameters.AddWithValue("@nextName", nextName);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateTelephoneNumber(int idUser, string nextNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("UpdateTelephoneNumber", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUser", idUser);
                cmd.Parameters.AddWithValue("@nextNumber", nextNumber);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}
