using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using SitecoreMvcPlayground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMvcPlayground.Repositioris
{
    public class DriverRepository
    {
        public Driver GetDriver()
        {
            var driver = new Driver();
            var rendering = RenderingContext.Current.Rendering;

            var datasource = rendering.Item;

            driver.Name = new HtmlString(FieldRenderer.Render(datasource, "Name"));
            driver.Text = new HtmlString(FieldRenderer.Render(datasource, "Text"));

            return driver;
        }
    }
}