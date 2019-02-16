using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class SelectExpandQueryOption
    {
        [JsonProperty("Context", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ODataQueryContext Context { get; set; }

        [JsonProperty("RawSelect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RawSelect { get; set; }

        [JsonProperty("RawExpand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RawExpand { get; set; }

        [JsonProperty("Validator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object Validator { get; set; }

        [JsonProperty("SelectExpandClause", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SelectExpandClause SelectExpandClause { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static SelectExpandQueryOption FromJson(string data)
        {
            return JsonConvert.DeserializeObject<SelectExpandQueryOption>(data);
        }

    }
}