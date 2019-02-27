using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class DatasetListItem
    {
        /// <summary>Идентификатор</summary>
        [JsonProperty("Id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>Номер актуальной версии</summary>
        [JsonProperty("VersionNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? VersionNumber { get; set; }

        /// <summary>Номер актуального релиза</summary>
        [JsonProperty("ReleaseNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseNumber { get; set; }

        /// <summary>Наименование</summary>
        [JsonProperty("Caption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Caption { get; set; }

        /// <summary>Идентификатор категории</summary>
        [JsonProperty("CategoryId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryId { get; set; }

        /// <summary>Идентификатор департамента</summary>
        [JsonProperty("DepartmentId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DepartmentId { get; set; }

        /// <summary>Дата размещения на ОПОДе</summary>
        [JsonProperty("PublishDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PublishDate { get; set; }

        /// <summary>Описание</summary>
        [JsonProperty("FullDescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FullDescription { get; set; }

        /// <summary>Теги</summary>
        [JsonProperty("Keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keywords { get; set; }

        /// <summary>Наличие геокоординат</summary>
        [JsonProperty("ContainsGeodata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContainsGeodata { get; set; }

        /// <summary>НАличие "доступной среды"</summary>
        [JsonProperty("ContainsAccEnvData", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContainsAccEnvData { get; set; }

        /// <summary>Флаг англоязычности</summary>
        [JsonProperty("IsForeign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsForeign { get; set; }

        /// <summary>Флаг сезонности</summary>
        [JsonProperty("IsSeasonal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSeasonal { get; set; }

        /// <summary>Сезонность набора</summary>
        [JsonProperty("Season", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Season { get; set; }

        /// <summary>Архивность набора</summary>
        [JsonProperty("IsArchive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsArchive { get; set; }

        /// <summary>Размещение на портале произведено менее 7 дней</summary>
        [JsonProperty("IsNew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNew { get; set; }

        /// <summary>Дата последнего обновления</summary>
        [JsonProperty("LastUpdateDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateDate { get; set; }

        /// <summary>SEF-ссылка</summary>
        [JsonProperty("SefUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SefUrl { get; set; }

        /// <summary>Идентификационный номер</summary>
        [JsonProperty("IdentificationNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IdentificationNumber { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static DatasetListItem FromJson(string data)
        {
            return JsonConvert.DeserializeObject<DatasetListItem>(data);
        }

    }
}