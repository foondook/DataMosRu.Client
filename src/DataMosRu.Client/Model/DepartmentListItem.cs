using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataMosRu.Client
{
    public partial class DepartmentListItem
    {
        /// <summary>Идентификтор департамента</summary>
        [JsonProperty("Id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>Наименование департамента</summary>
        [JsonProperty("Name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Описание департамента</summary>
        [JsonProperty("Description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>ССылка на официальный сайт департамента</summary>
        [JsonProperty("WebsiteUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string WebsiteUrl { get; set; }

        /// <summary>Сокращённое наименование департамента</summary>
        [JsonProperty("ShortName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ShortName { get; set; }

        /// <summary>Англоязычное наименование</summary>
        [JsonProperty("EnglishName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EnglishName { get; set; }

        /// <summary>Англоязычное описание</summary>
        [JsonProperty("EnglishDescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EnglishDescription { get; set; }

        /// <summary>ИНН</summary>
        [JsonProperty("INN", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string INN { get; set; }

        /// <summary>Список идентификаторов наборов данных, размещённых департаментом</summary>
        [JsonProperty("Datasets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int> Datasets { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static DepartmentListItem FromJson(string data)
        {
            return JsonConvert.DeserializeObject<DepartmentListItem>(data);
        }

    }
}