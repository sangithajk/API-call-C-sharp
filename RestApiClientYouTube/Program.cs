using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestApiClientYouTube
{
    class Program
    {
        HttpClient client = new HttpClient();

        static  async Task Main(string[] args)
        {
            Program obj = new Program();
            await obj.GetTodoItems();
        }
        private async Task GetTodoItems()
        {
            string response = await client.GetStringAsync(
                "https://jsonplaceholder.typicode.com/todos");
            Console.WriteLine(response);
        }

    }
}
