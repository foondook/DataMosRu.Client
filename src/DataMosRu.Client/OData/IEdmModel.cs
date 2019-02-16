using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataMosRu.Client
{
    public partial class IEdmModel
    {
        [JsonProperty("SchemaElements", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IEdmSchemaElement> SchemaElements { get; set; }

        [JsonProperty("VocabularyAnnotations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IEdmVocabularyAnnotation> VocabularyAnnotations { get; set; }

        [JsonProperty("ReferencedModels", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IEdmModel> ReferencedModels { get; set; }

        [JsonProperty("DirectValueAnnotationsManager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object DirectValueAnnotationsManager { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static IEdmModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<IEdmModel>(data);
        }

    }
}