using System;
using System.Collections.Generic;
using System.Text;
using Webtina.UI.Models.Enums;

namespace Webtina.UI.Models.ViewModels.Common
{

    public class SitemapUrl
    {
        public string Url { get; set; }
        public DateTime? Modified { get; set; }
        public ChangeFrequency? ChangeFrequency { get; set; }
        public double? Priority { get; set; }
    }
}
