using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class FilterQueryOption
    {
        [JsonProperty("Context", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ODataQueryContext Context { get; set; }

        [JsonProperty("Validator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object Validator { get; set; }

        [JsonProperty("FilterClause", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FilterClause FilterClause { get; set; }

        [JsonProperty("RawValue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RawValue { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static FilterQueryOption FromJson(string data)
        {
            return JsonConvert.DeserializeObject<FilterQueryOption>(data);
        }

    }
}