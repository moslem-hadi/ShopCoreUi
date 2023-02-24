using System;
using System.Collections.Generic;
using System.Text;
using Webtina.UI.Models.Enums;

namespace Webtina.UI.Models.ViewModels
{
    public class PostCategoryViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public string SeoTitle { get; set; }

        public string SeoDesciption { get; set; }

        public string Text { get; set; }
        public PostType Type { get; set; }


    }
}
