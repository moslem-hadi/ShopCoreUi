using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Webtina.UI.Models.Enums
{

    public enum MenuPosition
    {
        [Display(Name = "هدر")]
        Main = 0,
        [Display(Name = "باکس اول فوتر")]
        Footer_One = 1,
        [Display(Name = "باکس دوم فوتر")]
        Footer_Two = 2,
        [Display(Name = "باکس سوم فوتر")]
        Footer_Three = 3
    }
}
