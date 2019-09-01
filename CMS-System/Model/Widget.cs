using System;
using System.Collections.Generic;

namespace CMS_System.Model
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
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? WidgetOrdinal { get; set; }
        public bool? IsValid { get; set; }
        public int? BaseId { get; set; }
        public bool? IsActive { get; set; }
        public int TypeId { get; set; }
        public int WidgetTypeId { get; set; }

        public virtual WidgetType WidgetType { get; set; }
        public virtual ICollection<WidgetParent> WidgetParent { get; set; }
    }
}
