using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataMosRu.Client
{
    public partial class OrderByQueryOption
    {
        [JsonProperty("Context", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ODataQueryContext Context { get; set; }

        [JsonProperty("OrderByNodes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OrderByNode> OrderByNodes { get; set; }

        [JsonProperty("RawValue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RawValue { get; set; }

        [JsonProperty("Validator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object Validator { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static OrderByQueryOption FromJson(string data)
        {
            return JsonConvert.DeserializeObject<OrderByQueryOption>(data);
        }

    }
}