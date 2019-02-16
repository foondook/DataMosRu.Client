using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DataMosRu.Client
{
    public partial class IEdmType
    {
        [JsonProperty("TypeKind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public IEdmTypeTypeKind? TypeKind { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static IEdmType FromJson(string data)
        {
            return JsonConvert.DeserializeObject<IEdmType>(data);
        }

    }
}