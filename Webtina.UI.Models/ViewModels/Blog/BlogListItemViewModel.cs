using System;
using System.Collections.Generic;
using System.Text;
using Webtina.UI.Framework.Helper;
using Webtina.UI.Models.Enums;

namespace Webtina.UI.Models.ViewModels
{
    public class BlogListItemViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Pic { get; set; }

        public string AuthorName { get; set; }

        public string CategoryName { get; set; }

        public string Brief { get; set; }

        public string Url { get; set; }

        public DateTime RegDate { get; set; }
        public string PublishDate { get; set; }
        public PostType Type { get; set; }

        //public string PublishDateFa => PublishDate.ToPersianWithNamedMonth2();


    }
}
