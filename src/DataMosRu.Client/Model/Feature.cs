using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataMosRu.Client
{
    public partial class Feature
    {
        [JsonProperty("geometry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IGeometryObject Geometry { get; set; }

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("properties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> Properties { get; set; }

        [JsonProperty("bbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<double> Bbox { get; set; }

        [JsonProperty("crs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICRSObject Crs { get; set; }

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FeatureType? Type { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Feature FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Feature>(data);
        }

    }
}