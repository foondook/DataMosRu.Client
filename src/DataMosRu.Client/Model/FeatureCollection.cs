using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace DataMosRu.Client
{
    public partial class FeatureCollection
    {
        [JsonProperty("features", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Feature> Features { get; set; }

        [JsonProperty("bbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<double> Bbox { get; set; }

        [JsonProperty("crs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICRSObject Crs { get; set; }

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public FeatureCollectionType? Type { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static FeatureCollection FromJson(string data)
        {
            return JsonConvert.DeserializeObject<FeatureCollection>(data);
        }

    }
}