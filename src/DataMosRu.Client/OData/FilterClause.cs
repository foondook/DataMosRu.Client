using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class FilterClause
    {
        [JsonProperty("Expression", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SingleValueNode Expression { get; set; }

        [JsonProperty("RangeVariable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RangeVariable RangeVariable { get; set; }

        [JsonProperty("ItemType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEdmTypeReference ItemType { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static FilterClause FromJson(string data)
        {
            return JsonConvert.DeserializeObject<FilterClause>(data);
        }

    }
}