using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Gym.DAL.Interfaces
{
    public interface IHallDao
    {
        IEnumerable<Hall> GetHalls();
        string GetNeedHalls(int idHall);
        IEnumerable<int> GetNeedHalls(string nameOfHall);
        void AddHall(Hall hall);
        void RemoveHall(int idHall);
    }
}
