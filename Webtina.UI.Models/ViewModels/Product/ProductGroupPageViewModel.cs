using System.Collections.Generic;

namespace Webtina.UI.Models.ViewModels
{
    public class ProductGroupPageViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }

        public List<GridProductViewModel> Products { get; set; }
    }
}
