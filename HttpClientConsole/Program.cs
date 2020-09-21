using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var client = new HttpClient();
            var content = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");

            Console.WriteLine(content);
        }
    }
}
