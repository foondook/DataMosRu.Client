using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DataMosRu.Client
{
    public partial class InlineCountQueryOption
    {
        [JsonProperty("Context", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ODataQueryContext Context { get; set; }

        [JsonProperty("RawValue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RawValue { get; set; }

        [JsonProperty("Value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public InlineCountQueryOptionValue? Value { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static InlineCountQueryOption FromJson(string data)
        {
            return JsonConvert.DeserializeObject<InlineCountQueryOption>(data);
        }

    }
}