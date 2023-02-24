using System;
using System.Collections.Generic;
using System.Text;
using Webtina.UI.Models.Enums;

namespace Webtina.UI.Models.ViewModels
{
    public class BlogListQuery: PagedModel
    {
        public PostType Type { get; set; }
        public int? PostGroupId { get; set; }
        public int LanquageId { get; set; }
    }
}
