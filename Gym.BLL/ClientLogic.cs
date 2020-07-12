using System.Collections.Generic;
using Entities;
using Gym.DAL.Interfaces;
using Gym.DAL;
using Gym.BLL.Interfaces;
namespace Gym.BLL
{
    public class ClientLogic: IClientLogic
    {
        private IClientDao clientDao;
        public ClientLogic ()
        {
            clientDao = new ClientDaoDB();
        }
        public IEnumerable <Client> GetClients()
        {
            return clientDao.GetClients();
        }
        public IEnumerable <Client> GetNeedClients(int idClient)
        {
            return clientDao.GetNeedClients(idClient);
        }
        public void AddClient(Client client)
        {
            clientDao.AddClient(client);
        }
        public void RemoveClient(int idClient)
        {
            clientDao.RemoveClient(idClient);
        }
    }
}
