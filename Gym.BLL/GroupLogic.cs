using System.Collections.Generic;
using Entities;
using Gym.DAL;
using Gym.DAL.Interfaces;
using Gym.BLL.Interfaces;
namespace Gym.BLL
{
    public class GroupLogic:IGroupLogic
    {
        private IGroupDao _groupDao;
        public GroupLogic(IGroupDao groupDao)
        {
            _groupDao = groupDao;
        }
        public IEnumerable <Group> GetGroups()
        {
            return _groupDao.GetGroups();
        }
        public IEnumerable <Group> GetNeedGroups(int idGroup)
        {
            return _groupDao.GetNeedGroups(idGroup);
        }
        public IEnumerable <Group> GetNeedGroups (string name)
        {
            return _groupDao.GetNeedGroups(name);
        }
        public IEnumerable<int> SelectDeletedGroup (string name)
        {
            return _groupDao.GetDeletedGroups(name);
        }
        public IEnumerable<int> GetNeedClientByGroup(string nameGroup, int idClient)
        {
            return _groupDao.GetNeedClientByGroup(idClient, nameGroup);
        }
        public void AddGroup (Group group)
        {
            _groupDao.AddGroup(group);
        }
        public void AddClientByGroup(string name, int idCoach)
        {
            _groupDao.AddClientByGroup(name, idCoach);
        }
        public void RemoveGroup (int idGroup)
        {
            _groupDao.RemoveGroup(idGroup);
        }
    }
}
