using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataMosRu.Client
{
    public partial class DatasetItem
    {
        /// <summary>Уникальный идентификатор</summary>
        [JsonProperty("Id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>Идентифифкационная строка</summary>
        [JsonProperty("IdentificationNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IdentificationNumber { get; set; }

        /// <summary>Идентификатор категории</summary>
        [JsonProperty("CategoryId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryId { get; set; }

        /// <summary>Наименование категории</summary>
        [JsonProperty("CategoryCaption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryCaption { get; set; }

        /// <summary>Идентификатор департамента</summary>
        [JsonProperty("DepartmentId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DepartmentId { get; set; }

        /// <summary>Наименование департамента</summary>
        [JsonProperty("DepartmentCaption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DepartmentCaption { get; set; }

        /// <summary>Наименование набора данных</summary>
        [JsonProperty("Caption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Caption { get; set; }

        /// <summary>Краткое описание набора данных</summary>
        [JsonProperty("Description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>Полное описание набора данных</summary>
        [JsonProperty("FullDescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FullDescription { get; set; }

        /// <summary>Теги набора</summary>
        [JsonProperty("Keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keywords { get; set; }

        /// <summary>Наличие геокоординат</summary>
        [JsonProperty("ContainsGeodata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContainsGeodata { get; set; }

        /// <summary>Номер актуальной версии</summary>
        [JsonProperty("VersionNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string VersionNumber { get; set; }

        /// <summary>Дата пубоикации версии</summary>
        [JsonProperty("VersionDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string VersionDate { get; set; }

        /// <summary>Количество записей в наборе данных</summary>
        [JsonProperty("ItemsCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>Описание структуры набора данных</summary>
        [JsonProperty("Columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ColumnItem> Columns { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static DatasetItem FromJson(string data)
        {
            return JsonConvert.DeserializeObject<DatasetItem>(data);
        }

    }
}