using Xunit;
using MyDotNetApp;

namespace MyDotNetApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void SayHello_ReturnsCorrectMessage()
        {
            var message = Greeter.SayHello();
            Assert.Equal("Hello from Sourav Dutta!", message);
        }
        
    }
}
