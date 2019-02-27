using DataMosRu.Client.Clients;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataMosRu.Client
{
    public class ApiClient
    {
        public ApiClient()
        {
            
        }

        public DatasetsClient Datasets { get; }
        public CategoriesClient Categories { get; }
        public DepartmentsClient Departments { get; }
        public FeaturesClient Features { get; }
        public RowsClient Rows { get; }
        public StructureClient Structure { get; }
        public VersionsClient Versions { get; }
    }
}
