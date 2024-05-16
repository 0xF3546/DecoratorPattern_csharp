using CsharpDecorator;

IFirewall firewall = new LoginHandler();

firewall = new LoggingDecorator(firewall);

firewall.ProcessRequest("XY234");
firewall.ProcessRequest("FX234");