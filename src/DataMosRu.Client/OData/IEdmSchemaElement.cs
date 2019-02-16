using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DataMosRu.Client
{
    public partial class IEdmSchemaElement
    {
        [JsonProperty("SchemaElementKind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public IEdmSchemaElementSchemaElementKind? SchemaElementKind { get; set; }

        [JsonProperty("Namespace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        [JsonProperty("Name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static IEdmSchemaElement FromJson(string data)
        {
            return JsonConvert.DeserializeObject<IEdmSchemaElement>(data);
        }

    }
}