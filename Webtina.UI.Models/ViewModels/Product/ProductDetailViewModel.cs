using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webtina.UI.Framework.Helper;

namespace Webtina.UI.Models.ViewModels
{
    public class ProductDetailsViewModel
    {
        public int Id { get; set; }
        
        public string Title { get; set; }

        public string Slug { get => Title.Slugify(); }

        public string Text { get; set; }
        public int ViewCount { get; set; }

        public string Pic { get; set; }
        public string PicUrl { get => $"http://nikanlink.com/content/productpic/{Pic}"; }

        public int Price { get; set; }
        public int OldPrice { get; set; }
        public string PriceDispay => Price.ToNumeric();
        public string PriceHezarDispay => (Price / 1000).ToNumeric();
        public string OldPriceDispay => Price.ToNumeric();

        public bool IsFree => Price == 0;

        /// <summary>
        ///تاریخ افزودن
        /// </summary>
        public DateTime RegDate { get; set; }
        public string RegDateDisplay => RegDate.ToShortPersian();

        public int FileSize { get; set; }
        public string FileSizeDisplay { get => FileSize.BytesToString(); }



        public string Mohtava { get; set; }
        public string Help { get; set; }
        public string FileFormat { get; set; }


        public int UserId { get; set; }
        public string UserPic { get; set; }
        public string UserPicUrl { get => $"http://nikanlink.com/content/userspic/{UserPic}"; }
        public string UserFullName { get; set; }


        public string MainFileFormat { get; set; }
        public int PageCount { get; set; }
        public DateTime? SpecialOfferEnd { get; set; }
        public bool? HasSpecialOffer { get; set; }



        public string KeyWords { get; set; }
        public IEnumerable<string> KeyWordsList => KeyWords.Split(',').Take(5).AsEnumerable();

        public int GroupId { get; set; }
        public string GroupTitle { get; set; }
        public string GroupTitleSlug => GroupTitle.Slugify();

        public int SubGroupId { get; set; }
        public string SubGroupTitle { get; set; }
        public string SubGroupTitleSlug => SubGroupTitle.Slugify();


    }
     
}
