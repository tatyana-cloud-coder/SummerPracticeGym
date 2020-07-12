using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Gym.DAL.Interfaces
{
    public interface IUserDao
    {
        void RegisterUser(User user);
        IEnumerable <User> GetNeedUsers(string login, int passwordHashCode);
        void UpdateFirstName(int idUser, string nextName);
        void UpdateLastName(int idUser, string nextName);
        void UpdateTelephoneNumber(int idUser, string nextNumber);
    }
}
