using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MvcSiteMapProvider.Extensibility;

namespace MvcSiteMapProvider
{
    class DefaultSiteMapNodeDynamicTitleProvider
        : ISiteMapNodeDynamicTitleProvider
    {
        public string GetTitle(SiteMapNode node, ViewDataDictionary viewData, IDictionary<string, object> sourceMetadata)
        {
            return node.Title;
        }
    }
}
