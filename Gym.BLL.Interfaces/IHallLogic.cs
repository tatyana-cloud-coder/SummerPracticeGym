using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Gym.BLL.Interfaces
{
    public interface IHallLogic
    {
        IEnumerable<Hall> GetHalls();
        string GetNeedHalls(int idHall);
        string  GetNeedHalls (string nameOfHall);
        void AddHall(Hall hall);
        void RemoveHall(int idHall);
    }
}
