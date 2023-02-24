using System;
using System.Collections.Generic;
using System.Text;
using Webtina.UI.Models.Enums;

namespace Webtina.UI.Models
{
    public class Tenant
    {
        public int UserId { get; set; }
        public ShopType ShopType { get; set; }
        public string Theme => SiteStyle;
        public string SiteName { get; set; }
        private string SiteStyle { get; set; }

        /// <summary>
        /// Tenant items
        /// </summary>
        public Dictionary<string, object> Items { get; private set; } = new Dictionary<string, object>();
    }
}
