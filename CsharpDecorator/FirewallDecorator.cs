namespace CsharpDecorator
{
    public abstract class FirewallDecorator : IFirewall
    {
        protected IFirewall firewall;
        public FirewallDecorator(IFirewall firewall)
        {
            this.firewall = firewall;
        }
        public virtual void ProcessRequest(string request)
        {
            Console.WriteLine("Firewall: " + request);
            firewall.ProcessRequest(request);
        }
    }
}
