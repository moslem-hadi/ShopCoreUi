using System;
using System.Collections.Generic;
using Webtina.UI.Framework.Helper;

namespace Webtina.UI.Models.ViewModels
{
    public class BlogSideBarViewModel
    {
        public IEnumerable<BlogListItemViewModel> LatestBlogPosts { get; set; }
        public IEnumerable<PostCategoryViewModel> TopCategories { get; set; }
    }
}
