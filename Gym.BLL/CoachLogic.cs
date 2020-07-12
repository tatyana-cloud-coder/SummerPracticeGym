using System;
using System.Collections.Generic;
using Entities;
using Gym.DAL;
using Gym.DAL.Interfaces;
using Gym.BLL.Interfaces;
namespace Gym.BLL
{
    public class CoachLogic: ICoachLogic
    {
        private ICoachDao coachDao;
        public CoachLogic ()
        {
            coachDao = new CoachDaoDB();
        }
        public IEnumerable <Coach> GetCoaches()
        {
            return coachDao.GetCoaches();
        }
        public string GetFirstNameNeedCoach(int idCoach)
        {
            return coachDao.GetFirstNameNeedCoach(idCoach); 
        }
        public string GetLastNameNeedCoach(int idCoach)
        {
            return coachDao.GetLastNameNeedCoach(idCoach);
        }
        public int SelectIdNeedCoach(string firstName, string lastName)
        {
            return coachDao.SelectIdNeedCoach(firstName, lastName);
        }
        public IEnumerable <int> GetSportsByCoach (int idCoach)
        {
            return coachDao.GetSportsByCoach(idCoach);
        }
        public IEnumerable<string> GetNamesOfSportsByCoach(int idOfKind)
        {
            return coachDao.GetNamesOfSportsByCoach(idOfKind);
        }
        public IEnumerable<int> GetNeedNote(string nameGroup, int idCoach)
        {
            return coachDao.GetNeedNote(nameGroup, idCoach);
        }
        public int CountOfPeople(int idCoach, int day)
        {
            return coachDao.CountOfPeople(idCoach, day);
        }
        public void AddCoach(Coach coach)
        {
            coachDao.AddCoach(coach);
        }
        public void AddSportByCoach(int idCoach, string nameOfKind)
        {
            coachDao.AddSportByCoach(idCoach, nameOfKind);
        }
        public void AddGroupByCoach(int idCoach, string nameGroup)
        {
            coachDao.AddGroupByCoach(idCoach, nameGroup);
        }
        public void RemoveCoach (int idCoach)
        {
            coachDao.RemoveCoach(idCoach);
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
