using System;
using System.Collections.Generic;
using System.Text;
using Webtina.UI.Models.Enums;

namespace Webtina.UI.Models.ViewModels
{
    public class PostCategoryQuery
    {
        public PostType Type { get; set; }
        public int Count { get; set; }
        public int LanquageId { get; set; }
    }
}
