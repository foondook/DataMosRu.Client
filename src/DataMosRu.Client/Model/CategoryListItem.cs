using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataMosRu.Client
{
    public partial class CategoryListItem
    {
        /// <summary>Идентификатор категории</summary>
        [JsonProperty("Id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>Наименование категории</summary>
        [JsonProperty("Name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Англоязычное наименование категории</summary>
        [JsonProperty("EnglishName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EnglishName { get; set; }

        /// <summary>Описание категории</summary>
        [JsonProperty("Description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>Англоязычное описание категории</summary>
        [JsonProperty("EnglishDescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EnglishDescription { get; set; }

        /// <summary>Список идентификаторов наборов данных, относящихся к данной категории</summary>
        [JsonProperty("Datasets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int> Datasets { get; set; }

        /// <summary>Список сервисов, относящихся к данной категории</summary>
        [JsonProperty("Services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int> Services { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static CategoryListItem FromJson(string data)
        {
            return JsonConvert.DeserializeObject<CategoryListItem>(data);
        }

    }
}