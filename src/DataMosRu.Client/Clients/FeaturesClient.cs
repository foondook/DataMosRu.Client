using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;

namespace DataMosRu.Client.Clients
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.0.14.0 (NJsonSchema v9.13.18.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class FeaturesClient
    {
        private string _baseUrl = "https://apidata.mos.ru";
        private System.Net.Http.HttpClient _httpClient;
        private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

        public FeaturesClient(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
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

        /// <summary>Получение строк указанного набора данных в формате GeoJSON</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="versionNumber">Номер версии</param>
        /// <param name="releaseNumber">Номер релиза</param>
        /// <param name="bbox">ограничивающий прямоугольник (bounding box) заданный двумя географическими координатами</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<FeatureCollection> GetListByDatasetIdAsync(int datasetId, int? versionNumber, int? releaseNumber, string bbox)
        {
            return GetListByDatasetIdAsync(datasetId, versionNumber, releaseNumber, bbox, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение строк указанного набора данных в формате GeoJSON</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="versionNumber">Номер версии</param>
        /// <param name="releaseNumber">Номер релиза</param>
        /// <param name="bbox">ограничивающий прямоугольник (bounding box) заданный двумя географическими координатами</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<FeatureCollection> GetListByDatasetIdAsync(int datasetId, int? versionNumber, int? releaseNumber, string bbox, System.Threading.CancellationToken cancellationToken)
        {
            if (datasetId == null)
                throw new System.ArgumentNullException("datasetId");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/datasets/{datasetId}/features?");
            urlBuilder_.Replace("{datasetId}", System.Uri.EscapeDataString(ConvertToString(datasetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (versionNumber != null)
            {
                urlBuilder_.Append("versionNumber=").Append(System.Uri.EscapeDataString(ConvertToString(versionNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (releaseNumber != null)
            {
                urlBuilder_.Append("releaseNumber=").Append(System.Uri.EscapeDataString(ConvertToString(releaseNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (bbox != null)
            {
                urlBuilder_.Append("bbox=").Append(System.Uri.EscapeDataString(ConvertToString(bbox, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
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
                            var result_ = default(FeatureCollection);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<FeatureCollection>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ == "413")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("RequestEntityTooLarge", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(FeatureCollection);
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

        /// <summary>Получение строк указанного набора данных в формате GeoJSON</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="projection">Список полей возвращаемых в ответе</param>
        /// <param name="versionNumber">Номер версии</param>
        /// <param name="releaseNumber">Номер релиза</param>
        /// <param name="bbox">ограничивающий прямоугольник (bounding box) заданный двумя географическими координатами</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<FeatureCollection> GetListByDatasetId2Async(int datasetId, System.Collections.Generic.IEnumerable<string> projection, int? versionNumber, int? releaseNumber, string bbox)
        {
            return GetListByDatasetId2Async(datasetId, projection, versionNumber, releaseNumber, bbox, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение строк указанного набора данных в формате GeoJSON</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="projection">Список полей возвращаемых в ответе</param>
        /// <param name="versionNumber">Номер версии</param>
        /// <param name="releaseNumber">Номер релиза</param>
        /// <param name="bbox">ограничивающий прямоугольник (bounding box) заданный двумя географическими координатами</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<FeatureCollection> GetListByDatasetId2Async(int datasetId, System.Collections.Generic.IEnumerable<string> projection, int? versionNumber, int? releaseNumber, string bbox, System.Threading.CancellationToken cancellationToken)
        {
            if (datasetId == null)
                throw new System.ArgumentNullException("datasetId");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/datasets/{datasetId}/features?");
            urlBuilder_.Replace("{datasetId}", System.Uri.EscapeDataString(ConvertToString(datasetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (versionNumber != null)
            {
                urlBuilder_.Append("versionNumber=").Append(System.Uri.EscapeDataString(ConvertToString(versionNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (releaseNumber != null)
            {
                urlBuilder_.Append("releaseNumber=").Append(System.Uri.EscapeDataString(ConvertToString(releaseNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (bbox != null)
            {
                urlBuilder_.Append("bbox=").Append(System.Uri.EscapeDataString(ConvertToString(bbox, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
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
                            var result_ = default(FeatureCollection);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<FeatureCollection>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ == "413")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("RequestEntityTooLarge", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(FeatureCollection);
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

        /// <summary>Получение строк указанного набора данных в формате GeoJSON</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="versionNumber">Номер версии</param>
        /// <param name="releaseNumber">Номер релиза</param>
        /// <param name="bbox">ограничивающий прямоугольник (bounding box) заданный двумя географическими координатами</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<FeatureCollection> GetListByDatasetId3Async(int datasetId, int? versionNumber, int? releaseNumber, string bbox)
        {
            return GetListByDatasetId3Async(datasetId, versionNumber, releaseNumber, bbox, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение строк указанного набора данных в формате GeoJSON</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="versionNumber">Номер версии</param>
        /// <param name="releaseNumber">Номер релиза</param>
        /// <param name="bbox">ограничивающий прямоугольник (bounding box) заданный двумя географическими координатами</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<FeatureCollection> GetListByDatasetId3Async(int datasetId, int? versionNumber, int? releaseNumber, string bbox, System.Threading.CancellationToken cancellationToken)
        {
            if (datasetId == null)
                throw new System.ArgumentNullException("datasetId");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/features/{datasetId}?");
            urlBuilder_.Replace("{datasetId}", System.Uri.EscapeDataString(ConvertToString(datasetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (versionNumber != null)
            {
                urlBuilder_.Append("versionNumber=").Append(System.Uri.EscapeDataString(ConvertToString(versionNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (releaseNumber != null)
            {
                urlBuilder_.Append("releaseNumber=").Append(System.Uri.EscapeDataString(ConvertToString(releaseNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (bbox != null)
            {
                urlBuilder_.Append("bbox=").Append(System.Uri.EscapeDataString(ConvertToString(bbox, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
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
                            var result_ = default(FeatureCollection);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<FeatureCollection>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ == "413")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("RequestEntityTooLarge", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(FeatureCollection);
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

        /// <summary>Получение строк указанного набора данных в формате GeoJSON</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="projection">Список полей возвращаемых в ответе</param>
        /// <param name="versionNumber">Номер версии</param>
        /// <param name="releaseNumber">Номер релиза</param>
        /// <param name="bbox">ограничивающий прямоугольник (bounding box) заданный двумя географическими координатами</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<FeatureCollection> GetListByDatasetId4Async(int datasetId, System.Collections.Generic.IEnumerable<string> projection, int? versionNumber, int? releaseNumber, string bbox)
        {
            return GetListByDatasetId4Async(datasetId, projection, versionNumber, releaseNumber, bbox, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение строк указанного набора данных в формате GeoJSON</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="projection">Список полей возвращаемых в ответе</param>
        /// <param name="versionNumber">Номер версии</param>
        /// <param name="releaseNumber">Номер релиза</param>
        /// <param name="bbox">ограничивающий прямоугольник (bounding box) заданный двумя географическими координатами</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<FeatureCollection> GetListByDatasetId4Async(int datasetId, System.Collections.Generic.IEnumerable<string> projection, int? versionNumber, int? releaseNumber, string bbox, System.Threading.CancellationToken cancellationToken)
        {
            if (datasetId == null)
                throw new System.ArgumentNullException("datasetId");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/features/{datasetId}?");
            urlBuilder_.Replace("{datasetId}", System.Uri.EscapeDataString(ConvertToString(datasetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (versionNumber != null)
            {
                urlBuilder_.Append("versionNumber=").Append(System.Uri.EscapeDataString(ConvertToString(versionNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (releaseNumber != null)
            {
                urlBuilder_.Append("releaseNumber=").Append(System.Uri.EscapeDataString(ConvertToString(releaseNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (bbox != null)
            {
                urlBuilder_.Append("bbox=").Append(System.Uri.EscapeDataString(ConvertToString(bbox, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
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
                            var result_ = default(FeatureCollection);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<FeatureCollection>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ == "413")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("RequestEntityTooLarge", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(FeatureCollection);
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

        /// <summary>Получение строк указанного набора данных в формате GeoJSON</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="versionNumber">Номер версии</param>
        /// <param name="releaseNumber">Номер релиза</param>
        /// <param name="rowId">Идентиифкатор строки</param>
        /// <param name="fields">Возвращаемые поля</param>
        /// <param name="bbox">Ограничивающий прямоугольник (bounding box) заданный двумя географическими координатами</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<FeatureCollection> GetMapFeaturesByDatasetIdAsync(int datasetId, int? versionNumber, int? releaseNumber, string rowId, System.Collections.Generic.IEnumerable<string> fields, string bbox)
        {
            return GetMapFeaturesByDatasetIdAsync(datasetId, versionNumber, releaseNumber, rowId, fields, bbox, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение строк указанного набора данных в формате GeoJSON</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="versionNumber">Номер версии</param>
        /// <param name="releaseNumber">Номер релиза</param>
        /// <param name="rowId">Идентиифкатор строки</param>
        /// <param name="fields">Возвращаемые поля</param>
        /// <param name="bbox">Ограничивающий прямоугольник (bounding box) заданный двумя географическими координатами</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<FeatureCollection> GetMapFeaturesByDatasetIdAsync(int datasetId, int? versionNumber, int? releaseNumber, string rowId, System.Collections.Generic.IEnumerable<string> fields, string bbox, System.Threading.CancellationToken cancellationToken)
        {
            if (datasetId == null)
                throw new System.ArgumentNullException("datasetId");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/mapfeatures/{datasetId}?");
            urlBuilder_.Replace("{datasetId}", System.Uri.EscapeDataString(ConvertToString(datasetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (versionNumber != null)
            {
                urlBuilder_.Append("versionNumber=").Append(System.Uri.EscapeDataString(ConvertToString(versionNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (releaseNumber != null)
            {
                urlBuilder_.Append("releaseNumber=").Append(System.Uri.EscapeDataString(ConvertToString(releaseNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (rowId != null)
            {
                urlBuilder_.Append("rowId=").Append(System.Uri.EscapeDataString(ConvertToString(rowId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (fields != null)
            {
                foreach (var item_ in fields) { urlBuilder_.Append("fields=").Append(System.Uri.EscapeDataString(ConvertToString(item_, System.Globalization.CultureInfo.InvariantCulture))).Append("&"); }
            }
            if (bbox != null)
            {
                urlBuilder_.Append("bbox=").Append(System.Uri.EscapeDataString(ConvertToString(bbox, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
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
                            var result_ = default(FeatureCollection);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<FeatureCollection>(responseData_, _settings.Value);
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

                        return default(FeatureCollection);
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

        /// <summary>Получение строк указанного набора данных в формате GeoJSON</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="versionNumber">Номер версии</param>
        /// <param name="releaseNumber">Номер релиза</param>
        /// <param name="rowId">Идентиифкатор строки</param>
        /// <param name="fields">Возвращаемые поля</param>
        /// <param name="bbox">Ограничивающий прямоугольник (bounding box) заданный двумя географическими координатами</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<FeatureCollection> GetMapFeaturesByDatasetId2Async(int datasetId, int? versionNumber, int? releaseNumber, string rowId, System.Collections.Generic.IEnumerable<string> fields, string bbox, object filters)
        {
            return GetMapFeaturesByDatasetId2Async(datasetId, versionNumber, releaseNumber, rowId, fields, bbox, filters, System.Threading.CancellationToken.None);
        }

        /// <summary>Получение строк указанного набора данных в формате GeoJSON</summary>
        /// <param name="datasetId">Идентификатор набора данных</param>
        /// <param name="versionNumber">Номер версии</param>
        /// <param name="releaseNumber">Номер релиза</param>
        /// <param name="rowId">Идентиифкатор строки</param>
        /// <param name="fields">Возвращаемые поля</param>
        /// <param name="bbox">Ограничивающий прямоугольник (bounding box) заданный двумя географическими координатами</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<FeatureCollection> GetMapFeaturesByDatasetId2Async(int datasetId, int? versionNumber, int? releaseNumber, string rowId, System.Collections.Generic.IEnumerable<string> fields, string bbox, object filters, System.Threading.CancellationToken cancellationToken)
        {
            if (datasetId == null)
                throw new System.ArgumentNullException("datasetId");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/mapfeatures/{datasetId}/typedFiltered?");
            urlBuilder_.Replace("{datasetId}", System.Uri.EscapeDataString(ConvertToString(datasetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (versionNumber != null)
            {
                urlBuilder_.Append("versionNumber=").Append(System.Uri.EscapeDataString(ConvertToString(versionNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (releaseNumber != null)
            {
                urlBuilder_.Append("releaseNumber=").Append(System.Uri.EscapeDataString(ConvertToString(releaseNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (rowId != null)
            {
                urlBuilder_.Append("rowId=").Append(System.Uri.EscapeDataString(ConvertToString(rowId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (fields != null)
            {
                foreach (var item_ in fields) { urlBuilder_.Append("fields=").Append(System.Uri.EscapeDataString(ConvertToString(item_, System.Globalization.CultureInfo.InvariantCulture))).Append("&"); }
            }
            if (bbox != null)
            {
                urlBuilder_.Append("bbox=").Append(System.Uri.EscapeDataString(ConvertToString(bbox, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (filters != null)
            {
                urlBuilder_.Append("filters=").Append(System.Uri.EscapeDataString(ConvertToString(filters, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
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
                            var result_ = default(FeatureCollection);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<FeatureCollection>(responseData_, _settings.Value);
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

                        return default(FeatureCollection);
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

        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<FeatureCollection> GetMapRegionsByDatasetIdAsync(int datasetId, int? versionNumber, int? releaseNumber)
        {
            return GetMapRegionsByDatasetIdAsync(datasetId, versionNumber, releaseNumber, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<FeatureCollection> GetMapRegionsByDatasetIdAsync(int datasetId, int? versionNumber, int? releaseNumber, System.Threading.CancellationToken cancellationToken)
        {
            if (datasetId == null)
                throw new System.ArgumentNullException("datasetId");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/map/{datasetId}/regions?");
            urlBuilder_.Replace("{datasetId}", System.Uri.EscapeDataString(ConvertToString(datasetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (versionNumber != null)
            {
                urlBuilder_.Append("versionNumber=").Append(System.Uri.EscapeDataString(ConvertToString(versionNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (releaseNumber != null)
            {
                urlBuilder_.Append("releaseNumber=").Append(System.Uri.EscapeDataString(ConvertToString(releaseNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
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
                            var result_ = default(FeatureCollection);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<FeatureCollection>(responseData_, _settings.Value);
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

                        return default(FeatureCollection);
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

        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<FeatureCollection> GetMapDistrictsByDatasetIdAsync(int datasetId, int? versionNumber, int? releaseNumber)
        {
            return GetMapDistrictsByDatasetIdAsync(datasetId, versionNumber, releaseNumber, System.Threading.CancellationToken.None);
        }

        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<FeatureCollection> GetMapDistrictsByDatasetIdAsync(int datasetId, int? versionNumber, int? releaseNumber, System.Threading.CancellationToken cancellationToken)
        {
            if (datasetId == null)
                throw new System.ArgumentNullException("datasetId");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/map/{datasetId}/districts?");
            urlBuilder_.Replace("{datasetId}", System.Uri.EscapeDataString(ConvertToString(datasetId, System.Globalization.CultureInfo.InvariantCulture)));
            if (versionNumber != null)
            {
                urlBuilder_.Append("versionNumber=").Append(System.Uri.EscapeDataString(ConvertToString(versionNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (releaseNumber != null)
            {
                urlBuilder_.Append("releaseNumber=").Append(System.Uri.EscapeDataString(ConvertToString(releaseNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
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
                            var result_ = default(FeatureCollection);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<FeatureCollection>(responseData_, _settings.Value);
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

                        return default(FeatureCollection);
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