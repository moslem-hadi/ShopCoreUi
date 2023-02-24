using System;
using System.Collections.Generic;
using System.Text;
using Webtina.UI.Models.Enums;

namespace Webtina.UI.Models.ViewModels
{
    public class HomePageComponentViewModel
    {
        public ComponentType EntityType { get; set; }
        public string ComponentName => EntityType.ToString();

        public int EntityId { get; set; }


    }
}
