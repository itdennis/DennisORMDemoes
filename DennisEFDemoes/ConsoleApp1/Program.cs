using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static void Main(string[] args)
        {

            var now = DateTimeOffset.UtcNow;

            new Program().Run();
        }

        public async void Run()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:65361/api/SystemInfoes");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
