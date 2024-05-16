namespace CsharpDecorator
{
    public class LoginHandler : IFirewall
    {
        public void ProcessRequest(string request)
        {
            Console.WriteLine(GetType().Name + ": " + request);
            Proxy.Instance.ProcessRequest(request);
        }
    }
}
