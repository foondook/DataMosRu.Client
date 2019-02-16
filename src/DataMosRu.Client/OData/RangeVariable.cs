using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class RangeVariable
    {
        [JsonProperty("Name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("TypeReference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEdmTypeReference TypeReference { get; set; }

        [JsonProperty("Kind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kind { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static RangeVariable FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RangeVariable>(data);
        }

    }
}