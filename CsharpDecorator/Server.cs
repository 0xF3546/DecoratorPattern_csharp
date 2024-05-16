using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDecorator
{
    internal class Server
    {
        public List<Client> connectedClients = new();

        public int MemorieInuse = 0;
        public Server()
        {

        }

        public void AddClient(Client client)
        {
            Console.WriteLine("Added Client to Server");
            connectedClients.Add(client);
        }

        public void RemoveClient(Client client)
        {
            connectedClients.Remove(client);
        }
    }
}
