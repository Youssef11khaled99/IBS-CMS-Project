﻿using System;
using System.Collections.Generic;

namespace CMS_SYSTEM.Models
{
    public partial class WidgetType
    {
        public WidgetType()
        {
            Widget = new HashSet<Widget>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Section { get; set; }

        public virtual ICollection<Widget> Widget { get; set; }
    }
}
