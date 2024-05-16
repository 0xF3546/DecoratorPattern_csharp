namespace CsharpDecorator
{
    public class LoggingDecorator : FirewallDecorator
    {
        public LoggingDecorator(IFirewall firewall) : base(firewall)
        {
        }

        public override void ProcessRequest(string request)
        {
            Console.WriteLine("Logging: Log request - " + request);
            base.ProcessRequest(request);
        }
    }
}
