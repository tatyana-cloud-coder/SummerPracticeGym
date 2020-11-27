using System;
using System.Collections.Generic;
using Entities;
using Gym.DAL.Interfaces;
using Gym.BLL.Interfaces;
using System.Linq;
namespace Gym.BLL
{
    public class CoachLogic: ICoachLogic
    {
        private ICoachDao _coachDao;
        public CoachLogic (ICoachDao coachDao)
        {
            _coachDao = coachDao;
        }
        public IEnumerable <Coach> GetCoaches()
        {
            return _coachDao.GetCoaches();
        }
        public string GetFirstNameNeedCoach(int idCoach)
        {
            return _coachDao.GetFirstNameNeedCoach(idCoach); 
        }
        public string GetLastNameNeedCoach(int idCoach)
        {
            return _coachDao.GetLastNameNeedCoach(idCoach);
        }
        public string SelectIdNeedCoach(string firstName, string lastName)
        {
            var result = _coachDao.SelectIdNeedCoach(firstName, lastName).ToList() ;
            if (result.Any())
            {
                return result.FirstOrDefault().ToString();
            } else
            {
                return null;
            }
        }
        public IEnumerable <int> GetSportsByCoach (int idCoach)
        {
            return _coachDao.GetSportsByCoach(idCoach);
        }
        public IEnumerable<string> GetNamesOfSportsByCoach(int idOfKind)
        {
            return _coachDao.GetNamesOfSportsByCoach(idOfKind);
        }
        public IEnumerable<int> GetNeedNote(string nameGroup, int idCoach)
        {
            return _coachDao.GetNeedNote(nameGroup, idCoach);
        }
        public int CountOfPeople(int idCoach, int day)
        {
            return _coachDao.CountOfPeople(idCoach, day);
        }
        public void AddCoach(Coach coach)
        {
            _coachDao.AddCoach(coach);
        }
        public void AddSportByCoach(int idCoach, string nameOfKind)
        {
            _coachDao.AddSportByCoach(idCoach, nameOfKind);
        }
        public void AddGroupByCoach(int idCoach, string nameGroup)
        {
            _coachDao.AddGroupByCoach(idCoach, nameGroup);
        }
        public void RemoveCoach (int idCoach)
        {
            _coachDao.RemoveCoach(idCoach);
        }
        public IEnumerable <Coach> SearchCoach (string firstName)
        {
            if (String.IsNullOrEmpty(firstName)) { return GetCoaches();  }
            var result = new List<Coach>();
            foreach (var item in GetCoaches())
            {
                if (item.FirstName.Contains(firstName))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
