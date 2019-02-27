using System;
using System.Net.Http;
using System.Threading.Tasks;
using DataMosRu.Client;

namespace DataMosRu.Client.ConsoleApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            // hardcoded just for testing purposes - random account registered
            var apiKey = "09de26506b0052eda4972a13ca34829b";
            var api = new DataMosRu.Client.ApiClient();

            Console.Read();
        }
    }
}
