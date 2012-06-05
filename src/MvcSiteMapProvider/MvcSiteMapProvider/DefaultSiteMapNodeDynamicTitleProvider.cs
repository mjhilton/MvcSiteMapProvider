using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using MvcSiteMapProvider.Extensibility;

namespace MvcSiteMapProvider
{
    class DefaultSiteMapNodeDynamicTitleProvider
        : ISiteMapNodeDynamicTitleProvider
    {
        public string GetTitle(SiteMapNode node, HttpContext context, IDictionary<string, object> sourceMetadata)
        {
            return node.Title;
        }
    }
}
