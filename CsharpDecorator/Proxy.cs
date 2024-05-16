namespace CsharpDecorator
{
    public class Proxy : IFirewall
    {
        private readonly List<Server> servers = new();
        private static Proxy? instance = null;
        public Proxy()
        {
            Server server = new();
            server.MemorieInuse = 5000;
            servers.Add(server);
        }

        public static Proxy Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new();
                }
                return instance;
            }
        }

        public void ProcessRequest(string request)
        {
            Client client = new(request);
            foreach (Server server in servers)
            {
                if (server.MemorieInuse <= 4800)
                {
                    server.AddClient(client);
                    return;
                }
            }
            Server newServer = new();
            newServer.AddClient(client);
            servers.Add(newServer);
            ScheduleServerTimeout(newServer);
        }

        private void ScheduleServerTimeout(Server server)
        {
            Thread.Sleep(3000);
            servers.Remove(server);
            Console.WriteLine("Killed Server");
        }
    }
}
