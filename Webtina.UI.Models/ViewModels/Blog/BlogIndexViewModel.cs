using System;
using System.Collections.Generic;
using System.Text;

namespace Webtina.UI.Models.ViewModels
{
    public class BlogIndexViewModel
    {
        public IEnumerable<BlogListItemViewModel> Blogs { get; set; }
        public IEnumerable<BlogListItemViewModel> News { get; set; }
        public IEnumerable<GalleryViewModel> Galleries { get; set; }

    }
}
