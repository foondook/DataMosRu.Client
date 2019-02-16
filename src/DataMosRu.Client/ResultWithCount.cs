using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace DataMosRu.Client
{
    public class ResultWithCount<T> where T : class
    {
        [JsonProperty("Items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<T> Items { get; set; }

        [JsonProperty("Count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static IQueryable<ResultWithCount<T>> FromJson(string data)
        {
            return JsonConvert.DeserializeObject<IQueryable<ResultWithCount<T>>>(data);
        }
    }
}