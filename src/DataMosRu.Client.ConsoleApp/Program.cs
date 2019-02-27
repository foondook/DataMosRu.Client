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
            var api = new ApiClient(apiKey, new HttpClient());

            var item = await api.Datasets.GetItemAsync(493, System.Threading.CancellationToken.None,
                d => new {
                    d.Id,
                    d.Caption,
                    d.Columns
                });

            var result = await api.Datasets.GetListAsync(
                    foreign: false,
                    filter: null,
                    orderby: null,
                    top: 5,
                    skip: 0,
                    inlinecount: "allpages",
                    cancellationToken: System.Threading.CancellationToken.None);

            foreach (var dataset in result.Items)
            {
                Console.WriteLine($"Id: {dataset.Id}, Caption: {dataset.Caption}");
            }

            Console.Read();
        }
    }
}
