using System;
using System.Collections.Generic;

namespace CMS_System.Model
{
    public partial class Languages
    {
        public Languages()
        {
            Content = new HashSet<Content>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsDefault { get; set; }

        public virtual ICollection<Content> Content { get; set; }
    }
}
