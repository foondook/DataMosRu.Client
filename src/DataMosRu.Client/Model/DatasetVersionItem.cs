using Newtonsoft.Json;

namespace DataMosRu.Client
{
    /// <summary>Актуальные номера версии и релиза набора данных</summary>

    public partial class DatasetVersionItem
    {
        /// <summary>Номер актуальной версии</summary>
        [JsonProperty("versionNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? VersionNumber { get; set; }

        /// <summary>Номер актуального релиза</summary>
        [JsonProperty("releaseNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseNumber { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static DatasetVersionItem FromJson(string data)
        {
            return JsonConvert.DeserializeObject<DatasetVersionItem>(data);
        }

    }
}