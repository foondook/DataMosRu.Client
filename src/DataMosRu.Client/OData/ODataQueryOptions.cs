using Newtonsoft.Json;

namespace DataMosRu.Client
{
    public partial class ODataRawQueryOptions
    {
        [JsonProperty("Filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        [JsonProperty("OrderBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OrderBy { get; set; }

        [JsonProperty("Top", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Top { get; set; }

        [JsonProperty("Skip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Skip { get; set; }

        [JsonProperty("Select", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Select { get; set; }

        [JsonProperty("Expand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Expand { get; set; }

        [JsonProperty("InlineCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string InlineCount { get; set; }

        [JsonProperty("Format", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        [JsonProperty("SkipToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SkipToken { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static ODataRawQueryOptions FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ODataRawQueryOptions>(data);
        }

    }
    public partial class ODataQueryOptions<T> where T : class
    {
        [JsonProperty("Context", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ODataQueryContext Context { get; set; }

        [JsonProperty("Request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object Request { get; set; }

        [JsonProperty("RawValues", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ODataRawQueryOptions RawValues { get; set; }

        [JsonProperty("SelectExpand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SelectExpandQueryOption SelectExpand { get; set; }

        [JsonProperty("Filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FilterQueryOption Filter { get; set; }

        [JsonProperty("OrderBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public OrderByQueryOption OrderBy { get; set; }

        [JsonProperty("Skip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SkipQueryOption Skip { get; set; }

        [JsonProperty("Top", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TopQueryOption Top { get; set; }

        [JsonProperty("InlineCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public InlineCountQueryOption InlineCount { get; set; }

        [JsonProperty("Validator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object Validator { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static ODataQueryOptions<T> FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ODataQueryOptions<T>>(data);
        }

    }
}