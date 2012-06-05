using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MvcSiteMapProvider.Extensibility
{
    public interface ISiteMapNodeDynamicTitleProvider
    {
        string GetTitle(SiteMapNode node, HttpContext context, IDictionary<string, object> sourceMetadata);
    }
}
