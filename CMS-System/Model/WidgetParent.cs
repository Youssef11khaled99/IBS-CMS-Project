using System;
using System.Collections.Generic;

namespace CMS_System.Model
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
        public int UserWebsitesId { get; set; }

        public virtual UserWebsites UserWebsites { get; set; }
        public virtual Widget W { get; set; }
        public virtual ICollection<Content> Content { get; set; }
    }
}
