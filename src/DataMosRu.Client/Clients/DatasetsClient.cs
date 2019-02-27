using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;

namespace DataMosRu.Client.Clients
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.0.14.0 (NJsonSchema v9.13.18.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class DatasetsClient
    {
        private string _baseUrl = "https://apidata.mos.ru";
        private string _apiKey;
        private System.Net.Http.HttpClient _httpClient;
        private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

        public DatasetsClient(string apiKey, System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;

            _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(() =>
            {
                var settings = new Newtonsoft.Json.JsonSerializerSettings();
                UpdateJsonSerializerSettings(settings);
                return settings;
            });
        }

        public string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }

        protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);

        /// <summary>Получение списка наборов данных или справочников</summary>
        /// <param name="foreign">Указание язычности наборов данных, true - возвращает англоязычные данные</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<ResultWithCount<DatasetListItem>> GetListAsync(bool? foreign, string filter, string orderby, int? top, int? skip, string inlinecount)
        {
            return GetListAsync(foreign, filter, orderby, top, skip, inlinecount, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение списка наборов данных или справочников</summary>
        /// <param name="foreign">Указание язычности наборов данных, true - возвращает англоязычные данные</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<ResultWithCount<DatasetListItem>> GetListAsync(bool? foreign, string filter, string orderby, int? top, int? skip, string inlinecount, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/datasets?");
            if (foreign != null)
            {
                urlBuilder_.Append("foreign=").Append(System.Uri.EscapeDataString(ConvertToString(foreign, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (filter != null)
            {
                urlBuilder_.Append("$filter=").Append(System.Uri.EscapeDataString(ConvertToString(filter, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (orderby != null)
            {
                urlBuilder_.Append("$orderby=").Append(System.Uri.EscapeDataString(ConvertToString(orderby, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (top != null)
            {
                urlBuilder_.Append("$top=").Append(System.Uri.EscapeDataString(ConvertToString(top, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (skip != null)
            {
                urlBuilder_.Append("$skip=").Append(System.Uri.EscapeDataString(ConvertToString(skip, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (inlinecount != null)
            {
                urlBuilder_.Append("$inlinecount=").Append(System.Uri.EscapeDataString(ConvertToString(inlinecount, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (_apiKey != null)
            {
                urlBuilder_.Append("api_key=").Append(System.Uri.EscapeDataString(ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ResultWithCount<DatasetListItem>);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultWithCount<DatasetListItem>>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(ResultWithCount<DatasetListItem>);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Получение списка наборов данных или справочников</summary>
        /// <param name="projection">Список возвращаемых полей в ответе запроса</param>
        /// <param name="foreign">Указание язычности наборов данных, true - возвращает англоязычные данные</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<ResultWithCount<DatasetListItem>> GetListPostAsync(System.Collections.Generic.IEnumerable<string> projection, bool? foreign, string filter, string orderby, int? top, int? skip, string inlinecount)
        {
            return GetListPostAsync(projection, foreign, filter, orderby, top, skip, inlinecount, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение списка наборов данных или справочников</summary>
        /// <param name="projection">Список возвращаемых полей в ответе запроса</param>
        /// <param name="foreign">Указание язычности наборов данных, true - возвращает англоязычные данные</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<ResultWithCount<DatasetListItem>> GetListPostAsync(System.Collections.Generic.IEnumerable<string> projection, bool? foreign, string filter, string orderby, int? top, int? skip, string inlinecount, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/datasets?");
            if (foreign != null)
            {
                urlBuilder_.Append("foreign=").Append(System.Uri.EscapeDataString(ConvertToString(foreign, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (filter != null)
            {
                urlBuilder_.Append("$filter=").Append(System.Uri.EscapeDataString(ConvertToString(filter, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (orderby != null)
            {
                urlBuilder_.Append("$orderby=").Append(System.Uri.EscapeDataString(ConvertToString(orderby, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (top != null)
            {
                urlBuilder_.Append("$top=").Append(System.Uri.EscapeDataString(ConvertToString(top, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (skip != null)
            {
                urlBuilder_.Append("$skip=").Append(System.Uri.EscapeDataString(ConvertToString(skip, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (inlinecount != null)
            {
                urlBuilder_.Append("$inlinecount=").Append(System.Uri.EscapeDataString(ConvertToString(inlinecount, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (_apiKey != null)
            {
                urlBuilder_.Append("api_key=").Append(System.Uri.EscapeDataString(ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(projection, _settings.Value));
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ResultWithCount<DatasetListItem>);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultWithCount<DatasetListItem>>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(ResultWithCount<DatasetListItem>);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Получение списка наборов данных или справочников</summary>
        /// <param name="foreign">Указание язычности наборов данных, true - возвращает англоязычные данные</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<ResultWithCount<DatasetListItem>> GetList2Async(bool? foreign, string filter, string orderby, int? top, int? skip, string inlinecount)
        {
            return GetList2Async(foreign, filter, orderby, top, skip, inlinecount, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение списка наборов данных или справочников</summary>
        /// <param name="foreign">Указание язычности наборов данных, true - возвращает англоязычные данные</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<ResultWithCount<DatasetListItem>> GetList2Async(bool? foreign, string filter, string orderby, int? top, int? skip, string inlinecount, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/datasets?");
            if (foreign != null)
            {
                urlBuilder_.Append("foreign=").Append(System.Uri.EscapeDataString(ConvertToString(foreign, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (filter != null)
            {
                urlBuilder_.Append("$filter=").Append(System.Uri.EscapeDataString(ConvertToString(filter, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (orderby != null)
            {
                urlBuilder_.Append("$orderby=").Append(System.Uri.EscapeDataString(ConvertToString(orderby, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (top != null)
            {
                urlBuilder_.Append("$top=").Append(System.Uri.EscapeDataString(ConvertToString(top, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (skip != null)
            {
                urlBuilder_.Append("$skip=").Append(System.Uri.EscapeDataString(ConvertToString(skip, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (inlinecount != null)
            {
                urlBuilder_.Append("$inlinecount=").Append(System.Uri.EscapeDataString(ConvertToString(inlinecount, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (_apiKey != null)
            {
                urlBuilder_.Append("api_key=").Append(System.Uri.EscapeDataString(ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ResultWithCount<DatasetListItem>);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultWithCount<DatasetListItem>>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(ResultWithCount<DatasetListItem>);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Получение списка наборов данных или справочников</summary>
        /// <param name="projection">Список возвращаемых полей в ответе запроса</param>
        /// <param name="foreign">Указание язычности наборов данных, true - возвращает англоязычные данные</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<ResultWithCount<DatasetListItem>> GetListPost2Async(System.Collections.Generic.IEnumerable<string> projection, bool? foreign, string filter, string orderby, int? top, int? skip, string inlinecount)
        {
            return GetListPost2Async(projection, foreign, filter, orderby, top, skip, inlinecount, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение списка наборов данных или справочников</summary>
        /// <param name="projection">Список возвращаемых полей в ответе запроса</param>
        /// <param name="foreign">Указание язычности наборов данных, true - возвращает англоязычные данные</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<ResultWithCount<DatasetListItem>> GetListPost2Async(System.Collections.Generic.IEnumerable<string> projection, bool? foreign, string filter, string orderby, int? top, int? skip, string inlinecount, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/datasets?");
            if (foreign != null)
            {
                urlBuilder_.Append("foreign=").Append(System.Uri.EscapeDataString(ConvertToString(foreign, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (filter != null)
            {
                urlBuilder_.Append("$filter=").Append(System.Uri.EscapeDataString(ConvertToString(filter, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (orderby != null)
            {
                urlBuilder_.Append("$orderby=").Append(System.Uri.EscapeDataString(ConvertToString(orderby, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (top != null)
            {
                urlBuilder_.Append("$top=").Append(System.Uri.EscapeDataString(ConvertToString(top, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (skip != null)
            {
                urlBuilder_.Append("$skip=").Append(System.Uri.EscapeDataString(ConvertToString(skip, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (inlinecount != null)
            {
                urlBuilder_.Append("$inlinecount=").Append(System.Uri.EscapeDataString(ConvertToString(inlinecount, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (_apiKey != null)
            {
                urlBuilder_.Append("api_key=").Append(System.Uri.EscapeDataString(ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(projection, _settings.Value));
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ResultWithCount<DatasetListItem>);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultWithCount<DatasetListItem>>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(ResultWithCount<DatasetListItem>);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Получение списка наборов данных или справочников для заданного департамента</summary>
        /// <param name="departmentId">Идентификатор департамента</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<ResultWithCount<DatasetListItem>> GetListByDepartmentAsync(int departmentId, string filter, string orderby, int? top, int? skip, string inlinecount)
        {
            return GetListByDepartmentAsync(departmentId, filter, orderby, top, skip, inlinecount, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение списка наборов данных или справочников для заданного департамента</summary>
        /// <param name="departmentId">Идентификатор департамента</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<ResultWithCount<DatasetListItem>> GetListByDepartmentAsync(int departmentId, string filter, string orderby, int? top, int? skip, string inlinecount, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/departments/{departmentId}/datasets?");
            urlBuilder_.Replace("{departmentId}", System.Uri.EscapeDataString(ConvertToString(departmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (filter != null)
            {
                urlBuilder_.Append("$filter=").Append(System.Uri.EscapeDataString(ConvertToString(filter, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (orderby != null)
            {
                urlBuilder_.Append("$orderby=").Append(System.Uri.EscapeDataString(ConvertToString(orderby, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (top != null)
            {
                urlBuilder_.Append("$top=").Append(System.Uri.EscapeDataString(ConvertToString(top, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (skip != null)
            {
                urlBuilder_.Append("$skip=").Append(System.Uri.EscapeDataString(ConvertToString(skip, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (inlinecount != null)
            {
                urlBuilder_.Append("$inlinecount=").Append(System.Uri.EscapeDataString(ConvertToString(inlinecount, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (_apiKey != null)
            {
                urlBuilder_.Append("api_key=").Append(System.Uri.EscapeDataString(ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ResultWithCount<DatasetListItem>);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultWithCount<DatasetListItem>>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(ResultWithCount<DatasetListItem>);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Получение списка наборов данных или справочников для заданного департамента</summary>
        /// <param name="departmentId">Идентификатор департамента</param>
        /// <param name="projection">Список возвращаемых полей в ответе запроса</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<ResultWithCount<DatasetListItem>> GetListByDepartmentPostAsync(int departmentId, System.Collections.Generic.IEnumerable<string> projection, string filter, string orderby, int? top, int? skip, string inlinecount)
        {
            return GetListByDepartmentPostAsync(departmentId, projection, filter, orderby, top, skip, inlinecount, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение списка наборов данных или справочников для заданного департамента</summary>
        /// <param name="departmentId">Идентификатор департамента</param>
        /// <param name="projection">Список возвращаемых полей в ответе запроса</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<ResultWithCount<DatasetListItem>> GetListByDepartmentPostAsync(int departmentId, System.Collections.Generic.IEnumerable<string> projection, string filter, string orderby, int? top, int? skip, string inlinecount, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/departments/{departmentId}/datasets?");
            urlBuilder_.Replace("{departmentId}", System.Uri.EscapeDataString(ConvertToString(departmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (filter != null)
            {
                urlBuilder_.Append("$filter=").Append(System.Uri.EscapeDataString(ConvertToString(filter, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (orderby != null)
            {
                urlBuilder_.Append("$orderby=").Append(System.Uri.EscapeDataString(ConvertToString(orderby, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (top != null)
            {
                urlBuilder_.Append("$top=").Append(System.Uri.EscapeDataString(ConvertToString(top, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (skip != null)
            {
                urlBuilder_.Append("$skip=").Append(System.Uri.EscapeDataString(ConvertToString(skip, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (inlinecount != null)
            {
                urlBuilder_.Append("$inlinecount=").Append(System.Uri.EscapeDataString(ConvertToString(inlinecount, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (_apiKey != null)
            {
                urlBuilder_.Append("api_key=").Append(System.Uri.EscapeDataString(ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(projection, _settings.Value));
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ResultWithCount<DatasetListItem>);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultWithCount<DatasetListItem>>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(ResultWithCount<DatasetListItem>);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Получение списка наборов данных или справочников для заданной категории</summary>
        /// <param name="categoryId">Идентификатор категории</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<ResultWithCount<DatasetListItem>> GetListByCategoryAsync(int categoryId, string filter, string orderby, int? top, int? skip, string inlinecount)
        {
            return GetListByCategoryAsync(categoryId, filter, orderby, top, skip, inlinecount, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение списка наборов данных или справочников для заданной категории</summary>
        /// <param name="categoryId">Идентификатор категории</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<ResultWithCount<DatasetListItem>> GetListByCategoryAsync(int categoryId, string filter, string orderby, int? top, int? skip, string inlinecount, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/categories/{categoryId}/datasets?");
            urlBuilder_.Replace("{categoryId}", System.Uri.EscapeDataString(ConvertToString(categoryId, System.Globalization.CultureInfo.InvariantCulture)));
            if (filter != null)
            {
                urlBuilder_.Append("$filter=").Append(System.Uri.EscapeDataString(ConvertToString(filter, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (orderby != null)
            {
                urlBuilder_.Append("$orderby=").Append(System.Uri.EscapeDataString(ConvertToString(orderby, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (top != null)
            {
                urlBuilder_.Append("$top=").Append(System.Uri.EscapeDataString(ConvertToString(top, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (skip != null)
            {
                urlBuilder_.Append("$skip=").Append(System.Uri.EscapeDataString(ConvertToString(skip, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (inlinecount != null)
            {
                urlBuilder_.Append("$inlinecount=").Append(System.Uri.EscapeDataString(ConvertToString(inlinecount, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (_apiKey != null)
            {
                urlBuilder_.Append("api_key=").Append(System.Uri.EscapeDataString(ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ResultWithCount<DatasetListItem>);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultWithCount<DatasetListItem>>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(ResultWithCount<DatasetListItem>);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Получение структуры набора данных</summary>
        /// <param name="id">Идентификатор набора данных</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<DatasetItem> GetItemAsync(int id)
        {
            return GetItemAsync(id, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение структуры набора данных</summary>
        /// <param name="id">Идентификатор набора данных</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<DatasetItem> GetItemAsync(int id, System.Threading.CancellationToken cancellationToken)
        { 
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/datasets/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            if (_apiKey != null)
            {
                urlBuilder_.Append("?api_key=").Append(System.Uri.EscapeDataString(ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(DatasetItem);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<DatasetItem>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(DatasetItem);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Получение структуры набора данных</summary>
        /// <param name="id">Идентификатор набора данных</param>
        /// <param name="projection">Список возвращаемых полей в ответе запроса</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<DatasetItem> GetItemPostAsync(int id, System.Collections.Generic.IEnumerable<string> projection)
        {
            return GetItemPostAsync(id, projection, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение структуры набора данных</summary>
        /// <param name="id">Идентификатор набора данных</param>
        /// <param name="projection">Список возвращаемых полей в ответе запроса</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<DatasetItem> GetItemPostAsync(int id, System.Collections.Generic.IEnumerable<string> projection, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/datasets/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            if (_apiKey != null)
            {
                urlBuilder_.Append("?api_key=").Append(System.Uri.EscapeDataString(ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(projection, _settings.Value));
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(DatasetItem);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<DatasetItem>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(DatasetItem);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Получение актуальной версии набора данных</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<DatasetVersionItem> GetVersionAsync(int datasetId)
        {
            return GetVersionAsync(datasetId, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение актуальной версии набора данных</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<DatasetVersionItem> GetVersionAsync(int datasetId, System.Threading.CancellationToken cancellationToken)
        {
            if (datasetId == null)
                throw new System.ArgumentNullException("datasetId");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/datasets/{datasetId}/version");
            urlBuilder_.Replace("{datasetId}", System.Uri.EscapeDataString(ConvertToString(datasetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (_apiKey != null)
            {
                urlBuilder_.Append("?api_key=").Append(System.Uri.EscapeDataString(ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(DatasetVersionItem);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<DatasetVersionItem>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(DatasetVersionItem);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Получение иконки датасета</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="size">Размер</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<object> GetTransparentIconAsync(int datasetId, string size)
        {
            return GetTransparentIconAsync(datasetId, size, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение иконки датасета</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="size">Размер</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<object> GetTransparentIconAsync(int datasetId, string size, System.Threading.CancellationToken cancellationToken)
        {
            if (datasetId == null)
                throw new System.ArgumentNullException("datasetId");

            if (size == null)
                throw new System.ArgumentNullException("size");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/datasets/{datasetId}/icon/{size}");
            urlBuilder_.Replace("{datasetId}", System.Uri.EscapeDataString(ConvertToString(datasetId, System.Globalization.CultureInfo.InvariantCulture)));
            urlBuilder_.Replace("{size}", System.Uri.EscapeDataString(ConvertToString(size, System.Globalization.CultureInfo.InvariantCulture)));
            if (_apiKey != null)
            {
                urlBuilder_.Append("?api_key=").Append(System.Uri.EscapeDataString(ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("image/png"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(object);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<object>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(object);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Получение маркера карты для набора данных</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<object> GetMarkerAsync(int datasetId)
        {
            return GetMarkerAsync(datasetId, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение маркера карты для набора данных</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<object> GetMarkerAsync(int datasetId, System.Threading.CancellationToken cancellationToken)
        {
            if (datasetId == null)
                throw new System.ArgumentNullException("datasetId");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/datasets/{datasetId}/marker");
            urlBuilder_.Replace("{datasetId}", System.Uri.EscapeDataString(ConvertToString(datasetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (_apiKey != null)
            {
                urlBuilder_.Append("?api_key=").Append(System.Uri.EscapeDataString(ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/xml"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(object);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<object>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(object);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Получение цветной иконки набора данных</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="width">Размер иконки</param>
        /// <param name="transparent">При значениее true, подложка иконки будет отсутствовать</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<object> GetIconAsync(int datasetId, int width, bool? transparent)
        {
            return GetIconAsync(datasetId, width, transparent, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение цветной иконки набора данных</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="width">Размер иконки</param>
        /// <param name="transparent">При значениее true, подложка иконки будет отсутствовать</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<object> GetIconAsync(int datasetId, int width, bool? transparent, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/datasets/{datasetId}/Image/{width}?");
            urlBuilder_.Replace("{datasetId}", System.Uri.EscapeDataString(ConvertToString(datasetId, System.Globalization.CultureInfo.InvariantCulture)));
            urlBuilder_.Replace("{width}", System.Uri.EscapeDataString(ConvertToString(width, System.Globalization.CultureInfo.InvariantCulture)));
            if (transparent != null)
            {
                urlBuilder_.Append("transparent=").Append(System.Uri.EscapeDataString(ConvertToString(transparent, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (_apiKey != null)
            {
                urlBuilder_.Append("api_key=").Append(System.Uri.EscapeDataString(ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("image/png"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(object);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<object>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(object);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Получение изображения набора данных для соц. сетей</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="size">Размер иконки</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<object> GetSocialImageAsync(int datasetId, int? size)
        {
            return GetSocialImageAsync(datasetId, size, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение изображения набора данных для соц. сетей</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="size">Размер иконки</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<object> GetSocialImageAsync(int datasetId, int? size, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/datasets/{datasetId}/SocialImage?");
            urlBuilder_.Replace("{datasetId}", System.Uri.EscapeDataString(ConvertToString(datasetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (size != null)
            {
                urlBuilder_.Append("size=").Append(System.Uri.EscapeDataString(ConvertToString(size, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (_apiKey != null)
            {
                urlBuilder_.Append("api_key=").Append(System.Uri.EscapeDataString(ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("image/png"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(object);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<object>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(object);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value is System.Enum)
            {
                string name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value;
                        }
                    }
                }
            }
            else if (value is bool)
            {
                return System.Convert.ToString(value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[])value);
            }
            else if (value != null && value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }

            return System.Convert.ToString(value, cultureInfo);
        }
    }
}