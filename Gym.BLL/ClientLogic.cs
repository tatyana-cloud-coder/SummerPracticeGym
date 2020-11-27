using System.Collections.Generic;
using Entities;
using Gym.DAL.Interfaces;
using Gym.DAL;
using Gym.BLL.Interfaces;
namespace Gym.BLL
{
    public class ClientLogic: IClientLogic
    {
        private IClientDao _clientDao;
        public ClientLogic (IClientDao clientDao)
        {
            _clientDao = clientDao;
        }
        public IEnumerable <Client> GetClients()
        {
            return _clientDao.GetClients();
        }
        public IEnumerable <Client> GetNeedClients(int idClient)
        {
            return _clientDao.GetNeedClients(idClient);
        }
        public void AddClient(Client client)
        {
            _clientDao.AddClient(client);
        }
        public void RemoveClient(int idClient)
        {
            _clientDao.RemoveClient(idClient);
        }
    }
}
