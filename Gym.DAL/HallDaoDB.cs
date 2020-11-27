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
    public class HallDaoDB : IHallDao
    {
        private string connectionstring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True";
        public IEnumerable<Hall> GetHalls()
        {
            var result = new List<Hall>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("GetHalls", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())  //пока читаем
                {
                    var hall = new Hall
                    {
                        IDHall = (int)read["IDHall"],
                        NameOfHall = (string)read["NameOfHall"]
                    };
                    result.Add(hall);
                }
            }
            return result;
        }
        public string GetNeedHalls(int idHall)
        {
            var result = new List<String>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("GetNeedHalls", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idHall", idHall);
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())  //пока читаем
                {
                    result.Add((string)read["NameOfHall"]);
                }
            }
            return result.FirstOrDefault();
        }
        public IEnumerable<int> GetNeedHalls(string nameOfHall)
        {
            var result = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("GetNeedHallsByName", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameOfHall", nameOfHall);
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())  //пока читаем
                {
                    result.Add((int)read["IDHall"]);
                }
            }
            return result;
        }
        public void AddHall(Hall hall)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("AddHall", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameOfHall", hall.NameOfHall);
                connection.Open();
                cmd.ExecuteNonQuery();
            }

        }
        public void RemoveHall (int idHall)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("RemoveHall", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idHall", idHall);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
