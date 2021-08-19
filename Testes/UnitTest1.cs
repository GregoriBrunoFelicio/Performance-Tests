using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Testes
{
    public class Testes : IAsyncLifetime
    {
        private string result = "";

        private Teste teste;


        public async Task InitializeAsync()
        {
            teste = new Teste();
            result = await teste.Foo();
        }


        [Fact]
        public void Test1()
        {
            Assert.NotEmpty(result);
        }


        [Fact]
        public void Test2()
        {
            Assert.NotEmpty(result);
        }



        public Task DisposeAsync()
        {
            return Task.CompletedTask;
        }
    }

    public class Teste
    {
        public async Task<string> Foo()
        {
            var _httpClient = new HttpClient();
            var stringData = await _httpClient.GetStringAsync("https://www.twitch.tv/mariobondo");
            return stringData;
        }
    }
}
