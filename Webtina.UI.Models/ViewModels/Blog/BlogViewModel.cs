using System;
using Webtina.UI.Framework.Helper;
using Webtina.UI.Models.Enums;

namespace Webtina.UI.Models.ViewModels
{
    public class BlogViewModel: BlogListItemViewModel
    {
        public string SeoTitle { get; set; }

        public string SeoDesciption { get; set; }

        public string Text { get; set; }
        public PostType Type { get; set; }

    }
}
