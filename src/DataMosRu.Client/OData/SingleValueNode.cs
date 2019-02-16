using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DataMosRu.Client
{
    public partial class SingleValueNode
    {
        [JsonProperty("TypeReference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEdmTypeReference TypeReference { get; set; }

        [JsonProperty("Kind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public SingleValueNodeKind? Kind { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static SingleValueNode FromJson(string data)
        {
            return JsonConvert.DeserializeObject<SingleValueNode>(data);
        }

    }
}