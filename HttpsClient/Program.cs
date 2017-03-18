using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HttpsClient
{
    class Program
    {
        static void Main()
        {
            var t = new Task(DownloadPageAsync);
            t.Start();
            Console.WriteLine("Downloading page...");
            Console.ReadLine();
        }

        static async void DownloadPageAsync()
        {
            using (var client = new HttpClient())
            using (var response = await client.GetAsync("https://www.kandanda.ch/"))
            using (var content = response.Content)
            {
                var result = await content.ReadAsStringAsync();
                
                if (result != null)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
