using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CMS_SYSTEM.Models.ViewModels
{
    public class WidgetViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool? IsPublished { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public int? WidgetOrdinal { get; set; }
        public bool? IsValid { get; set; }
        public int? BaseId { get; set; }
        public bool? IsActive { get; set; }
        public int WidgetTypeId { get; set; }

        [AllowHtml]
        public string HtmlBody { get; set; }
    }
}
