using System;
using System.Collections.Generic;
using System.Text;
using Webtina.UI.Framework.Helper;

namespace Webtina.UI.Models.ViewModels
{
    /// <summary>
    /// مدل برای باکس های گرید مانند
    /// </summary>
   public class GridProductViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Slug { get => Title.Slugify(); }

        public int Price { get; set; }
        public string PicUrl { get=> $"/content/products/{Pic}";  }
        public string Pic { get; set; }
        public int OldPrice { get; set; }


        public string PriceDispay => Price.ToNumeric();
        public string PriceHezarDispay => (Price/1000).ToNumeric();

        public string OldPriceDispay => Price.ToNumeric();

    }
}
