using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DataMosRu.Client
{
    public class ApiKeyHttpClientHandler : HttpClientHandler
    {
        private readonly string apiKey;
        public ApiKeyHttpClientHandler(string apiKey)
        {
            this.apiKey = apiKey;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var uriBuilder = new UriBuilder(request.RequestUri);
            var query = $"{uriBuilder.Query}&api_key={this.apiKey}";
            uriBuilder.Query = query;
            var newUri = uriBuilder.ToString();
            request.RequestUri = new Uri(newUri);

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}