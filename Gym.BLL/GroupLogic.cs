using System.Collections.Generic;
using Entities;
using Gym.DAL;
using Gym.DAL.Interfaces;
using Gym.BLL.Interfaces;
namespace Gym.BLL
{
    public class GroupLogic:IGroupLogic
    {
        private IGroupDao groupDao;
        public GroupLogic()
        {
            groupDao = new GroupDaoDB();
        }
        public IEnumerable <Group> GetGroups()
        {
            return groupDao.GetGroups();
        }
        public IEnumerable <Group> GetNeedGroups(int idGroup)
        {
            return groupDao.GetNeedGroups(idGroup);
        }
        public IEnumerable <Group> GetNeedGroups (string name)
        {
            return groupDao.GetNeedGroups(name);
        }
        public IEnumerable<int> SelectDeletedGroup (string name)
        {
            return groupDao.GetDeletedGroups(name);
        }
        public IEnumerable<int> GetNeedClientByGroup(string nameGroup, int idClient)
        {
            return groupDao.GetNeedClientByGroup(idClient, nameGroup);
        }
        public void AddGroup (Group group)
        {
            groupDao.AddGroup(group);
        }
        public void AddClientByGroup(string name, int idCoach)
        {
            groupDao.AddClientByGroup(name, idCoach);
        }
        public void RemoveGroup (int idGroup)
        {
            groupDao.RemoveGroup(idGroup);
        }
    }
}
