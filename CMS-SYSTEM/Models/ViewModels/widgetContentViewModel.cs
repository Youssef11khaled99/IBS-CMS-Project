using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CMS_SYSTEM.Models.ViewModels
{
    public class widgetContentViewModel
    {
        public int WebsiteId { get; set; }

        public string Title { get; set; }

        public int SelectedWidgetId { get; set; }

        [AllowHtml]
        public string HtmlBody { get; set; }
    }
}
