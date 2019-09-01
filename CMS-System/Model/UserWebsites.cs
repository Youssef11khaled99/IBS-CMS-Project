using System;
using System.Collections.Generic;

namespace CMS_System.Model
{
    public partial class UserWebsites
    {
        public UserWebsites()
        {
            WidgetParent = new HashSet<WidgetParent>();
        }

        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public string DomainUrl { get; set; }

        public virtual ICollection<WidgetParent> WidgetParent { get; set; }
    }
}
