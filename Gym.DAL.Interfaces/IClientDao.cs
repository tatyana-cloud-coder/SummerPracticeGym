using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Gym.DAL.Interfaces
{
    public interface IClientDao
    {
        IEnumerable<Client> GetClients();
        IEnumerable<Client> GetNeedClients(int idClient);
        void AddClient(Client client);
        void RemoveClient(int idClient);
    }
}
