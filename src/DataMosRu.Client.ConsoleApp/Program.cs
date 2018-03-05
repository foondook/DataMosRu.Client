using System;
using System.Net.Http;
using System.Threading.Tasks;
using Refit;

namespace DataMosRu.Client.ConsoleApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var apiKey = "";
            var httpClient = new HttpClient();
            var client = RestService.For<IDataMosRuApi>(
                new HttpClient(new ApiKeyHttpClientHandler(apiKey))
                {
                    BaseAddress = new Uri("https://apidata.mos.ru")
                });
            var v = await client.GetVersion();
            Console.WriteLine($"Current version: {v}");

            var datasets = await client.GetDatasets();
            foreach (var dataset in datasets)
            {
               Console.WriteLine($"Dataset {dataset.Id} : {dataset.Caption}");
            }

            Console.Read();
        }
    }
}
