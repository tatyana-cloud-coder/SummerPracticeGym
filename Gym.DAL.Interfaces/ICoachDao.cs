using System.Collections.Generic;
using Entities;
namespace Gym.DAL.Interfaces
{
    public interface ICoachDao
    {
        IEnumerable<Coach> GetCoaches();
        string GetFirstNameNeedCoach(int idCoach);
        string GetLastNameNeedCoach(int idCoach);
        IEnumerable<int> SelectIdNeedCoach(string firstName, string lastName);
        IEnumerable<int> GetSportsByCoach(int idCoach);
        IEnumerable<string> GetNamesOfSportsByCoach(int idOfKind);
        IEnumerable<int> GetNeedNote(string nameGroup, int idCoach);
        int CountOfPeople(int idCoach, int day);
        void AddCoach(Coach coach);
        void AddSportByCoach(int idCoach, string nameOfKind);
        void AddGroupByCoach(int idCoach, string nameGroup);
        void RemoveCoach(int idCoach);
    } 
}
