using System.Collections.Generic;
using Entities;
using Gym.DAL;
using Gym.DAL.Interfaces;
using Gym.BLL.Interfaces;
namespace Gym.BLL
{
    public class UserLogic: IUserLogic
    {
        private IUserDao userDao;
        public UserLogic()
        {
            userDao = new UserDaoDB();
        }
        public void RegisterUser (User user)
        {
            userDao.RegisterUser(user);
        }
        public IEnumerable <User> GetNeedUsers(string login, int  passwordHashCode)
        {
            return userDao.GetNeedUsers(login, passwordHashCode);
        }
        public void UpdateFirstName(int idUser, string nextName)
        {
            userDao.UpdateFirstName(idUser, nextName);
        }
        public void UpdateLastName (int idUser, string nextName)
        {
            userDao.UpdateLastName(idUser, nextName);
        }
        public void UpdateTelephoneNumber (int idUser, string nextNumber)
        {
            userDao.UpdateTelephoneNumber(idUser, nextNumber);
        }
    }
}
