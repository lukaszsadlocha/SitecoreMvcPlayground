using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Mvc.Helpers;
using Sitecore.Data.Items;

namespace SitecoreMvcPlayground.Helpers
{
    public static class SitecoreFieldHelper
    {
        public static HtmlString ImageField(this SitecoreHelper helper, string fieldName, Item item, int mh, int mw, bool disableWebEditing = false)
        {
            return helper.Field(fieldName, item, new { mh, mw, disableWebEditing });

        }
    }
}