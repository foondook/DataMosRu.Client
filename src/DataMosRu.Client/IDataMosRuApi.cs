using System.Collections.Generic;
using System.Threading.Tasks;
using DataMosRu.Model;

namespace DataMosRu.Client
{
    //public interface IDataMosRuApi
    //{
    //    [Get("/version")]
    //    Task<string> GetVersion();

    //    [Get("/v1/datasets")]
    //    Task<List<Dataset>> GetDatasets(
    //        [AliasAs("$skip")]int skip = 0,
    //        [AliasAs("$top")]int top = 10,
    //        [AliasAs("$filter")]string filter = null,
    //        [AliasAs("$orderby")]string orderby = null,
    //        [AliasAs("$inlinecount")]string inlinecount = null);

    //    [Get("/v1/departments/{departmentId}/datasets")]
    //    Task<List<Dataset>> GetDatasetsByDepartment(
    //        int departmentId,
    //        [AliasAs("$skip")]int skip = 0,
    //        [AliasAs("$top")]int top = 10,
    //        [AliasAs("$filter")]string filter = null,
    //        [AliasAs("$orderby")]string orderby = null,
    //        [AliasAs("$inlinecount")]string inlinecount = null);

    //    [Get("/v1/categories/{categoryId}/datasets")]
    //    Task<List<Dataset>> GetDatasetsByCategory(
    //        int categoryId,
    //        [AliasAs("$skip")]int skip = 0,
    //        [AliasAs("$top")]int top = 10,
    //        [AliasAs("$filter")]string filter = null,
    //        [AliasAs("$orderby")]string orderby = null,
    //        [AliasAs("$inlinecount")]string inlinecount = null);

    //    [Get("/v1/datasets/{id}")]
    //    Task<Dataset> GetDataset(int id);

    //    [Get("/v1/classifiers")]
    //    Task<List<Classifier>> GetClassifiers(
    //        [AliasAs("$skip")]int skip = 0,
    //        [AliasAs("$top")]int top = 10,
    //        [AliasAs("$filter")]string filter = null,
    //        [AliasAs("$orderby")]string orderby = null,
    //        [AliasAs("$inlinecount")]string inlinecount = null);

    //    [Get("/v1/classifiers/{departmentId}/datasets")]
    //    Task<List<Classifier>> GetClassifiersByDepartment(
    //        int departmentId,
    //        [AliasAs("$skip")]int skip = 0,
    //        [AliasAs("$top")]int top = 10,
    //        [AliasAs("$filter")]string filter = null,
    //        [AliasAs("$orderby")]string orderby = null,
    //        [AliasAs("$inlinecount")]string inlinecount = null);

    //    [Get("/v1/categories/{categoryId}/classifiers")]
    //    Task<List<Classifier>> GetClassifiersByCategory(
    //        int categoryId,
    //        [AliasAs("$skip")]int skip = 0,
    //        [AliasAs("$top")]int top = 10,
    //        [AliasAs("$filter")]string filter = null,
    //        [AliasAs("$orderby")]string orderby = null,
    //        [AliasAs("$inlinecount")]string inlinecount = null);

    //}
}
