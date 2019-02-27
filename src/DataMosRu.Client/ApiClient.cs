using DataMosRu.Client.Clients;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DataMosRu.Client
{
    public class ApiClient
    {
        public ApiClient(string apiKey)
        {
            var http = new HttpClient(new ApiKeyHttpClientHandler(apiKey));

            Datasets = new DatasetsClient(http);
            Categories = new CategoriesClient(http);
            Departments = new DepartmentsClient(http);
            Features = new FeaturesClient(http);
            Rows = new RowsClient(http);
            Structure = new StructureClient(http);
            Versions = new VersionsClient(http);
        }

        public DatasetsClient Datasets { get; private set; }
        public CategoriesClient Categories { get; private set; }
        public DepartmentsClient Departments { get; private set; }
        public FeaturesClient Features { get; private set; }
        public RowsClient Rows { get; private set; }
        public StructureClient Structure { get; private set; }
        public VersionsClient Versions { get; private set; }
    }
}
