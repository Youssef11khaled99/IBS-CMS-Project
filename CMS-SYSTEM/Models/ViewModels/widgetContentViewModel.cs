using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CMS_SYSTEM.Models.ViewModels
{
    public class widgetContentViewModel
    {
        public int WebsiteId { get; set; }

        [Required]
        public string Title { get; set; }

        public int SelectedWidgetId { get; set; }

        [AllowHtml]
        public string HtmlBody { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string MetaDesc { get; set; }

        public int[] widgetList { get; set; }

        public string[] widgetList2 { get; set; }

    }
}
