using System.Collections.Generic;
using Entities;
using Gym.DAL;
using Gym.DAL.Interfaces;
using Gym.BLL.Interfaces;
using System;
using System.Linq;

namespace Gym.BLL
{
    public class HallLogic:IHallLogic
    {
        private IHallDao _hallDao;
        public HallLogic(IHallDao hallDao)
        {
            _hallDao = hallDao;
        }
        public IEnumerable <Hall> GetHalls()
        {
            return _hallDao.GetHalls();
        }
        public string GetNeedHalls(int idHall)
        {
            return _hallDao.GetNeedHalls(idHall);
        }
        public string  GetNeedHalls(string nameOfHall)
        {
            var result = _hallDao.GetNeedHalls(nameOfHall);
            if (result.Any())
            {
                return result.FirstOrDefault().ToString();
            } else
            {
                return null;
            }
        }
        public void AddHall (Hall hall)
        {
            _hallDao.AddHall(hall);
        }
        public void RemoveHall (int idHall)
        {
            _hallDao.RemoveHall(idHall);
        }
    }
}
