using eShopSolution.ViewModels.Common;
using System.Collections.Generic;

namespace eShopSolution.ViewModels.Catalog.Products.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public int? CategoryId { get; set; }
    }
}
