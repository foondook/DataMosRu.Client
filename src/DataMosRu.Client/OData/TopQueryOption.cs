using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class TopQueryOption
    {
        [JsonProperty("Context", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ODataQueryContext Context { get; set; }

        [JsonProperty("RawValue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RawValue { get; set; }

        [JsonProperty("Value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value { get; set; }

        [JsonProperty("Validator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object Validator { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static TopQueryOption FromJson(string data)
        {
            return JsonConvert.DeserializeObject<TopQueryOption>(data);
        }

    }
}