using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataMosRu.Client
{
    public partial class DatasetPassportData
    {
        [JsonProperty("Standardversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Standardversion { get; set; }

        [JsonProperty("Id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("Identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        [JsonProperty("Title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("Description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("CategoryId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryId { get; set; }

        [JsonProperty("CategoryCaption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryCaption { get; set; }

        [JsonProperty("CreatorId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatorId { get; set; }

        [JsonProperty("Creator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        [JsonProperty("Format", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        [JsonProperty("VersionNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string VersionNumber { get; set; }

        [JsonProperty("Valid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Valid { get; set; }

        [JsonProperty("Modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Modified { get; set; }

        [JsonProperty("Provenance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Provenance { get; set; }

        [JsonProperty("ProvenanceEng", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProvenanceEng { get; set; }

        [JsonProperty("Subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> Subject { get; set; }

        [JsonProperty("Structure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Structure { get; set; }

        [JsonProperty("Publisher", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object Publisher { get; set; }

        [JsonProperty("Created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        [JsonProperty("Data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<VersionPassportData> Data { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static DatasetPassportData FromJson(string data)
        {
            return JsonConvert.DeserializeObject<DatasetPassportData>(data);
        }

    }
}