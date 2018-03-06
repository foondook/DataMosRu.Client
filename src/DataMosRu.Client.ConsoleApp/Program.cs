using System;
using System.Net.Http;
using System.Threading.Tasks;
using DataMosRu.Client;
using DataMosRu.Model;
using Refit;

namespace DataMosRu.Client.ConsoleApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            // hardcoded just for testing purposes - random account registered
            var apiKey = "09de26506b0052eda4972a13ca34829b";
            var client = DataMosRu.Client(apiKey);

            // var v = await client.GetVersion();
            // Console.WriteLine($"Current version: {v}");

            var datasets = await client.GetDatasets(top: 3);
            foreach (var dataset in datasets)
            {
               Console.WriteLine($"Dataset {dataset.Id} : {dataset.Caption}");
            }

            // var classifiers = await client.GetClassifiers();
            // foreach (var classifier in classifiers)
            // {
            //    Console.WriteLine($"Classifier {classifier.Id} : {classifier.Caption}");
            // }

            var d = await client.GetDataset(658);
            //Console.WriteLine(d.ToJson());

            Console.Read();
        }
    }
}
