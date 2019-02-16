using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DataMosRu.Client
{
    public partial class IEdmTerm
    {
        [JsonProperty("TermKind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public IEdmTermTermKind? TermKind { get; set; }

        [JsonProperty("SchemaElementKind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public IEdmTermSchemaElementKind? SchemaElementKind { get; set; }

        [JsonProperty("Namespace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        [JsonProperty("Name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static IEdmTerm FromJson(string data)
        {
            return JsonConvert.DeserializeObject<IEdmTerm>(data);
        }

    }
}