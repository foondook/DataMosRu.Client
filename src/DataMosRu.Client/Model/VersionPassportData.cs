using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class VersionPassportData
    {
        [JsonProperty("VersionNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? VersionNumber { get; set; }

        [JsonProperty("ReleaseNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseNumber { get; set; }

        [JsonProperty("Source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        [JsonProperty("Created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        [JsonProperty("Provenance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Provenance { get; set; }

        [JsonProperty("Valid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Valid { get; set; }

        [JsonProperty("Structure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Structure { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static VersionPassportData FromJson(string data)
        {
            return JsonConvert.DeserializeObject<VersionPassportData>(data);
        }

    }
}