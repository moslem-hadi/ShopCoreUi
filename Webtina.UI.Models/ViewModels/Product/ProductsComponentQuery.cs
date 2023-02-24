using System;
using System.Collections.Generic;
using System.Text;
using Webtina.UI.Models.Enums;

namespace Webtina.UI.Models.ViewModels
{
    /// <summary>
    /// مدل برای فیلتر کامپوننت محصولات
    /// </summary>
    public class ProductsComponentQuery
    {
        public int Count { get; set; }

        public int? GroupId { get; set; }

        public ShopType ShopType { get; set; }

        public int UserId { get; set; }

        public PriceType PriceType { get; set; }
    }
}
