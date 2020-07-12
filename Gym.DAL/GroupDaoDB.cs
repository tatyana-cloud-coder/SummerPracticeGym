﻿using System;
using System.Collections.Generic;
using Entities;
using System.Data.SqlClient;
using Gym.DAL.Interfaces;
namespace Gym.DAL
{
    public class GroupDaoDB: IGroupDao
    {
        private string connectionstring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True";
        public IEnumerable <Group> GetGroups()
        {
            var result = new List<Group>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("GetGroups", connection);  //SQL-команда
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())  //пока читаем
                {

                    var group = new Group
                    {
                       IDGroup = (int)read["IDGroup"],
                       Name = (string)read["Name"],
                       Number = (int) read["Number"],
                       WorkingDay = Group.DayOfWeek((int)read["WorkingDay"]),
                       TimeToBegin = (TimeSpan)read["TimeToBegin"],
                       TimeToEnd = (TimeSpan)read["TimeToEnd"]
                    };
                    result.Add(group);
                }
            }
            return result;
        }
        public IEnumerable<Group> GetNeedGroups (int idGroup)
        {
            var result = new List<Group>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("GetNeedGroupsById", connection);  //SQL-команда
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idGroup", idGroup);
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())  //пока читаем
                {
                    var group = new Group
                    {
                        IDGroup = (int)read["IDGroup"],
                        Name = (string)read["Name"],
                        Number = (int)read["Number"],
                        WorkingDay = Group.DayOfWeek((int)read["WorkingDay"]),
                        TimeToBegin = (TimeSpan)read["TimeToBegin"],
                        TimeToEnd = (TimeSpan)read["TimeToEnd"]
                    };
                    result.Add(group);
                }
            }
            return result;
        }
        public IEnumerable <Group> GetNeedGroups(string name)
        {
            var result = new List<Group>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("GetNeedGroups", connection);  //SQL-команда
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameGroup", name);
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())  //пока читаем
                {
                    var group = new Group
                    {
                        IDGroup = (int)read["IDGroup"],
                        Name = (string)read["Name"],
                        Number = (int)read["Number"],
                        WorkingDay = Group.DayOfWeek((int)read["WorkingDay"]),
                        TimeToBegin = (TimeSpan)read["TimeToBegin"],
                        TimeToEnd = (TimeSpan)read["TimeToEnd"]
                    };
                    result.Add(group);
                }
            }
            return result;
        }
        public IEnumerable <int> GetDeletedGroups (string name)
        {
            var result = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("SelectDeletedGroup", connection);  //SQL-команда
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameGroup", name);
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())  //пока читаем
                {
                    result.Add((int)read["IDGroup"]);
                }
            }
            return result;
        }
        public IEnumerable<int> GetNeedClientByGroup(int idClient, string nameGroup)
        {
            var result = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("GetNeedClientByGroup", connection);  //SQL-команда
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idClient", idClient);
                cmd.Parameters.AddWithValue("@nameGroup", nameGroup);
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())  //пока читаем
                {
                    result.Add((int)read["IDGroup"]);
                }
            }
            return result;
        }
        public void AddGroup (Group group)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("AddGroup", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", group.Name);
                cmd.Parameters.AddWithValue("@workingday", Group.IndexDay(group.WorkingDay));
                cmd.Parameters.AddWithValue("@timeToBegin", group.TimeToBegin);
                cmd.Parameters.AddWithValue("@timeToEnd", group.TimeToEnd);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void AddClientByGroup (string nameGroup, int idClient)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("addClientByGroup", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameGroup", nameGroup);
                cmd.Parameters.AddWithValue("@idClient", idClient);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void RemoveGroup (int idGroup)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("RemoveGroup", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idGroup", idGroup);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
