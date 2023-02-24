using System;
using System.Collections.Generic;
using System.Text;
using Webtina.UI.Models.Enums;

namespace Webtina.UI.Models.ViewModels
{
    public class MenuViewModel
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int Priority { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Priotity { get; set; }
        public MenuPosition Position { get; set; }
        public List<MenuViewModel> SubMenus { get; set; }
    }
}
