using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class IEdmVocabularyAnnotation
    {
        [JsonProperty("Qualifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Qualifier { get; set; }

        [JsonProperty("Term", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEdmTerm Term { get; set; }

        [JsonProperty("Target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object Target { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static IEdmVocabularyAnnotation FromJson(string data)
        {
            return JsonConvert.DeserializeObject<IEdmVocabularyAnnotation>(data);
        }

    }
}