using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class ODataQueryContext
    {
        [JsonProperty("Model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEdmModel Model { get; set; }

        [JsonProperty("ElementType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEdmType ElementType { get; set; }

        [JsonProperty("ElementClrType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ElementClrType { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static ODataQueryContext FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ODataQueryContext>(data);
        }

    }
}