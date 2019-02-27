using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace DataMosRu.Client.Interfaces
{
    public interface IDatasetsClient
    {
        string BaseUrl { get; set; }

        Task<object> GetIconAsync(int datasetId, int width, bool? transparent, CancellationToken cancellationToken);
        Task<DatasetItem> GetItemAsync(int id, CancellationToken cancellationToken);
        Task<DatasetItem> GetItemAsync(int id, CancellationToken cancellationToken, Expression<Func<DatasetItem, object>> projectionExpression);
        Task<DatasetItem> GetItemPostAsync(int id, IEnumerable<string> projection, CancellationToken cancellationToken);
        Task<ResultWithCount<DatasetListItem>> GetListAsync(bool? foreign, string filter, string orderby, int? top, int? skip, string inlinecount, CancellationToken cancellationToken);
        Task<ResultWithCount<DatasetListItem>> GetListByCategoryAsync(int categoryId, string filter, string orderby, int? top, int? skip, string inlinecount, CancellationToken cancellationToken);
        Task<ResultWithCount<DatasetListItem>> GetListByDepartmentAsync(int departmentId, string filter, string orderby, int? top, int? skip, string inlinecount, CancellationToken cancellationToken);
        Task<ResultWithCount<DatasetListItem>> GetListByDepartmentPostAsync(int departmentId, IEnumerable<string> projection, string filter, string orderby, int? top, int? skip, string inlinecount, CancellationToken cancellationToken);
        Task<ResultWithCount<DatasetListItem>> GetListPostAsync(IEnumerable<string> projection, bool? foreign, string filter, string orderby, int? top, int? skip, string inlinecount, CancellationToken cancellationToken);
        Task<object> GetMarkerAsync(int datasetId, CancellationToken cancellationToken);
        Task<object> GetSocialImageAsync(int datasetId, int? size, CancellationToken cancellationToken);
        Task<object> GetTransparentIconAsync(int datasetId, string size, CancellationToken cancellationToken);
        Task<DatasetVersionItem> GetVersionAsync(int datasetId, CancellationToken cancellationToken);
    }
}