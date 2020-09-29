using Servicenode.Api.Core.Models;
using System.Linq;

namespace Servicenode.Api.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<ServiceNodeInfoResponse> ApplyServiceNodeFiltering(this IQueryable<ServiceNodeInfoResponse> query, ServiceNodeQuery queryObj)
        {
            if (!string.IsNullOrWhiteSpace(queryObj.Search))
            {
                query = query.Where(sn => sn.Host.Contains(queryObj.Search) || sn.SNodeKey.Contains(queryObj.Search));
            }
            if (!string.IsNullOrWhiteSpace(queryObj.SpvWallet))
            {
                query = query.Where(sn => sn.SpvWallets.Contains(queryObj.SpvWallet));
            }

            if (!string.IsNullOrWhiteSpace(queryObj.XCloudService))
            {
                query = query.Where(sn => sn.XCloudServices.Contains(queryObj.XCloudService));
            }

            if (!string.IsNullOrWhiteSpace(queryObj.Type))
            {
                query = query.Where(sn => sn.Type.Equals(queryObj.Type));
            }


            query = query.Where(sn => sn.Status.Equals("running"));

            return query;
        }

        public static IQueryable<T> ApplyPaging<T>(this IQueryable<T> query, IQueryObject queryObj)
        {
            if (queryObj.Page <= 0)
                queryObj.Page = 1;

            if (queryObj.PageSize <= 0)
                queryObj.PageSize = 10;

            return query.Skip((queryObj.Page - 1) * queryObj.PageSize).Take(queryObj.PageSize);
        }
    }
}
