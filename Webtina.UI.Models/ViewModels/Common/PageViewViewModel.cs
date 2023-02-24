using System;
using System.Collections.Generic;
using System.Text;

namespace Webtina.UI.Models.ViewModels
{
    public class PageViewViewModel
    {
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }

        public string UserOs { get; set; }

        public string Referer { get; set; }

        public string PageViewd { get; set; }
    }
}
