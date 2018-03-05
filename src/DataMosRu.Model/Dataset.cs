// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using DataMosRu.Model;
//
//    var dataset = Dataset.FromJson(jsonString);

namespace DataMosRu.Model
{
    using System;
    using System.Collections.Generic;
    using System.Net;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Dataset
    {
        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("VersionNumber")]
        public long VersionNumber { get; set; }

        [JsonProperty("ReleaseNumber")]
        public long ReleaseNumber { get; set; }

        [JsonProperty("Caption")]
        public string Caption { get; set; }

        [JsonProperty("CategoryId")]
        public long CategoryId { get; set; }

        [JsonProperty("DepartmentId")]
        public long DepartmentId { get; set; }

        [JsonProperty("PublishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("FullDescription")]
        public string FullDescription { get; set; }

        [JsonProperty("Keywords")]
        public string Keywords { get; set; }

        [JsonProperty("ContainsGeodata")]
        public bool ContainsGeodata { get; set; }

        [JsonProperty("ContainsAccEnvData")]
        public bool ContainsAccEnvData { get; set; }

        [JsonProperty("IsForeign")]
        public bool IsForeign { get; set; }

        [JsonProperty("IsSeasonal")]
        public bool IsSeasonal { get; set; }

        [JsonProperty("Season")]
        public string Season { get; set; }

        [JsonProperty("IsArchive")]
        public bool IsArchive { get; set; }

        [JsonProperty("IsNew")]
        public bool IsNew { get; set; }

        [JsonProperty("LastUpdateDate")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("SefUrl")]
        public string SefUrl { get; set; }

        [JsonProperty("IdentificationNumber")]
        public string IdentificationNumber { get; set; }
    }

    public partial class Dataset
    {
        public static Dataset FromJson(string json) => JsonConvert.DeserializeObject<Dataset>(json, DataMosRu.Model.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Dataset self) => JsonConvert.SerializeObject(self, DataMosRu.Model.Converter.Settings);
    }

    internal class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = { 
                new IsoDateTimeConverter()
                {
                    DateTimeStyles = DateTimeStyles.AssumeUniversal,
                },
            },
        };
    }
}
