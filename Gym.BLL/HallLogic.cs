using System.Collections.Generic;
using Entities;
using Gym.DAL;
using Gym.DAL.Interfaces;
using Gym.BLL.Interfaces;
namespace Gym.BLL
{
    public class HallLogic:IHallLogic
    {
        private IHallDao hallDao;
        public HallLogic()
        {
            hallDao = new HallDaoDB();
        }
        public IEnumerable <Hall> GetHalls()
        {
            return hallDao.GetHalls();
        }
        public string GetNeedHalls(int idHall)
        {
            return hallDao.GetNeedHalls(idHall);
        }
        public int  GetNeedHalls(string nameOfHall)
        {
            return hallDao.GetNeedHalls(nameOfHall);
        }
        public void AddHall (Hall hall)
        {
            hallDao.AddHall(hall);
        }
        public void RemoveHall (int idHall)
        {
            hallDao.RemoveHall(idHall);
        }
    }
}
