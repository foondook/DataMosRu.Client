using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataMosRu.Client
{
    public partial class SelectExpandClause
    {
        [JsonProperty("SelectedItems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object> SelectedItems { get; set; }

        [JsonProperty("AllSelected", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllSelected { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static SelectExpandClause FromJson(string data)
        {
            return JsonConvert.DeserializeObject<SelectExpandClause>(data);
        }

    }
}