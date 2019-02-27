using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class ExampleRowItem
    {
        /// <summary>Идентификатор строки</summary>
        [JsonProperty("Id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.Guid? Id { get; set; }

        /// <summary>Глобальный идентификатор объекта</summary>
        [JsonProperty("global_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Global_id { get; set; }

        /// <summary>Номер строки</summary>
        [JsonProperty("Number", Required = Required.Always)]
        public long Number { get; set; }

        /// <summary>Значения строки по столбцам специфкации</summary>
        [JsonProperty("Cells", Required = Required.Always)]
        public object Cells { get; set; } = new object();

        /// <summary>Координаты долготы</summary>
        [JsonProperty("Lat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Lat { get; set; }

        /// <summary>Координаты широты</summary>
        [JsonProperty("Lon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Lon { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static ExampleRowItem FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ExampleRowItem>(data);
        }

    }
}