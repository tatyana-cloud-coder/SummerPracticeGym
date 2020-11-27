using System.Collections.Generic;
using Entities;
using Gym.DAL;
using Gym.DAL.Interfaces;
using Gym.BLL.Interfaces;
namespace Gym.BLL
{
    public class UserLogic: IUserLogic
    {
        private IUserDao _userDao;
        public UserLogic(IUserDao userDao)
        {
            _userDao = new UserDaoDB();
        }
        public void RegisterUser (User user)
        {
            _userDao.RegisterUser(user);
        }
        public IEnumerable <User> GetNeedUsers(string login, int  passwordHashCode)
        {
            return _userDao.GetNeedUsers(login, passwordHashCode);
        }
        public void UpdateFirstName(int idUser, string nextName)
        {
            _userDao.UpdateFirstName(idUser, nextName);
        }
        public void UpdateLastName (int idUser, string nextName)
        {
            _userDao.UpdateLastName(idUser, nextName);
        }
        public void UpdateTelephoneNumber (int idUser, string nextNumber)
        {
            _userDao.UpdateTelephoneNumber(idUser, nextNumber);
        }
    }
}
