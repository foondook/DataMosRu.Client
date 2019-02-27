using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class ICRSObject
    {
        [JsonProperty("Type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ICRSObjectType? Type { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static ICRSObject FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ICRSObject>(data);
        }

    }
}