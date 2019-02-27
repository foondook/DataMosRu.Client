using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class VersionInfo
    {
        /// <summary>Номер актуальной версии Api</summary>
        [JsonProperty("Version", Required = Required.Always)]
        public int Version { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static VersionInfo FromJson(string data)
        {
            return JsonConvert.DeserializeObject<VersionInfo>(data);
        }

    }
}