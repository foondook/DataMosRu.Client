using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class IEdmTypeReference
    {
        [JsonProperty("IsNullable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNullable { get; set; }

        [JsonProperty("Definition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEdmType Definition { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static IEdmTypeReference FromJson(string data)
        {
            return JsonConvert.DeserializeObject<IEdmTypeReference>(data);
        }

    }
}