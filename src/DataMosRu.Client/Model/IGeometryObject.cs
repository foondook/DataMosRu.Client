using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DataMosRu.Client
{
    public partial class IGeometryObject
    {
        [JsonProperty("Type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public IGeometryObjectType? Type { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static IGeometryObject FromJson(string data)
        {
            return JsonConvert.DeserializeObject<IGeometryObject>(data);
        }

    }
}