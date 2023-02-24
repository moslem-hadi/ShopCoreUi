using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Webtina.UI.Models.Enums
{
    public enum PostType : short
    {
        /// <summary>
        /// خبر
        /// </summary>
        [Display(Name = "خبر")]
        News = 1,


        /// <summary>
        /// مقاله
        /// </summary>
        [Display(Name = "مقاله")]
        Article = 2,

        /// <summary>
        /// آموزش
        /// </summary>
        [Display(Name = "آموزش")]
        Learn = 3,


        /// <summary>
        /// سوال
        /// </summary>
        [Display(Name = "سوال")]
        Faq = 4
    }
}
