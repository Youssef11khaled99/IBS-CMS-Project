using System;
using System.Collections.Generic;

namespace CMS_SYSTEM.Models
{
    public partial class UserWebsites
    {
        public UserWebsites()
        {
            WidgetParent = new HashSet<WidgetParent>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string DomainUrl { get; set; }
        public string WebsiteName { get; set; }
        public bool isDeleted { get; set; }
       

        public virtual ICollection<WidgetParent> WidgetParent { get; set; }
    }
}
