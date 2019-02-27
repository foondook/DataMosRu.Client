using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class AppListItem
    {
        /// <summary>Идентификатор приложения</summary>
        [JsonProperty("Id", Required = Required.Always)]
        public int Id { get; set; }

        /// <summary>Наименование приложения</summary>
        [JsonProperty("Caption", Required = Required.Always)]

        public string Caption { get; set; }

        /// <summary>Описание приложения</summary>
        [JsonProperty("Description", Required = Required.Always)]

        public string Description { get; set; }

        /// <summary>Идентификатор категории</summary>
        [JsonProperty("CategoryId", Required = Required.Always)]
        public int CategoryId { get; set; }

        /// <summary>Дата размещения на портале</summary>
        [JsonProperty("PublishDate", Required = Required.Always)]

        public string PublishDate { get; set; }

        /// <summary>Разработчик приложения</summary>
        [JsonProperty("Developer", Required = Required.Always)]

        public string Developer { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static AppListItem FromJson(string data)
        {
            return JsonConvert.DeserializeObject<AppListItem>(data);
        }

    }
}