using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;

namespace DataMosRu.Client
{
    public partial class DepartmentsClient
    {
        private string _baseUrl = "https://apidata.mos.ru";
        private HttpClient _httpClient;
        private Lazy<JsonSerializerSettings> _settings;

        public DepartmentsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _settings = new Lazy<JsonSerializerSettings>(() =>
            {
                var settings = new JsonSerializerSettings();
                UpdateJsonSerializerSettings(settings);
                return settings;
            });
        }

        public string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }

        protected JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

        partial void UpdateJsonSerializerSettings(JsonSerializerSettings settings);
        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url);
        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, StringBuilder urlBuilder);
        partial void ProcessResponse(HttpClient client, HttpResponseMessage response);

        /// <summary>Получение списка департаментов</summary>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<IQueryable<ResultWithCount<DepartmentListItem>>> GetDepartmentsListAsync(string filter, string orderby, int? top, int? skip, string inlinecount)
        {
            return GetDepartmentsListAsync(filter, orderby, top, skip, inlinecount, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение списка департаментов</summary>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task<IQueryable<ResultWithCount<DepartmentListItem>>> GetDepartmentsListAsync(string filter, string orderby, int? top, int? skip, string inlinecount, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/departments?");
            if (filter != null)
            {
                urlBuilder_.Append("$filter=").Append(Uri.EscapeDataString(ConvertToString(filter, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (orderby != null)
            {
                urlBuilder_.Append("$orderby=").Append(Uri.EscapeDataString(ConvertToString(orderby, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (top != null)
            {
                urlBuilder_.Append("$top=").Append(Uri.EscapeDataString(ConvertToString(top, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (skip != null)
            {
                urlBuilder_.Append("$skip=").Append(Uri.EscapeDataString(ConvertToString(skip, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (inlinecount != null)
            {
                urlBuilder_.Append("$inlinecount=").Append(Uri.EscapeDataString(ConvertToString(inlinecount, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
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
                            var result_ = default(IQueryable<ResultWithCount<DepartmentListItem>>);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<IQueryable<ResultWithCount<DepartmentListItem>>>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (Exception exception_)
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

                        return default(IQueryable<ResultWithCount<DepartmentListItem>>);
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

        /// <summary>Получение списка департаментов</summary>
        /// <param name="projection">Список полей, включённых в ответ запроса</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<IQueryable<ResultWithCount<DepartmentListItem>>> GetDepartmentsListPostAsync(System.Collections.Generic.IEnumerable<string> projection, string filter, string orderby, int? top, int? skip, string inlinecount)
        {
            return GetDepartmentsListPostAsync(projection, filter, orderby, top, skip, inlinecount, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение списка департаментов</summary>
        /// <param name="projection">Список полей, включённых в ответ запроса</param>
        /// <param name="filter">Фильтрация результате на условии истинности выражения. Поддерживает операторы протокола OData v2.0</param>
        /// <param name="orderby">Указывает поле для сортировки результирующего списка. Пример: $orderby = "Caption", $orderby = "Number desc."</param>
        /// <param name="top">Ограничивает количество возвращаемых записей. Без указания данного параметра выводятся все записи.</param>
        /// <param name="skip">Позволяет указать количество записей, которые следует пропустить в ответе.</param>
        /// <param name="inlinecount">Принимает значение allpages для того, чтобы в ответе получить общее количество записей. По умолчанию общее количество записей не выводится.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task<IQueryable<ResultWithCount<DepartmentListItem>>> GetDepartmentsListPostAsync(System.Collections.Generic.IEnumerable<string> projection, string filter, string orderby, int? top, int? skip, string inlinecount, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/departments?");
            if (filter != null)
            {
                urlBuilder_.Append("$filter=").Append(Uri.EscapeDataString(ConvertToString(filter, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (orderby != null)
            {
                urlBuilder_.Append("$orderby=").Append(Uri.EscapeDataString(ConvertToString(orderby, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (top != null)
            {
                urlBuilder_.Append("$top=").Append(Uri.EscapeDataString(ConvertToString(top, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (skip != null)
            {
                urlBuilder_.Append("$skip=").Append(Uri.EscapeDataString(ConvertToString(skip, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (inlinecount != null)
            {
                urlBuilder_.Append("$inlinecount=").Append(Uri.EscapeDataString(ConvertToString(inlinecount, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(projection, _settings.Value));
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
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
                            var result_ = default(IQueryable<ResultWithCount<DepartmentListItem>>);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<IQueryable<ResultWithCount<DepartmentListItem>>>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (Exception exception_)
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

                        return default(IQueryable<ResultWithCount<DepartmentListItem>>);
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

        /// <summary>Получение департамента</summary>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<DepartmentItem> GetItemAsync(int id)
        {
            return GetItemAsync(id, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение департамента</summary>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task<DepartmentItem> GetItemAsync(int id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/departments/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
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
                            var result_ = default(DepartmentItem);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<DepartmentItem>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (Exception exception_)
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

                        return default(DepartmentItem);
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

        /// <summary>Получение департамента</summary>
        /// <param name="projection">Список полей, включённых в ответ запроса</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<DepartmentItem> GetItemPostAsync(int id, System.Collections.Generic.IEnumerable<string> projection)
        {
            return GetItemPostAsync(id, projection, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение департамента</summary>
        /// <param name="projection">Список полей, включённых в ответ запроса</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task<DepartmentItem> GetItemPostAsync(int id, System.Collections.Generic.IEnumerable<string> projection, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/departments/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(projection, _settings.Value));
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
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
                            var result_ = default(DepartmentItem);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<DepartmentItem>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (Exception exception_)
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

                        return default(DepartmentItem);
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
            if (value is Enum)
            {
                string name = Enum.GetName(value.GetType(), value);
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
                return Convert.ToString(value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return Convert.ToBase64String((byte[])value);
            }
            else if (value != null && value.GetType().IsArray)
            {
                var array = Enumerable.OfType<object>((Array)value);
                return string.Join(",", Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }

            return Convert.ToString(value, cultureInfo);
        }
    }
}