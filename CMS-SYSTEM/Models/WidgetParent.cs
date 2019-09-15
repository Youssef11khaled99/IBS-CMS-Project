using System;
using System.Collections.Generic;

namespace CMS_SYSTEM.Models
{
    public partial class WidgetParent
    {
        public WidgetParent()
        {
            Content = new HashSet<Content>();
        }

        public int Id { get; set; }
        public int Pid { get; set; }
        public int Wid { get; set; }
        public int WebsitesId { get; set; }

        public virtual Widget W { get; set; }
        public virtual Websites Websites { get; set; }
        public virtual ICollection<Content> Content { get; set; }
    }
}
