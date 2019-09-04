using System;
using System.Collections.Generic;

namespace CMS_SYSTEM.Models
{
    public partial class Widget
    {
        public Widget()
        {
            WidgetParent = new HashSet<WidgetParent>();
        }

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
        public string HtmlBody { get; set; }

        public virtual WidgetType WidgetType { get; set; }
        public virtual ICollection<WidgetParent> WidgetParent { get; set; }
    }
}
