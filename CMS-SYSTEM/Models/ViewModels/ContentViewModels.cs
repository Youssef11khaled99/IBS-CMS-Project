using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_SYSTEM.Models.ViewModels
{
    public class ContentViewModels
    {
        public List<Content> Contents { get; set; }

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
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public int Pid { get; set; }
    }
}
