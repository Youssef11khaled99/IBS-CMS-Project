using System;
using System.Collections.Generic;

namespace CMS_SYSTEM.Models
{
    public partial class UserWebsites
    {
        public int Id { get; set; }
        public int WebsiteId { get; set; }
        public string UserEmail { get; set; }
    }
}
