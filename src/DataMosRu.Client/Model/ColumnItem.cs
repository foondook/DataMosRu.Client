using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataMosRu.Client
{
    public partial class ColumnItem
    {
        /// <summary>Наименование поля</summary>
        [JsonProperty("Name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Заголоовк поля</summary>
        [JsonProperty("Caption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Caption { get; set; }

        /// <summary>Видимость</summary>
        [JsonProperty("Visible", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }

        /// <summary>Тип данных</summary>
        [JsonProperty("Type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>Дочерние поля</summary>
        [JsonProperty("SubColumns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ColumnItem> SubColumns { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static ColumnItem FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ColumnItem>(data);
        }

    }
}