using System.Collections.Generic;
using Entities;
using Gym.DAL;
using Gym.DAL.Interfaces;
using Gym.BLL.Interfaces;
namespace Gym.BLL
{
    public class KindOfSportLogic: IKindOfSportLogic
    {
        private IKindOfSportDao _kindOfSportDao;
        public KindOfSportLogic (IKindOfSportDao kindOfSportLogic)
        {
            _kindOfSportDao = kindOfSportLogic;
        }
        public IEnumerable <KindOfSport> GetKindOfSports()
        {
            return _kindOfSportDao.GetKindOfSports();
        }
        public IEnumerable <KindOfSport> GetNeedKindOfSports(int idKind)
        {
            return _kindOfSportDao.GetNeedKindOfSports(idKind);
        }
        public IEnumerable <KindOfSport> GetNeedKindOfSports (string name)
        {
            return _kindOfSportDao.GetNeedKindOfSports(name);
        }
        public IEnumerable<string> Schedule(string nameOfKind, int day)
        {
            return _kindOfSportDao.Schedule(nameOfKind, day);
        }
        public void AddKindOfSport (KindOfSport kindOfSport)
        {
            _kindOfSportDao.AddKindOfSport(kindOfSport);
        }
        public void RemoveKindOfSport (int idKindOfSport)
        {
            _kindOfSportDao.RemoveKindOfSport(idKindOfSport);
        }
    }
}
