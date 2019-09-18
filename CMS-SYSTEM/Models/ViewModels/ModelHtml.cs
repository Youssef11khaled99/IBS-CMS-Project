using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CMS_SYSTEM.Models.ViewModels
{
    public class ModelHtml
    {

        [AllowHtml]
        public string HtmlBody { get; set; }
    }
}
