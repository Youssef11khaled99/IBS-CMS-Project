﻿using System;
using System.Collections.Generic;

namespace CMS_System.Model
{
    public partial class Content
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Lid { get; set; }
        public string MetaDescription { get; set; }
        public string Body { get; set; }
        public bool? IsValid { get; set; }
        public int? BaseWidgetId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int Pid { get; set; }

        public virtual Languages L { get; set; }
        public virtual WidgetParent P { get; set; }
    }
}
