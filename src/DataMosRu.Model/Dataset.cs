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

        [JsonProperty("IdentificationNumber")]
        public string IdentificationNumber { get; set; }

        [JsonProperty("CategoryId")]
        public long CategoryId { get; set; }

        [JsonProperty("CategoryCaption")]
        public string CategoryCaption { get; set; }

        [JsonProperty("DepartmentId")]
        public long DepartmentId { get; set; }

        [JsonProperty("DepartmentCaption")]
        public string DepartmentCaption { get; set; }

        [JsonProperty("Caption")]
        public string Caption { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("FullDescription")]
        public string FullDescription { get; set; }

        [JsonProperty("Keywords")]
        public string Keywords { get; set; }

        [JsonProperty("ContainsGeodata")]
        public bool ContainsGeodata { get; set; }

        [JsonProperty("VersionNumber")]
        public string VersionNumber { get; set; }

        [JsonProperty("VersionDate")]
        public string VersionDate { get; set; }

        [JsonProperty("ItemsCount")]
        public long ItemsCount { get; set; }

        [JsonProperty("Columns")]
        public List<Column> Columns { get; set; }
    }

    public partial class Column
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Caption")]
        public string Caption { get; set; }

        [JsonProperty("Visible")]
        public bool Visible { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("SubColumns")]
        public List<Column> SubColumns { get; set; }
    }

    public partial class Dataset
    {
        public static Dataset FromJson(string json) => JsonConvert.DeserializeObject<Dataset>(json, DataMosRu.Model.Converter.Settings);
        
        public override string ToString() 
        {
            return Serialize.ToJson(this);
        }
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
