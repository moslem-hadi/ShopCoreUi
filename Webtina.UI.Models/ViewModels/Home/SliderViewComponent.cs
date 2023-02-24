using System;
using System.Collections.Generic;
using System.Text;

namespace Webtina.UI.Models.ViewModels
{
    public class GalleryViewModel
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string TextContent { get; set; }
        public string Title { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public IEnumerable<GalleryContentViewModel> Contents { get; set; }
    }

    public class GalleryContentViewModel
    {
        public int Id { get; set; }
        public int GalleryId { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string TextContent { get; set; }
        public int Type { get; set; }//TODO: enum
    }

}
