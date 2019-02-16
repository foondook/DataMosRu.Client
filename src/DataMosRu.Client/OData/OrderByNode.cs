using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DataMosRu.Client
{
    public partial class OrderByNode
    {
        [JsonProperty("Direction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderByNodeDirection? Direction { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static OrderByNode FromJson(string data)
        {
            return JsonConvert.DeserializeObject<OrderByNode>(data);
        }

    }
}