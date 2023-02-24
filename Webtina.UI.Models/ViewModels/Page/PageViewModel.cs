using System;
using System.Collections.Generic;
using System.Text;

namespace Webtina.UI.Models.ViewModels
{
    public class PageViewModel
    {
        public int ID { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Pic { get; set; }
        public string SubTitle { get; set; }
        public string Text { get; set; }
        public string RobotAccess { get; set; }
        public string SeoTitle { get; set; }
        public string Description { get; set; }

        public List<PageItemViewModel> Items { get; set; }

    }

    public class PageItemViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string TextContent { get; set; }
        public int Priority { get; set; }
        public string FileName { get; set; }
    }
}
