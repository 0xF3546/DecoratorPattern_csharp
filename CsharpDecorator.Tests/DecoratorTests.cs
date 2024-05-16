namespace CsharpDecorator.Tests
{
    [TestFixture]
    internal class DecoratorTests
    {
        [Test]
        public void RequestHandler_ProcessRequest_Test()
        {
            var handler = new LoginHandler();
            var expectedOutput = "RequestHandler: Test Request";

            using (StringWriter sw = new())
            {
                Console.SetOut(sw);
                handler.ProcessRequest("Test Request");
                string actualOutput = sw.ToString().Trim();

                Assert.That(actualOutput, Is.EqualTo(expectedOutput));
            }
        }

        [Test]
        public void FirewallDecorator_ProcessRequest_Test()
        {
            var handler = new LoginHandler();
            var loggingDecorator = new LoggingDecorator(handler);
            var expectedOutput = "Logging: Log request - Test Request\r\nFirewall: Test Request\r\nRequestHandler: Test Request";

            using (StringWriter sw = new())
            {
                Console.SetOut(sw);
                loggingDecorator.ProcessRequest("Test Request");
                string actualOutput = sw.ToString().Trim();

                Assert.That(actualOutput, Is.EqualTo(expectedOutput));
            }
        }
    }
}
