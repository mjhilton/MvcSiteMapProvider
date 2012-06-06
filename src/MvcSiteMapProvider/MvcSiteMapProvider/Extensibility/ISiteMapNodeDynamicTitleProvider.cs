using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MvcSiteMapProvider.Extensibility
{
    public interface ISiteMapNodeDynamicTitleProvider
    {
        string GetTitle(SiteMapNode node, ViewDataDictionary viewData, IDictionary<string, object> sourceMetadata);
    }
}
