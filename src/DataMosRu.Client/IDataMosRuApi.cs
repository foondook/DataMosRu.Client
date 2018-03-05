using System.Collections.Generic;
using System.Threading.Tasks;
using DataMosRu.Model;
using Refit;

namespace DataMosRu.Client
{
    public interface IDataMosRuApi
    {
        [Get("/version")]
        Task<string> GetVersion();

        [Get("/v1/datasets?$skip={skip}&$top={top}")]
        Task<List<Dataset>> GetDatasets(int skip = 0, int top = 10);
    }
}
